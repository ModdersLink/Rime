#!/usr/bin/env python3
"""EBX (Frostbite 2.0 / BF3) metadata parser + differ — the EbxWriter FIDELITY harness.
Parses header, imports, type strings, field descriptors, type descriptors, instance
entries, array entries. Mirrors Rime's RimeLib.Serialization.Frostbite2_0/Ebx/*.
Usage: ebxdiff.py <vanilla.bin> <generated.bin-or-.sb> [--full]
"""
import struct, sys

FIELD_TYPES = ['Void','DbObject','ValueType','Class','Array','FixedArray','String','CString',
               'Enum','FileRef','Boolean','Int8','UInt8','Int16','UInt16','Int32','UInt32',
               'Int64','UInt64','Float32','Float64','Guid','Sha1','ResourceRef']
CATS = ['NotApplicable?0','?1','ValueType?2','Class?3']  # placeholder; raw shown anyway

def hash_quick(s):
    h = 0x1505
    for ch in s:
        h = ((h * 0x21) ^ ord(ch)) & 0xFFFFFFFF
    return h

def find_ebx(data):
    """return (offset, size) of the EBX blob inside data (raw file or sb envelope)"""
    magic = b'\xCE\xD1\xB2\x0F'
    off = data.find(magic)
    if off < 0:
        raise SystemExit('no EBX magic found')
    meta, payload = struct.unpack_from('<II', data, off + 4)
    return off, meta + payload

def ftype_name(v):
    return FIELD_TYPES[v] if v < len(FIELD_TYPES) else 'FT%d' % v

def flags_str(bits):
    member = bits & 3
    cat = (bits >> 2) & 3
    code = (bits >> 4) & 0x1F
    extra = bits & 0xFF80  # anything above the packed member/cat/code fields
    s = 'm%d c%d %s' % (member, cat, ftype_name(code))
    if extra:
        s += ' +0x%04X' % extra
    return s

class Ebx:
    def __init__(self, data):
        off, size = find_ebx(data)
        d = self.d = data[off:off + size]
        (self.magic, self.metaSize, self.payloadSize, self.importCount, self.pad4,
         self.typeCount, self.typeDescCount, self.fieldDescCount, self.typeStrSize,
         self.strSize, self.arrayCount, self.arrayOffset) = struct.unpack_from('<12I', d, 0)
        self.partGuid = d[48:64].hex()
        self.primGuid = d[64:80].hex()
        p = 80
        self.imports = []
        for _ in range(self.importCount):
            self.imports.append((d[p:p+16].hex(), d[p+16:p+32].hex())); p += 32
        raw = d[p:p+self.typeStrSize]; p += self.typeStrSize
        self.typeStrings = [s.decode('utf8') for s in raw.rstrip(b'\0').split(b'\0')] if raw.strip(b'\0') else []
        self.h2s = {hash_quick(s): s for s in self.typeStrings}
        self.fields = []
        for _ in range(self.fieldDescCount):
            nh, fl, ft, ofs, sofs = struct.unpack_from('<IHHii', d, p); p += 16
            self.fields.append(dict(name=self.h2s.get(nh, '?%08X' % nh), flags=fl, ftype=ft, off=ofs, soff=sofs))
        p = (p + 15) & ~15
        self.types = []
        for _ in range(self.typeDescCount):
            nh, ld = struct.unpack_from('<II', d, p)
            fc, al = d[p+8], d[p+9]
            fl, sz, ssz = struct.unpack_from('<HHH', d, p+10); p += 16
            self.types.append(dict(name=self.h2s.get(nh, '?%08X' % nh), layout=ld, fcount=fc,
                                   align=al, flags=fl, size=sz, ssize=ssz))
        self.instances = []
        for _ in range(self.typeCount):
            ic, ec, ti = struct.unpack_from('<3I', d, p); p += 12
            self.instances.append(dict(internal=ic, export=ec, tidx=ti))
        p = (p + 15) & ~15
        self.arrays = []
        for _ in range(self.arrayCount):
            ofs, cnt, ti = struct.unpack_from('<3I', d, p); p += 12
            self.arrays.append(dict(off=ofs, count=cnt, tidx=ti))
        p = (p + 15) & ~15
        self.metaEnd = p
        # payload regions
        self.strTabAt = self.metaSize
        self.instPayloadAt = self.metaSize + self.strSize
        self.arrPayloadAt = self.metaSize + self.strSize + self.arrayOffset
        self.total = self.metaSize + self.payloadSize

    def tname(self, i):
        return self.types[i]['name'] if i < len(self.types) else '#%d!' % i

    def type_line(self, t):
        return '%-38s layout=%-4d fc=%-3d al=%-2d flags=%04X(%s) size=%-6d ssize=%d' % (
            t['name'], t['layout'], t['fcount'], t['align'], t['flags'], flags_str(t['flags']), t['size'], t['ssize'])

    def field_line(self, f):
        return '%-28s flags=%04X(%-22s) ftype=%-4d off=%-6d soff=%d' % (
            f['name'], f['flags'], flags_str(f['flags']), f['ftype'], f['off'], f['soff'])

