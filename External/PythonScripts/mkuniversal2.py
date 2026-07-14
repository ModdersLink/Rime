#!/usr/bin/env python3
"""universal2: the union grid REBUILT with proven-closure priority (the v24 client-crash fix).

v24 crash (vu+0xc1c76, null hash-table base on a worker thread ~1s after the client loaded the
universal partition): the original union type-merged relations from ALL 47 levels -> its resolved
closure carried ~210 exotic fx partitions (SP/coop/XP4/XP5 meshparticles+shaders) that gridnc9's
proven closure never had. universal2 removes that variable while keeping the SAME 154-local layout:

  TIER 1 (full union: add materials + type-merge): the 11 levels whose combined fx closure the
         client ALREADY loads green (gridnc9): mp_017(base), mp_subway, mp_012, sp_bank, xp5_001,
         sp_earthquake, xp1_004, xp3_desert, mp_001, coop_009, xp4_fd.
  TIER 2 (everything else): ONLY add fully-absent materials + fill FULLY-EMPTY cells. No
         type-merge appends -> exotic instances only where tier 1 has NOTHING (small tail).

Identity FIXED to the shipped universal (partition e96eb5d9-..., primary = mp_017's grid instance
c3762a83-... since base=mp_017) -> zero Lua/annex-name changes.
"""
import json, os, collections, copy

SRC = 'F:/tmp/allgrids'
BASE = 'mp_017'
TIER1 = ['mp_subway', 'mp_012', 'sp_bank', 'xp5_001', 'sp_earthquake', 'xp1_004',
         'xp3_desert', 'mp_001', 'coop_009', 'xp4_fd']
NEW_PART = 'e96eb5d9-6419-4881-ab7c-4279f9bcc73e'
NEW_NAME = 'levels/realitymod/realitymod/universalgrid'

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
UP = baseD['PartitionGuid']
im = U['MaterialIndexMap']
IG = U['InteractionGrid']
MP_ = U['MaterialProperties']
Uinst = {baseGid: U}
for g, o in baseI.items():
    if g != baseGid:
        Uinst[g] = o

def l2g(imap):
    m = {0: 0}
    for gi, li in enumerate(imap):
        if li > 0: m[li] = gi
    return m

stats = collections.Counter()
level_used = collections.Counter()

def copy_rel(donorI, ref, lvl):
    gid = ref['InstanceGuid']
    if gid not in Uinst:
        Uinst[gid] = copy.deepcopy(donorI[gid])
        stats['instances_copied'] += 1
        level_used[lvl] += 1
    return {'PartitionGuid': NEW_PART, 'InstanceGuid': gid}

def merge_cell(ucell, dcell, donorI, lvl):
    added = 0
    for ax in ('PhysicsMaterialProperties', 'PhysicsPropertyProperties'):
        utypes = set(rtype(Uinst, r) for r in ucell[ax])
        for r in dcell[ax]:
            t = rtype(donorI, r)
            if t and t not in utypes:
                ucell[ax].append(copy_rel(donorI, r, lvl))
                utypes.add(t)
                added += 1
    return added

EMPTY = lambda: {'PhysicsMaterialProperties': [], 'PhysicsPropertyProperties': []}
def is_empty(c):
    return not c['PhysicsMaterialProperties'] and not c['PhysicsPropertyProperties']

def add_absent_materials(dG, dI, dim, lvl):
    for gm in range(len(dim)):
        if dim[gm] > 0 and im[gm] == 0:
            newL = len(IG)
            u_l2g = l2g(im)
            u_l2g[newL] = gm
            im[gm] = newL
            dl = dim[gm]
            dIG, dMP = dG['InteractionGrid'], dG['MaterialProperties']
            for i in range(newL):
                gi = u_l2g[i]
                di = dim[gi] if gi < len(dim) else 0
                if di > 0:
                    src = dIG[dl]['Items'][di]
                    cell = {'PhysicsMaterialProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsMaterialProperties']],
                            'PhysicsPropertyProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsPropertyProperties']]}
                else:
                    cell = EMPTY()
                IG[i]['Items'].append(cell)
            row = []
            for j in range(newL + 1):
                gj = u_l2g[j]
                dj = dim[gj] if gj < len(dim) else 0
                if dj > 0:
                    src = dIG[dl]['Items'][dj]
                    cell = {'PhysicsMaterialProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsMaterialProperties']],
                            'PhysicsPropertyProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsPropertyProperties']]}
                else:
                    cell = EMPTY()
                row.append(cell)
            IG.append({'Items': row})
            sp = dMP[dl]
            MP_.append({'PhysicsMaterialProperties': [copy_rel(dI, r, lvl) for r in sp['PhysicsMaterialProperties']],
                        'PhysicsPropertyProperties': [copy_rel(dI, r, lvl) for r in sp['PhysicsPropertyProperties']]})
            stats['materials_added'] += 1

# ── TIER 1: full union over the proven levels ────────────────────────────────────────────────
for lvl in TIER1:
    dD, dI, dG, _ = load(lvl)
    dim = dG['MaterialIndexMap']
    add_absent_materials(dG, dI, dim, lvl)
    u_l2g = l2g(im)
    dIG = dG['InteractionGrid']
    for i in range(len(IG)):
        gi = u_l2g.get(i, 0)
        if not gi: continue
        di = dim[gi] if gi < len(dim) else 0
        if not di: continue
        for j in range(len(IG)):
            gj = u_l2g.get(j, 0)
            if not gj: continue
            dj = dim[gj] if gj < len(dim) else 0
            if not dj: continue
            stats['cells_merged_t1'] += merge_cell(IG[i]['Items'][j], dIG[di]['Items'][dj], dI, lvl)

# ── TIER 2: rest of the levels — absent materials + fully-empty cell fill ONLY ───────────────
rest = sorted(set(f[:-5] for f in os.listdir(SRC)) - set(TIER1) - {BASE})
for lvl in rest:
    try:
        dD, dI, dG, _ = load(lvl)
    except Exception as e:
        print('skip', lvl, e); continue
    dim = dG['MaterialIndexMap']
    add_absent_materials(dG, dI, dim, lvl)
    u_l2g = l2g(im)
    dIG = dG['InteractionGrid']
    for i in range(len(IG)):
        gi = u_l2g.get(i, 0)
        if not gi: continue
        di = dim[gi] if gi < len(dim) else 0
        if not di: continue
        for j in range(i, len(IG)):
            gj = u_l2g.get(j, 0)
            if not gj: continue
            dj = dim[gj] if gj < len(dim) else 0
            if not dj: continue
            if is_empty(IG[i]['Items'][j]) and is_empty(IG[j]['Items'][i]):
                src = dIG[di]['Items'][dj]
                if is_empty(src): continue
                cell = {'PhysicsMaterialProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsMaterialProperties']],
                        'PhysicsPropertyProperties': [copy_rel(dI, r, lvl) for r in src['PhysicsPropertyProperties']]}
                IG[i]['Items'][j] = cell
                IG[j]['Items'][i] = copy.deepcopy(cell)
                stats['cells_filled_t2'] += 1

# rewrite base-partition refs to the new identity
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
json.dump(out, open('F:/tmp/universalgrid2.json', 'w'))
print('UNIVERSAL2: %d locals (%d/180), %d instances, dangle=%d' % (N, present, len(Uinst), dangle))
print('stats:', dict(stats))
print('primary:', baseGid, '| partition:', NEW_PART)
print('tier-2 levels actually contributing instances:',
      sorted((l, n) for l, n in level_used.items() if l not in TIER1 and l != BASE))
