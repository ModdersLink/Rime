#!/usr/bin/env python3
"""Grid merge tool: add materials present in a SOURCE grid but absent in a BASE grid.
Resizes the base InteractionGrid (N->N+1 per added material), copies the source material's
relation objects into the base partition (rewriting partition guids to the base grid partition),
and skips cells whose paired surface material is absent in the base (so we never pull in
FX for surfaces the base map doesn't have). Reusable for the POC (one material) and the union."""
import json, copy, sys

def load(p):
    d = json.load(open(p))
    grid = next(o for o in d['Instances'].values() if o.get('$type') == 'MaterialGridData')
    return d, grid

def idxmap(grid):
    return grid['MaterialIndexMap']  # list[180], global->local, 0=absent

def inv_local2global(im):
    # local index -> global (for present materials); local 0 is Default
    m = {}
    for g in range(len(im)):
        L = im[g]
        if L > 0:
            m[L] = g
    m[0] = 0  # default
    return m

def add_material(baseD, baseG, srcD, srcG, G, base_part, log):
    bim = idxmap(baseG); sim = idxmap(srcG)
    if bim[G] != 0:
        log.append(f"  {G}: already present in base (local {bim[G]}) -> skip"); return 0
    sL = sim[G]
    if sL == 0:
        log.append(f"  {G}: absent in source too -> skip"); return 0
    newL = len(baseG['InteractionGrid'])         # next free local index
    b_l2g = inv_local2global(bim)                 # base local -> global (BEFORE adding)
    b_l2g[newL] = G                               # the new material's local
    bim[G] = newL                                 # register in index map

    copied = {'n': 0}
    def copyrefs(reflist):
        out = []
        for r in reflist:
            gid = r['InstanceGuid']
            src_obj = srcD['Instances'].get(gid)
            if src_obj is None:
                continue
            if gid not in baseD['Instances']:
                baseD['Instances'][gid] = copy.deepcopy(src_obj)
                copied['n'] += 1
            out.append({'PartitionGuid': base_part, 'InstanceGuid': gid})
        return out

    def cell_from_src(src_row_local, src_col_local):
        c = srcG['InteractionGrid'][src_row_local]['Items'][src_col_local]
        return {'PhysicsMaterialProperties': copyrefs(c['PhysicsMaterialProperties']),
                'PhysicsPropertyProperties': copyrefs(c['PhysicsPropertyProperties'])}
    EMPTY = lambda: {'PhysicsMaterialProperties': [], 'PhysicsPropertyProperties': []}

    # 1) append a new column (interaction WITH the new material) to every existing row
    for i in range(newL):
        gi = b_l2g[i]
        si = sim[gi] if gi < len(sim) else 0
        baseG['InteractionGrid'][i]['Items'].append(cell_from_src(si, sL) if si > 0 else EMPTY())
    # 2) build the new row (new material vs every base local, incl itself as last col)
    new_items = []
    for j in range(newL + 1):
        gj = b_l2g[j]
        sj = sim[gj] if gj < len(sim) else 0
        new_items.append(cell_from_src(sL, sj) if sj > 0 else EMPTY())
    baseG['InteractionGrid'].append({'Items': new_items})
    # 3) MaterialProperties entry for the new local
    smp = srcG['MaterialProperties'][sL]
    baseG['MaterialProperties'].append({'PhysicsMaterialProperties': copyrefs(smp['PhysicsMaterialProperties']),
                                        'PhysicsPropertyProperties': copyrefs(smp['PhysicsPropertyProperties'])})
    log.append(f"  {G}: added as local {newL} (from src local {sL}); copied {copied['n']} relation instances")
    return 1

if __name__ == '__main__':
    base_json, src_json, out_json = sys.argv[1], sys.argv[2], sys.argv[3]
    globals_to_add = [int(x) for x in sys.argv[4:]]
    baseD, baseG = load(base_json); srcD, srcG = load(src_json)
    base_part = baseD['PartitionGuid']
    n0 = len(baseG['InteractionGrid'])
    log = []
    added = 0
    for G in globals_to_add:
        added += add_material(baseD, baseG, srcD, srcG, G, base_part, log)
    # sanity: InteractionGrid must stay square
    N = len(baseG['InteractionGrid'])
    ok = all(len(row['Items']) == N for row in baseG['InteractionGrid'])
    print('\n'.join(log))
    print(f"base locals {n0} -> {N}; added {added}; MaterialProperties={len(baseG['MaterialProperties'])}; square={ok}")
    assert ok, "InteractionGrid not square!"
    assert len(baseG['MaterialProperties']) == N, "MaterialProperties count mismatch"
    json.dump(baseD, open(out_json, 'w'))
    print('wrote', out_json)
