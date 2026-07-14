#!/usr/bin/env python3
"""Import-coverage check for a noncas bundle: every partition guid imported by the MAIN
generated partition should be either EMBEDDED in the same bundle or globally resident."""
import struct, sys
sys.path.insert(0, r'C:\Users\keku\AppData\Local\Temp\claude\C--Users-keku\c0de2aae-1031-4ae4-8d0d-3f554f03c887\scratchpad')
from ncdiff import parse_bundle
from sbdiff import unobfuscate, parse_entries, find_bundles, R

GLOBALLY_RESIDENT = {
    # MaterialContainer b50615c2 (shared/settings, boot-resident) in RAW import-table byte order
    'c21506b5434719499a40a738150debe9',
}

def ebx_imports(d, off):
    """(partitionGuid raw-hex set) imported by the EBX at file offset off (LE)."""
    assert d[off:off+4] == b'\xCE\xD1\xB2\x0F'
    (imp,) = struct.unpack_from('<I', d, off + 12)
    out = set()
    p = off + 80
    for i in range(imp):
        out.add(d[p:p+16].hex()); p += 32
    return out

def ebx_partguid(d, off):
    return d[off+48:off+64].hex()

def main():
    toc_path, sb_path, main_name = sys.argv[1], sys.argv[2], sys.argv[3]
    d = open(sb_path, 'rb').read()
    toc = unobfuscate(toc_path)
    bl = find_bundles(parse_entries(R(toc), len(toc)))
    f = {n: v for n, t, v in bl[0][2]}
    b = parse_bundle(d, f['offset'])
    print('bundle: %s | ebx=%d res=%d chunks=%d | sb=%d B' % (f.get('id'), b['ebx'], b['res'], b['chunks'], len(d)))

    embedded = {}
    main_off = None
    for kind, nm, absoff, reloff, ps, os_, raw, head in b['payloads']:
        if kind != 'ebx':
            continue
        embedded[ebx_partguid(d, absoff)] = nm
        if nm == main_name:
            main_off = absoff

    imports = ebx_imports(d, main_off)
    missing = [g for g in imports if g not in embedded and g not in GLOBALLY_RESIDENT]
    resident = [g for g in imports if g in GLOBALLY_RESIDENT]
    print('main imports %d distinct partitions: %d embedded, %d globally-resident, %d MISSING' %
          (len(imports), len(imports) - len(missing) - len(resident), len(resident), len(missing)))

    allmiss = set()
    for kind, nm, absoff, reloff, ps, os_, raw, head in b['payloads']:
        if kind != 'ebx':
            continue
        for g in ebx_imports(d, absoff):
            if g not in embedded and g not in GLOBALLY_RESIDENT:
                allmiss.add(g)
    print('transitive missing (all embedded partitions): %d' % len(allmiss))

if __name__ == '__main__':
    main()
