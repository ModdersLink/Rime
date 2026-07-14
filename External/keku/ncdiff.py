#!/usr/bin/env python3
"""Binary NONCAS superbundle/bundle parser + differ (BF3 Frostbite2_0).
Format per Rime BundleManifest.cs: [u32 BE manifestSize][Header 32B][Sha1*EntryCount]
[EntryRecord*(ebx+res) 12B][u32 resTypes*res][16B resMeta*res][ChunkEntry*chunks 28B]
[chunkMeta DbObject if size>0][textblock to manifestSize+4] then align16 payloads.
All BE. Bundles located via the (obfuscated) toc.
"""
import struct, sys
sys.path.insert(0, r'C:\Users\keku\AppData\Local\Temp\claude\C--Users-keku\c0de2aae-1031-4ae4-8d0d-3f554f03c887\scratchpad')
from sbdiff import unobfuscate, parse_entries, find_bundles, R


def parse_bundle(d, off, deep=False):
    def u32(p): return struct.unpack_from('>I', d, p)[0]
    out = {'start': off, 'start_align16': off % 16 == 0}
    if u32(off + 4) != 0x970D1C13:
        out['NOT_NONCAS'] = 'head=' + d[off:off+8].hex()
        return out
    msize = u32(off)
    out['manifestSize'] = msize
    p = off + 4
    (magic, entryCount, ebxCount, resCount, chunkCount,
     strBlockOff, chunkMetaOff, chunkMetaSize) = struct.unpack_from('>8I', d, p)
    p += 32
    out.update(magic=hex(magic), entries=entryCount, ebx=ebxCount, res=resCount,
               chunks=chunkCount, strBlockOff=strBlockOff, chunkMetaOff=chunkMetaOff,
               chunkMetaSize=chunkMetaSize)
    sha1s = []
    for i in range(entryCount):
        sha1s.append(d[p:p+20].hex()); p += 20
    records = []
    for i in range(ebxCount + resCount):
        no, ps, os_ = struct.unpack_from('>3I', d, p); p += 12
        records.append((no, ps, os_))
    p += 4 * resCount          # resource types
    p += 16 * resCount         # resource metas
    chunks = []
    for i in range(chunkCount):
        cid = d[p:p+16].hex()
        rs, re_, lo = struct.unpack_from('>3I', d, p+16); p += 28
        chunks.append((cid, rs, re_, lo))
    out['chunkMeta_head'] = d[p:p+8].hex() if chunkMetaSize > 0 else None
    p += chunkMetaSize if chunkMetaSize > 0 else 0
    # text block runs to manifest end
    text_start = p
    manifest_end = off + 4 + msize
    text = d[text_start:manifest_end]
    out['textblock_size'] = len(text)
    names = []
    for no, ps, os_ in records:
        e = text.index(b'\0', no)
        names.append(text[no:e].decode('utf8', 'replace'))
    out['names'] = names
    out['records'] = records
    out['strBlockOff_expected(text_start-rel)'] = text_start - (off + 4)
    # payloads: align16 ABSOLUTE (per Rime reader), from manifest end
    p = manifest_end
    pay = []
    for i in range(ebxCount):
        p = (p + 15) & ~15
        no, ps, os_ = records[i]
        pay.append(('ebx', names[i], p, p - off, ps, os_, ps == os_, d[p:p+4].hex()))
        p += ps
    for i in range(resCount):
        p = (p + 15) & ~15
        no, ps, os_ = records[ebxCount + i]
        pay.append(('res', names[ebxCount + i], p, p - off, ps, os_, ps == os_, d[p:p+4].hex()))
        p += ps
    for i in range(chunkCount):
        p = (p + 15) & ~15
        cid, rs, re_, lo = chunks[i]
        pay.append(('chunk', cid[:8], p, p - off, re_ - rs, None, None, d[p:p+4].hex()))
        p += re_ - rs
    out['payloads'] = pay
    out['end'] = p
    return out


def show(tag, toc_path, sb_path, only=None, deep_first=1):
    d = open(sb_path, 'rb').read()
    toc = unobfuscate(toc_path)
    bl = find_bundles(parse_entries(R(toc), len(toc)))
    print('===== %s (%d bundles, sb %d B) =====' % (tag, len(bl), len(d)))
    shown = 0
    for e in bl:
        f = {n: v for n, t, v in e[2]}
        bid, boff, bsize = f.get('id'), f.get('offset'), f.get('size')
        if only and only.lower() not in str(bid).lower():
            continue
        b = parse_bundle(d, boff)
        print(' bundle %-52s off=%-9d (align16=%s) size=%d' % (bid, boff, boff % 16 == 0, bsize))
        if 'NOT_NONCAS' in b:
            print('   NOT the binary-noncas manifest format! %s' % b['NOT_NONCAS'])
            shown += 1
            continue
        print('   manifestSize=%d magic=%s entries=%d ebx=%d res=%d chunks=%d strBlockOff=%d(expected %d) cmOff=%d cmSize=%d textblk=%d' % (
            b['manifestSize'], b['magic'], b['entries'], b['ebx'], b['res'], b['chunks'],
            b['strBlockOff'], b['strBlockOff_expected(text_start-rel)'], b['chunkMetaOff'], b['chunkMetaSize'], b['textblock_size']))
        for kind, nm, absoff, reloff, ps, os_, raw, head in b['payloads'][:6]:
            print('   %-5s %-46s abs=%-9d rel=%-8d size=%-8s orig=%-8s raw=%s head=%s' % (kind, nm, absoff, reloff, ps, os_, raw, head))
        print('   bundle end=%d (declared size -> %d)' % (b['end'], boff + bsize))
        shown += 1
        if shown >= deep_first and not only:
            break


if __name__ == '__main__':
    VM = r'C:\Users\keku\Documents\Battlefield 3\Server\Admin\Mods'
    show('GRIDNC (Rime generated, HANGS)',
         r'F:\tmp\gridnc3\Win32\vehgrid\gridnc.toc', r'F:\tmp\gridnc3\Win32\vehgrid\gridnc.sb', deep_first=2)
    show('PROVPHYS (Rime existing, WORKS injected)',
         VM + r'\VehicleMenu\sb\Win32\vehprov\provphys.toc', VM + r'\VehicleMenu\sb\Win32\vehprov\provphys.sb')
    show('OBJPACK PROVSB (Rime DLC noncas, KLR works)',
         VM + r'\ObjPackPoC\sb\Win32\vehprov\provsb.toc', VM + r'\ObjPackPoC\sb\Win32\vehprov\provsb.sb')
    show('DICE XP2_PALACE loading_music',
         r'E:\GAMES\Battlefield 3\Update\Xpack2\Data\Win32\Levels\XP2_Palace\XP2_Palace.toc',
         r'E:\GAMES\Battlefield 3\Update\Xpack2\Data\Win32\Levels\XP2_Palace\XP2_Palace.sb', only='loading_music')
