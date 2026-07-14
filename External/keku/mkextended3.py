#!/usr/bin/env python3
"""gridext3 = gridext2 (subway + 23 mp_017 materials) + SECOND-PASS DONOR FILL.

v23 in-game verdict (keku): the realized grid IS engine-consumed (destruction works) but
particles/decals are missing on SOME surfaces — exactly the gridmerge EMPTY() cells: 11 subway
surface materials [19,23,50,67,103,129,136,142,152,157,160] are ABSENT from the mp_017 donor,
so every (new-mat x that-surface) cell shipped empty. Fix: fill each empty cell from the first
donor level (priority list, greedy set cover over the 47 grid dumps) that has BOTH globals.
Uncoverable pairs (17: {27,41,42,47,49,81,105,137} x {23,67,160} — no level has both) stay empty.
The critical mats {60 blast, 76 .50, 86 shell} get 100% coverage.

Freshen is uuid5-DETERMINISTIC on the same inputs -> the partition/primary guids stay
3539e9a3-bc2a-5b5d-ac51-32425884f71f / c7ebdd9a-1b3b-5dcd-a692-04420f5cb5a6 (zero Lua changes).
"""
import json, copy, os, subprocess, sys, uuid

SP = os.path.dirname(os.path.abspath(__file__))
ADD = [17,25,27,36,37,39,40,41,42,43,44,47,49,60,76,78,81,86,105,114,121,137,154]
MISSING = [19,23,50,67,103,129,136,142,152,157,160]
DONORS = ["mp_012","sp_bank","xp5_001","sp_earthquake","xp1_004","xp3_desert","mp_001","coop_009","xp4_fd"]

# ── pass 1: identical to mkextended2 (gridmerge subway <- mp_017) ─────────────────────────────
r = subprocess.run([sys.executable, os.path.join(SP, 'gridmerge.py'),
                    'F:/tmp/subwaygrid_ordered.json', 'F:/tmp/mp017grid_ordered.json',
                    'F:/tmp/subway_ext_mp017.json'] + [str(g) for g in ADD],
                   capture_output=True, text=True)
print('\n'.join(r.stdout.splitlines()[-2:]))
if r.returncode != 0:
    print(r.stderr[-1500:]); sys.exit(1)

# ── pass 2: donor fill of the EMPTY cells ─────────────────────────────────────────────────────
d = json.load(open('F:/tmp/subway_ext_mp017.json'))
base_part = d['PartitionGuid']
bg = next(o for o in d['Instances'].values() if o.get('$type') == 'MaterialGridData')
bim = bg['MaterialIndexMap']

donor_data = []
for name in DONORS:
    p = 'F:/tmp/allgrids/%s.json' % name
    dd = json.load(open(p))
    g = next(o for o in dd['Instances'].values() if o.get('$type') == 'MaterialGridData')
    donor_data.append((name, dd, g, g['MaterialIndexMap']))

copied = {'n': 0}
def copyrefs(reflist, srcD):
    out = []
    for ref in reflist:
        gid = ref['InstanceGuid']
        src_obj = srcD['Instances'].get(gid)
        if src_obj is None:
            continue
        if gid not in d['Instances']:
            d['Instances'][gid] = copy.deepcopy(src_obj)
            copied['n'] += 1
        out.append({'PartitionGuid': base_part, 'InstanceGuid': gid})
    return out

def is_empty(cell):
    return not cell['PhysicsMaterialProperties'] and not cell['PhysicsPropertyProperties']

filled, unfillable, used = 0, [], {}
for m in ADD:
    Lm = bim[m]
    for s in MISSING:
        Ls = bim[s]
        if Lm == 0 or Ls == 0:
            continue
        cell_ms = bg['InteractionGrid'][Lm]['Items'][Ls]
        cell_sm = bg['InteractionGrid'][Ls]['Items'][Lm]
        if not (is_empty(cell_ms) and is_empty(cell_sm)):
            continue
        done = False
        for name, dd, g, dim in donor_data:
            if dim[m] > 0 and dim[s] > 0:
                src_cell = g['InteractionGrid'][dim[m]]['Items'][dim[s]]
                new_cell = {'PhysicsMaterialProperties': copyrefs(src_cell['PhysicsMaterialProperties'], dd),
                            'PhysicsPropertyProperties': copyrefs(src_cell['PhysicsPropertyProperties'], dd)}
                bg['InteractionGrid'][Lm]['Items'][Ls] = new_cell
                bg['InteractionGrid'][Ls]['Items'][Lm] = copy.deepcopy(new_cell)
                filled += 1
                used[name] = used.get(name, 0) + 1
                done = True
                break
        if not done:
            unfillable.append((m, s))

print('filled %d empty cells (both orientations), copied %d donor relation instances' % (filled, copied['n']))
print('donor usage:', sorted(used.items(), key=lambda kv: -kv[1]))
print('unfillable pairs (%d):' % len(unfillable), unfillable)
json.dump(d, open('F:/tmp/subway_ext3.json', 'w'))

# ── freshen: SAME deterministic namespace as mkextended2 -> SAME output guids ─────────────────
SRC = 'F:/tmp/subway_ext3.json'
OUT = 'F:/tmp/gridext3.json'
NAME = 'levels/realitymod/realitymod/subwaygrid_ext2'   # keep the shipped name (Lua/annex unchanged)
NS = uuid.UUID('3b8e2f47-91aa-4d02-b7c3-5e6f7a8b9c0d')

d = json.load(open(SRC))
old_part = d['PartitionGuid']
new_part = str(uuid.uuid5(NS, 'partition:' + old_part))
remap = {g: str(uuid.uuid5(NS, 'instance:' + g)) for g in d['Instances']}

def rewrite(o):
    if isinstance(o, dict):
        if o.get('PartitionGuid') == old_part and 'InstanceGuid' in o:
            o['PartitionGuid'] = new_part
            o['InstanceGuid'] = remap.get(o['InstanceGuid'], o['InstanceGuid'])
        for v in o.values():
            rewrite(v)
    elif isinstance(o, list):
        for v in o:
            rewrite(v)

new_inst = {}
for g, obj in d['Instances'].items():
    rewrite(obj)
    if obj.get('$type') == 'MaterialGridData' and 'Name' in obj:
        obj['Name'] = NAME
    new_inst[remap[g]] = obj

d['Instances'] = new_inst
d['PartitionGuid'] = new_part
d['PrimaryInstanceGuid'] = remap[d['PrimaryInstanceGuid']]
d['Name'] = NAME
json.dump(d, open(OUT, 'w'))
print('gridext3 partition:', new_part, '(must be 3539e9a3-bc2a-5b5d-ac51-32425884f71f)')
print('gridext3 primary  :', d['PrimaryInstanceGuid'], '(must be c7ebdd9a-1b3b-5dcd-a692-04420f5cb5a6)')
print('instances:', len(new_inst), '| wrote', OUT)
