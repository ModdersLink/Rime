#!/usr/bin/env python3
"""Bulk-mine the EBX fidelity map from RETAIL data (read-only).

The DLC superbundles are NONCAS, so every EBX partition sits in the .sb as a raw payload starting
with the EBX magic (CE D1 B2 0F). Scan them all, parse each partition's type/field descriptors, and
merge into fidelity_fb2.json (flags + primary offset + SECONDARY offset + sizes per field).

Usage: fidelity_bulk.py <out.json> <sb-or-dir> [...]
"""
import json, os, struct, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import ebxdiff
from fidelity_mine import mine

MAGIC = b'\xce\xd1\xb2\x0f'

def scan(path, out, stats):
    data = open(path, 'rb').read()
    i, found, ok = 0, 0, 0
    while True:
        i = data.find(MAGIC, i)
        if i < 0:
            break
        found += 1
        try:
            # sanity-check the header before trusting it
            (magic, metaSize, payloadSize, importCount, pad4, typeCount,
             typeDescCount, fieldDescCount, typeStrSize, strSize,
             arrayCount, arrayOffset) = struct.unpack_from('<12I', data, i)
            end = i + 16 + metaSize + payloadSize
            if metaSize < 64 or metaSize > 8_000_000 or payloadSize > 40_000_000 or end > len(data) \
               or typeCount == 0 or typeCount > 5000 or fieldDescCount > 100_000:
                i += 4
                continue
            e = ebxdiff.Ebx(data[i:end])
            mine(e, out, os.path.basename(path))
            ok += 1
            i = end
        except Exception:
            i += 4
    stats['files'] += 1
    stats['ebx'] += ok
    print("  %-46s ebx mined: %-5d (candidates %d) | types now %d" %
          (os.path.basename(path), ok, found, len(out['types'])))

def main():
    out_path = sys.argv[1]
    out = {'types': {}, 'arrayMembers': {}, 'primitives': {}}
    if os.path.exists(out_path):
        out = json.load(open(out_path))
        print('merging into existing %s (%d types)' % (out_path, len(out['types'])))
    targets = []
    for a in sys.argv[2:]:
        if os.path.isdir(a):
            for root, _, files in os.walk(a):
                for f in files:
                    if f.lower().endswith('.sb'):
                        targets.append(os.path.join(root, f))
        else:
            targets.append(a)
    stats = {'files': 0, 'ebx': 0}
    for t in sorted(targets):
        try:
            scan(t, out, stats)
        except Exception as ex:
            print("  SKIP", os.path.basename(t), ex)
    json.dump(out, open(out_path, 'w'), indent=1)
    print("\n%d files, %d EBX partitions mined -> %d types, %d arrayMembers, %d primitives -> %s"
          % (stats['files'], stats['ebx'], len(out['types']), len(out['arrayMembers']),
             len(out['primitives']), out_path))

if __name__ == '__main__':
    main()
