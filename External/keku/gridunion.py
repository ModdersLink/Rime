#!/usr/bin/env python3
"""UNIVERSAL material grid = union of all 47 levels' grids (keku's Phase A).
Base = mp_017 (proven with the LevelData swap). For each donor grid (vehicle maps first):
 - materials absent in U -> new local slot, rows/cols copied from the donor
 - cells where the donor has relation TYPES the U cell lacks -> append those relations (type-merge)
Relation instances are COPIED into the universal partition (self-contained, like vanilla);
their refs to EXTERNAL partitions (fx/decals/sound assets) stay as-is and lazy-resolve per map."""
import json, os, uuid, collections, copy

SRC = 'F:/tmp/allgrids'
BASE = 'mp_017'
PRIORITY = ['mp_017', 'xp3_desert', 'xp1_002', 'xp5_001', 'xp4_parl', 'mp_007', 'xp3_valley', 'xp3_shield',
            'xp3_alborz', 'xp1_001', 'xp1_003', 'xp1_004', 'xp5_002', 'xp5_003', 'xp5_004', 'xp4_fd',
            'xp4_quake', 'xp4_rubble', 'mp_001', 'mp_003', 'mp_011', 'mp_012', 'mp_013', 'mp_018', 'mp_subway']
NEW_PART = str(uuid.uuid4())
NEW_NAME = 'levels/realitymod/realitymod/universalgrid'

def val(x): return x.get('$value', x) if isinstance(x, dict) else x

def load(lvl):
    d = json.load(open(os.path.join(SRC, lvl + '.json')))
    inst = d['Instances']
    grid = next((o for o in inst.values() if o.get('$type') == 'MaterialGridData'), None)
    gid = next(g for g, o in inst.items() if o is grid)
    return d, inst, grid, gid

def rtype(inst, ref):
    o = inst.get(ref['InstanceGuid'])
    return o.get('$type') if o else None

baseD, baseI, U, baseGid = load(BASE)
UP = baseD['PartitionGuid']            # original partition guid of base (refs inside cells use it)
im = U['MaterialIndexMap']             # list[180]
IG = U['InteractionGrid']              # list[N] of {'Items': [N cells]}
MP_ = U['MaterialProperties']
Uinst = {baseGid: U}
# copy base's relation instances (all non-grid instances of the base partition)
for g, o in baseI.items():
    if g != baseGid:
        Uinst[g] = o

def l2g(imap):
    m = {0: 0}
    for gi, li in enumerate(imap):
        if li > 0: m[li] = gi
    return m

stats = collections.Counter()

def copy_rel(donorI, ref, donor_part):
    """bring a relation instance into U (dedupe by guid); return the new ref"""
    gid = ref['InstanceGuid']
    if gid not in Uinst:
        Uinst[gid] = copy.deepcopy(donorI[gid])
        stats['instances_copied'] += 1
    return {'PartitionGuid': NEW_PART, 'InstanceGuid': gid}

def merge_cell(ucell, dcell, donorI, donor_part):
    """append donor relations whose TYPE is missing in the U cell"""
    added = 0
    for ax in ('PhysicsMaterialProperties', 'PhysicsPropertyProperties'):
        utypes = set(rtype(Uinst, r) for r in ucell[ax])
        for r in dcell[ax]:
            t = rtype(donorI, r)
            if t and t not in utypes:
                ucell[ax].append(copy_rel(donorI, r, donor_part))
                utypes.add(t)
                added += 1
    return added

EMPTY = lambda: {'PhysicsMaterialProperties': [], 'PhysicsPropertyProperties': []}

