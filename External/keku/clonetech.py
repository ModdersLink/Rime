#!/usr/bin/env python
"""clonetech <db-in> <db-out> <shaderExactName> <fromTech> <toTech>
Clone a shader's solutions of technique <fromTech> into NEW solutions with technique <toTech>:
- new SolutionState = copy of the src state with byte[+14] = toTech
- new Solution      = copy of the src solution (same vp/pp/gp/vc/pc perms) with [0]=fletcher64(new state)
- append both (sol[] and state[] are PARALLEL arrays) and add the new index to the shader's solRef list.
So a runtime request for technique <toTech> (which the shader lacked) now resolves to a solution carrying
the shader's OWN valid perms → the material RENDERS (with the fromTech look). Fix for a foreign vehicle whose
material-state requests camo(09) but whose shader only has {0,1} (klr650 dirt bike → invisible)."""
import struct, sys
import shaderdb_merge as S

def clonetech(d, name, fromT, toT):
    key = S.hashquick(name.lower())
    paths = S.parse_container(d)
    out = bytearray(); out += struct.pack('<I', len(paths))
    total = 0
    for p in paths:
        db = bytearray(d[p['ver_rp_start']:p['db_end']])   # start from a verbatim copy of this db
        # locate the shader in this path
        sh_i = None
        for i, (st, en) in enumerate(p['sh']):
            if struct.unpack_from('<I', d, st)[0] == key:
                sh_i = i; break
        if sh_i is None:
            out += struct.pack('<II', p['path_id'], len(db)); out += db; continue
        # collect fromT solutions referenced by this shader
        clones = []   # (src_sol_range, src_state_range)
        for sp in p['sh_solpos'][sh_i]:
            sidx = struct.unpack_from('<H', d, sp)[0]
            if sidx >= len(p['state']): continue
            if d[p['state'][sidx][0] + 14] == fromT:
                clones.append((p['sol'][sidx], p['state'][sidx]))
        if not clones:
            out += struct.pack('<II', p['path_id'], len(db)); out += db; continue
        # build new sol/state blobs + the new indices (appended after existing S entries)
        nSol = len(p['sol'])
        new_sol = bytearray(); new_state = bytearray(); new_idx = []
        for k, (solr, str_) in enumerate(clones):
            st = bytearray(d[str_[0]:str_[1]])          # 32B SolutionState
            st[14] = toT
            so = bytearray(d[solr[0]:solr[1]])          # 64B Solution
            struct.pack_into('<Q', so, 0, S.fletcher64(bytes(st)))
            new_state += st; new_sol += so; new_idx.append(nSol + k)
        # rebuild THIS db from parsed sections (verbatim) with sol/state extended + the shader entry patched
        nb = bytearray(); nb += struct.pack('<II', 182, p['path_id'])
        def emit(n, blob): nb.extend(struct.pack('<I', n)); nb.extend(blob)
        def cat(ranges):
            o = bytearray()
            for r in ranges: o += d[r[0]:r[1]]
            return bytes(o)
        emit(len(p['const']), cat(p['const']))
        emit(len(p['cf']), cat(p['cf']))
        emit(len(p['tf']), cat(p['tf']))
        emit(len(p['vp']), cat(p['vp']))
        emit(len(p['pp']), cat(p['pp']))
        emit(len(p['gp']), cat(p['gp']))
        emit(len(p['sol']) + len(clones), cat(p['sol']) + bytes(new_sol))
        emit(len(p['state']) + len(clones), cat(p['state']) + bytes(new_state))
        emit(len(p['decl']), cat(p['decl']))
        # shaders: all verbatim EXCEPT the target — rebuild it with nSolRef extended by new_idx (u16)
        sh_blob = bytearray()
        for i, (st, en) in enumerate(p['sh']):
            if i != sh_i:
                sh_blob += d[st:en]; continue
            positions = p['sh_solpos'][i]
            nsr_pos = positions[0] - 4 if positions else en - 4   # the u32 nSolRef precedes the refs
            # header .. up to (and including) the nSolRef u32, then old refs, then new refs
            head = bytearray(d[st:nsr_pos])
            oldn = struct.unpack_from('<I', d, nsr_pos)[0]
            refs = bytearray(d[nsr_pos+4: nsr_pos+4+oldn*2])
            for ni in new_idx: refs += struct.pack('<H', ni)
            head += struct.pack('<I', oldn + len(new_idx)) + refs
            # anything after the refs (should be nothing — refs end the shader entry)
            head += d[nsr_pos+4+oldn*2: en]
            sh_blob += head
        emit(len(p['sh']), bytes(sh_blob))
        out += struct.pack('<II', p['path_id'], len(nb)); out += nb
        total += len(clones)
    return bytes(out), total

if __name__ == '__main__':
    din = open(sys.argv[1], 'rb').read()
    name = sys.argv[3]; fromT = int(sys.argv[4]); toT = int(sys.argv[5])
    res, n = clonetech(din, name, fromT, toT)
    if n == 0:
        print("clonetech: no tech-%d solutions on '%s' — nothing written" % (fromT, name)); sys.exit(1)
    open(sys.argv[2], 'wb').write(res)
    print("clonetech: +%d solution(s) tech%d->tech%d on '%s' -> %s (%d bytes)" % (n, fromT, toT, name, sys.argv[2], len(res)))
    S.parse_container(open(sys.argv[2], 'rb').read()); print("RE-PARSE OK")