def show(e, tag):
    print('== %s ==' % tag)
    print(' total=%d metaSize=%d payloadSize=%d pad4=%d' % (e.total, e.metaSize, e.payloadSize, e.pad4))
    print(' imports=%d instTypes=%d typeDescs=%d fieldDescs=%d typeStr=%d strTab=%d arrays=%d arrayOffset(instPayload)=0x%X(%d)' % (
        e.importCount, e.typeCount, e.typeDescCount, e.fieldDescCount, e.typeStrSize, e.strSize, e.arrayCount, e.arrayOffset, e.arrayOffset))
    print(' partition=%s primary=%s' % (e.partGuid, e.primGuid))

def main():
    a = Ebx(open(sys.argv[1], 'rb').read())
    b = Ebx(open(sys.argv[2], 'rb').read())
    full = '--full' in sys.argv
    show(a, 'VANILLA ' + sys.argv[1])
    show(b, 'GENERATED ' + sys.argv[2])

    print('\n== TYPE STRING TABLES ==')
    print(' vanilla  (%2d): %s' % (len(a.typeStrings), ' '.join(a.typeStrings)))
    print(' generated(%2d): %s' % (len(b.typeStrings), ' '.join(b.typeStrings)))
    sa, sb_ = set(a.typeStrings), set(b.typeStrings)
    if sb_ - sa: print(' EXTRA in generated: %s' % sorted(sb_ - sa))
    if sa - sb_: print(' MISSING in generated: %s' % sorted(sa - sb_))

    print('\n== TYPE DESCRIPTORS (in file order) ==')
    n = max(len(a.types), len(b.types))
    for i in range(n):
        ta = a.type_line(a.types[i]) if i < len(a.types) else '--'
        tb = b.type_line(b.types[i]) if i < len(b.types) else '--'
        mark = ' ' if ta == tb else '*'
        print('%s[%2d] V: %s' % (mark, i, ta))
        print('%s     G: %s' % (mark, tb))
    na = {t['name'] for t in a.types}; nb = {t['name'] for t in b.types}
    from collections import Counter
    ca, cb = Counter(t['name'] for t in a.types), Counter(t['name'] for t in b.types)
    if ca != cb:
        print(' TYPE-SET DIFF (name: vanillaCount vs genCount):')
        for k in sorted(set(ca) | set(cb)):
            if ca[k] != cb[k]:
                print('   %-38s %d vs %d' % (k, ca[k], cb[k]))

    print('\n== FIELD DESCRIPTORS (in file order) ==')
    n = max(len(a.fields), len(b.fields))
    for i in range(n):
        fa = a.field_line(a.fields[i]) if i < len(a.fields) else '--'
        fb = b.field_line(b.fields[i]) if i < len(b.fields) else '--'
        mark = ' ' if fa == fb else '*'
        if full or mark == '*':
            print('%s[%2d] V: %s' % (mark, i, fa))
            print('%s     G: %s' % (mark, fb))

    print('\n== INSTANCE ENTRIES ==')
    n = max(len(a.instances), len(b.instances))
    for i in range(n):
        ia = ('%-38s int=%d exp=%d' % (a.tname(a.instances[i]['tidx']), a.instances[i]['internal'], a.instances[i]['export'])) if i < len(a.instances) else '--'
        ib = ('%-38s int=%d exp=%d' % (b.tname(b.instances[i]['tidx']), b.instances[i]['internal'], b.instances[i]['export'])) if i < len(b.instances) else '--'
        mark = ' ' if ia == ib else '*'
        print('%s[%2d] V: %s' % (mark, i, ia))
        print('%s     G: %s' % (mark, ib))

    print('\n== ARRAYS ==')
    print(' vanilla: %d entries, payload %d bytes; generated: %d entries, payload %d bytes' % (
        len(a.arrays), a.total - a.arrPayloadAt, len(b.arrays), b.total - b.arrPayloadAt))
    from collections import Counter as C2
    aa = C2(a.tname(x['tidx']) for x in a.arrays); ab = C2(b.tname(x['tidx']) for x in b.arrays)
    for k in sorted(set(aa) | set(ab)):
        m = ' ' if aa[k] == ab[k] else '*'
        print('%s  %-38s vanilla=%d generated=%d' % (m, k, aa[k], ab[k]))
    za = sum(1 for x in a.arrays if x['count'] == 0); zb = sum(1 for x in b.arrays if x['count'] == 0)
    print('  zero-length arrays: vanilla=%d generated=%d' % (za, zb))
    # shared-offset dedupe check
    oa = len({(x['off']) for x in a.arrays}); ob = len({(x['off']) for x in b.arrays})
    print('  distinct array offsets: vanilla=%d generated=%d' % (oa, ob))

if __name__ == '__main__':
    main()