for lvl in PRIORITY + sorted(set(f[:-5] for f in os.listdir(SRC)) - set(PRIORITY)):
    if lvl == BASE: continue
    try:
        dD, dI, dG, _ = load(lvl)
    except Exception as e:
        print('skip', lvl, e); continue
    dim = dG['MaterialIndexMap']; dIG = dG['InteractionGrid']; dMP = dG['MaterialProperties']
    dpart = dD['PartitionGuid']
    # 1) add absent materials
    for gm in range(len(dim)):
        if dim[gm] > 0 and im[gm] == 0:
            newL = len(IG)
            u_l2g = l2g(im)
            u_l2g[newL] = gm
            im[gm] = newL
            dl = dim[gm]
            # new column on every existing row
            for i in range(newL):
                gi = u_l2g[i]
                di = dim[gi] if gi < len(dim) else 0
                if di > 0:
                    src = dIG[dl]['Items'][di]
                    cell = {'PhysicsMaterialProperties': [copy_rel(dI, r, dpart) for r in src['PhysicsMaterialProperties']],
                            'PhysicsPropertyProperties': [copy_rel(dI, r, dpart) for r in src['PhysicsPropertyProperties']]}
                else:
                    cell = EMPTY()
                IG[i]['Items'].append(cell)
            # new row
            row = []
            for j in range(newL + 1):
                gj = u_l2g[j]
                dj = dim[gj] if gj < len(dim) else 0
                if dj > 0:
                    src = dIG[dl]['Items'][dj]
                    cell = {'PhysicsMaterialProperties': [copy_rel(dI, r, dpart) for r in src['PhysicsMaterialProperties']],
                            'PhysicsPropertyProperties': [copy_rel(dI, r, dpart) for r in src['PhysicsPropertyProperties']]}
                else:
                    cell = EMPTY()
                row.append(cell)
            IG.append({'Items': row})
            # material properties for the new local
            sp = dMP[dl]
            MP_.append({'PhysicsMaterialProperties': [copy_rel(dI, r, dpart) for r in sp['PhysicsMaterialProperties']],
                        'PhysicsPropertyProperties': [copy_rel(dI, r, dpart) for r in sp['PhysicsPropertyProperties']]})
            stats['materials_added'] += 1
    # 2) type-merge existing cells
    u_l2g = l2g(im)
    for i in range(len(IG)):
        gi = u_l2g.get(i, 0)
        di = dim[gi] if gi and gi < len(dim) else (0 if gi else 0)
        if gi and not di: continue
        for j in range(len(IG)):
            gj = u_l2g.get(j, 0)
            dj = dim[gj] if gj and gj < len(dim) else (0 if gj else 0)
            if gj and not dj: continue
            if not gi or not gj: continue
            stats['cells_merged'] += merge_cell(IG[i]['Items'][j], dIG[di]['Items'][dj], dI, dpart)

# rewrite base-partition refs inside cells/props to the NEW partition guid (instances live in U now)
def rewrite(o):
    if isinstance(o, dict):
        if o.get('PartitionGuid') == UP and o.get('InstanceGuid') in Uinst:
            o['PartitionGuid'] = NEW_PART
        for v in o.values(): rewrite(v)
    elif isinstance(o, list):
        for v in o: rewrite(v)
rewrite(IG); rewrite(MP_)
rewrite(U.get('DefaultMaterial'))
rewrite(U.get('MaterialPairs'))

# sanity
N = len(IG)
assert all(len(r['Items']) == N for r in IG), 'not square'
assert len(MP_) == N
dangle = 0
for row in IG:
    for c in row['Items']:
        for ax in ('PhysicsMaterialProperties', 'PhysicsPropertyProperties'):
            for r in c[ax]:
                if r['PartitionGuid'] == NEW_PART and r['InstanceGuid'] not in Uinst: dangle += 1
present = sum(1 for x in im if x > 0)
out = {'PrimaryInstanceGuid': baseGid, 'Instances': Uinst, 'Name': NEW_NAME, 'PartitionGuid': NEW_PART}
json.dump(out, open('F:/tmp/universalgrid.json', 'w'))
print('UNIVERSAL GRID: %d locals (%d/180 materials present), %d instances, dangle=%d' % (N, present, len(Uinst), dangle))
print('stats:', dict(stats))
print('grid instance guid:', baseGid, ' partition:', NEW_PART)
