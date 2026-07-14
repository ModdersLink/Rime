#!/usr/bin/env python3
"""Diff a Rime-written CAS bundle manifest vs the DICE original (BF3 Frostbite2 DbObject format).
Formats replicated from Rime-src: FileObfuscation (toc header magic 0x00/0x01CED100, 0x100 sig +
0x20 pad + 0x101 xorkey^0x7B + 3 align), DbObjectElement (type byte &0x1F | anon 0x80, null-term
name, 7-bit varint sizes for object/array/string/blob)."""
import struct, sys, json

def unobfuscate(path):
    d = open(path, 'rb').read()
    if len(d) < 4: return d
    magic = struct.unpack('<I', d[:4])[0]
    if magic in (0x00CED100, 0x01CED100):
        sig_end = 4 + 4 + 0x100 + 0x20
        xorkey = bytes(b ^ 0x7B for b in d[sig_end:sig_end + 0x101])
        payload = bytearray(d[0x22C:])
        if any(xorkey):  # all-zero key = no xor
            for i in range(len(payload)):
                payload[i] ^= xorkey[i % 0x101]
        return bytes(payload)
    if magic == 0x03CED100:
        return d[0x228 + 4:]  # skip 0x228 header total (incl magic+reserved... Rime seeks 0x228 AFTER magic read → total 0x22C)
    return d

class R:
    def __init__(self, b, o=0): self.b = b; self.o = o
    def u8(self): v = self.b[self.o]; self.o += 1; return v
    def bytes(self, n): v = self.b[self.o:self.o + n]; self.o += n; return v
    def cstr(self):
        e = self.b.index(0, self.o); v = self.b[self.o:e].decode('utf-8', 'replace'); self.o = e + 1; return v
    def varint(self):
        v = 0; s = 0
        while True:
            c = self.u8(); v |= (c & 0x7F) << s
            if not (c & 0x80): return v
            s += 7

TYPES = {0:'eoo',1:'array',2:'object',3:'homoarray',4:'null',5:'objectid',6:'bool',7:'string',
         8:'int',9:'long',10:'varint',11:'float',12:'double',13:'timestamp',14:'recordid',
         15:'guid',16:'sha1',19:'blob'}

def parse_entries(r, end):
    out = []
    while r.o < end:
        tb = r.u8()
        t = tb & 0x1F
        name = '' if (t == 0 or (tb & 0x80)) else r.cstr()
        if t == 0: break                       # eoo
        tn = TYPES.get(t, 'T%d' % t)
        if t in (1, 2, 3):                     # array/object
            size = r.varint(); sub_end = r.o + size
            val = parse_entries(r, sub_end); r.o = sub_end
        elif t == 7:
            n = r.varint(); val = r.bytes(n).rstrip(b'\0').decode('utf-8', 'replace')
        elif t == 19:
            n = r.varint(); val = '<blob:%d>' % n; r.o += n
        elif t == 6:  val = r.u8()
        elif t == 8:  val = struct.unpack('<i', r.bytes(4))[0]
        elif t == 9:  val = struct.unpack('<q', r.bytes(8))[0]
        elif t == 16: val = r.bytes(20).hex()
        elif t == 15: val = r.bytes(16).hex()
        elif t == 4:  val = None
        elif t == 5:  val = r.bytes(12).hex()          # ObjectId
        elif t == 10: val = r.varint()                 # VarInt
        elif t == 11: val = struct.unpack('<f', r.bytes(4))[0]
        elif t == 12: val = struct.unpack('<d', r.bytes(8))[0]
        elif t == 13: val = struct.unpack('<q', r.bytes(8))[0]  # Timestamp
        elif t == 14: val = r.bytes(6).hex()           # RecordId
        else: raise Exception('unhandled type %d @%d' % (t, r.o))
        out.append((name, tn, val))
    return out

def find_bundles(tree):
    """walk parsed tree, find the 'bundles' array of manifests"""
    for name, t, val in tree:
        if name == 'bundles' and t == 'array':
            return val
        if t in ('array', 'object', 'homoarray'):
            f = find_bundles(val)
            if f is not None: return f
    return None

def manifest_shape(m):
    """summarize a bundle manifest: top field order + entry field patterns + counts"""
    fields = [(n, t) for n, t, v in m]
    info = {'field_order': fields, 'counts': {}, 'entry_shapes': {}, 'samples': {}}
    for n, t, v in m:
        if t == 'array' and n in ('ebx', 'res', 'chunks', 'chunkMeta'):
            info['counts'][n] = len(v)
            shapes = {}
            for e in v[:2000]:
                if e[1] == 'object':
                    sig = tuple((en, et) for en, et, ev in e[2])
                    shapes[sig] = shapes.get(sig, 0) + 1
            info['entry_shapes'][n] = [(list(k), c) for k, c in sorted(shapes.items(), key=lambda x: -x[1])[:4]]
            if v and v[0][1] == 'object':
                info['samples'][n] = [(en, et, ev) for en, et, ev in v[0][2]]
        elif t != 'array':
            info.setdefault('scalars', {})[n] = (t, v)
    return info

def load_manifest(sb_path, want_path_contains):
    data = unobfuscate(sb_path)
    r = R(data)
    tree = parse_entries(r, len(data))
    bundles = find_bundles(tree)
    if bundles is None: raise Exception('no bundles list in ' + sb_path)
    out = {}
    for b in bundles:
        if b[1] != 'object': continue
        path = next((v for n, t, v in b[2] if n == 'path'), '?')
        out[path] = b[2]
    for p, m in out.items():
        if want_path_contains.lower() in p.lower():
            return p, m, list(out.keys())
    raise Exception('bundle %r not found; have %s' % (want_path_contains, list(out.keys())[:6]))

if __name__ == '__main__':
    dice_sb = 'E:/GAMES/Battlefield 3/Data/Win32/Levels/MP_017/MP_017.sb'
    ours_sb = 'F:/tmp/rmsc/Win32/Levels/REALITYMOD/REALITYMOD.sb'
    dp, dm, _ = load_manifest(dice_sb, 'levels/mp_017/mp_017')
    op, om, onames = load_manifest(ours_sb, 'realitymod_data')
    print('DICE bundle:', dp)
    print('OURS bundle:', op, ' (all ours:', onames, ')')
    di, oi = manifest_shape(dm), manifest_shape(om)
    print('\n=== TOP-LEVEL FIELD ORDER ===')
    print('DICE:', di['field_order'])
    print('OURS:', oi['field_order'])
    print('\n=== SCALARS ===')
    print('DICE:', di.get('scalars'))
    print('OURS:', oi.get('scalars'))
    print('\n=== COUNTS ===')
    print('DICE:', di['counts'])
    print('OURS:', oi['counts'])
    print('\n=== ENTRY SHAPES (field sets per array) ===')
    for k in ('ebx', 'res', 'chunks', 'chunkMeta'):
        print('--', k)
        print('  DICE:', di['entry_shapes'].get(k))
        print('  OURS:', oi['entry_shapes'].get(k))
    print('\n=== FIRST-ENTRY SAMPLES ===')
    for k in ('ebx', 'res', 'chunks', 'chunkMeta'):
        print('--', k)
        print('  DICE:', di['samples'].get(k))
        print('  OURS:', oi['samples'].get(k))
