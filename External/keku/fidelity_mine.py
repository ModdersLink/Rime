#!/usr/bin/env python3
"""Mine exact DICE descriptor metadata (flags/soff/sizes) from vanilla EBX binaries into
fidelity_fb2.json for Rime's byte-faithful EbxWriter. Mergeable: run over many files.
Usage: fidelity_mine.py <out.json> <ebx1.bin> [ebx2.bin ...]   (accepts .sb too - finds the magic)
"""
import json, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from ebxdiff import Ebx

FT_VOID, FT_VALUETYPE, FT_CLASS, FT_ARRAY, FT_ENUM = 0, 2, 3, 4, 8

def code_of(flags):
    return (flags >> 4) & 0x1F

def mine(e, out, src):
    for ti, t in enumerate(e.types):
        rows = e.fields[t['layout']:t['layout'] + t['fcount']]
        if t['name'] == 'array':
            mem = rows[0]
            c = code_of(mem['flags'])
            if c == FT_CLASS:
                key = 'class'
            elif c == FT_VALUETYPE:
                key = 'struct:' + e.types[mem['ftype']]['name']
            elif c == FT_ENUM:
                key = 'enum:' + e.types[mem['ftype']]['name']
            else:
                key = 'prim:%d' % c
            prev = out['arrayMembers'].get(key)
            if prev is not None and prev != mem['flags']:
                print('CONFLICT arrayMember %s: %04X vs %04X (%s)' % (key, prev, mem['flags'], src))
            out['arrayMembers'][key] = mem['flags']
            continue
        # enum type descriptors: category ValueType + typecode Enum on the TYPE flags
        is_enum = code_of(t['flags']) == FT_ENUM
        trow = {'flags': t['flags'], 'align': t['align'], 'size': t['size'], 'ssize': t['ssize']}
        prev = out['types'].get(t['name'])
        if prev is not None:
            for k in trow:
                if prev[k] != trow[k]:
                    print('CONFLICT type %s.%s: %s vs %s (%s)' % (t['name'], k, prev[k], trow[k], src))
            trow = prev            # keep merging fields into the existing row
        else:
            trow['fields'] = {}
            out['types'][t['name']] = trow
        if is_enum:
            continue               # enum "fields" are the members; writer regenerates from C# enum
        for f in rows:
            if f['name'] == '$':
                continue
            frow = {'flags': f['flags'], 'offset': f['off'], 'soff': f['soff']}
            prevf = trow['fields'].get(f['name'])
            if prevf is not None and prevf != frow:
                print('CONFLICT field %s.%s: %s vs %s (%s)' % (t['name'], f['name'], prevf, frow, src))
            trow['fields'][f['name']] = frow
            # primitive fallback table (typecode -> full flags)
            c = code_of(f['flags'])
            if c not in (FT_VOID, FT_VALUETYPE, FT_CLASS, FT_ARRAY, FT_ENUM):
                pk = str(c)
                prevp = out['primitives'].get(pk)
                if prevp is None:
                    out['primitives'][pk] = f['flags']
                elif prevp != f['flags']:
                    print('note: primitive %s flags vary: %04X vs %04X (%s.%s in %s) - keeping first' %
                          (pk, prevp, f['flags'], t['name'], f['name'], src))

def main():
    out_path = sys.argv[1]
    out = {'types': {}, 'arrayMembers': {}, 'primitives': {}}
    if os.path.exists(out_path):
        out = json.load(open(out_path))
        print('merging into existing %s (%d types)' % (out_path, len(out['types'])))
    for src in sys.argv[2:]:
        e = Ebx(open(src, 'rb').read())
        mine(e, out, os.path.basename(src))
        print('mined %s: now %d types, %d arrayMembers, %d primitives' %
              (os.path.basename(src), len(out['types']), len(out['arrayMembers']), len(out['primitives'])))
    json.dump(out, open(out_path, 'w'), indent=1)
    print('wrote', out_path)

if __name__ == '__main__':
    main()
