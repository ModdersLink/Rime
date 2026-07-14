#!/usr/bin/env python3
"""Per-map gridext generator (v25 FINAL ARCHITECTURE) — the CONFIRMED gridext3 recipe, parametrized.

For each infantry map: ITS grid (ordered dump, layout preserved = zero bullet risk) + every material
mp_017 has that the map lacks (vehicle bodies + ammo + mp_017 surfaces) + second-pass donor fill for
map surfaces absent from mp_017 (proven donor family only). Deterministic uuid5 guids per map
(namespace = uuid5(NS, mapkey)) -> stable across rebuilds, Lua table generated at the end.

Output per map: F:/tmp/gridpm/<key>_grid.json + <key>_stub.json ; prints the Lua config line.
"""
import json, copy, os, subprocess, sys, uuid

SP = os.path.dirname(os.path.abspath(__file__))
NS = uuid.UUID('3b8e2f47-91aa-4d02-b7c3-5e6f7a8b9c0d')
# BASE-GAME donors ONLY (v25 law, from the v24 autopsy): a fill sourced from a DLC level can pull
# FOREIGN-DLC meshparticle meshes into the closure — their MeshSet res are DLC-noncas (crash) and
# their shader solutions per-level (freeze). Base-game fx resolve from cas.cat on ANY map.
# (A target map's OWN dlc fx are safe — natively resident + own shaderdb.)
DONORS = ["mp_012", "sp_bank", "sp_earthquake", "mp_001", "coop_009", "mp_subway",
          "sp_valley", "sp_paris", "sp_tank", "coop_002", "coop_006", "mp_003", "mp_007", "mp_011", "mp_013", "mp_018"]
STUB_TEMPLATE = r"C:\Users\keku\Documents\Battlefield 3\Server\Admin\Mods\Terrain_Tools\baker\_vehprov\rush_subworld.json"
OUT = r"F:\tmp\gridpm"
os.makedirs(OUT, exist_ok=True)

MAPS = {   # key -> ordered base dump (v29: subway joins the unified pipeline)
    "mp_subway":   "F:/tmp/subwaygrid_ordered.json",
    "xp2_factory": "F:/tmp/xp2factory_ordered.json",
    "xp2_office":  "F:/tmp/xp2office_ordered.json",
    "xp2_palace":  "F:/tmp/xp2palace_ordered.json",
    "xp2_skybar":  "F:/tmp/xp2skybar_ordered.json",
}

# ★ v29 ADD-DONOR CHAIN (measured 2026-07-14): mp_017 FIRST (its rows are the CONFIRMED crater —
# never replace what works), then xp3_desert for the 11 materials mp_017 lacks (Gunship_165,
# JetDamage_45, Bomber_46, Mud_19, Forest_136, Rocket_HIMARS_174, WaterPuddle, NoGrenades, BoltHE,
# Weapon, Passthrough — real rows instead of MatUniv analogies), then mp_001 (base-game, rain:
# Marble_67 = real vehicle×marble pairs for CQ, Tarmac_Wet_140, Tree_Branch_103, Destructible_23).
# DLC exposure of the xp3 rows is small (measured: 8 DLC meshparticle meshes) — their MeshSet res
# get embedded in the build (the gridu3 fix) or the client crashes at deferred mesh creation.
ADD_DONORS = [("mp_017", "F:/tmp/mp017grid_ordered.json"),
              ("xp3_desert", "F:/tmp/allgrids/xp3_desert.json"),
              ("mp_001", "F:/tmp/allgrids/mp_001.json")]

def grid_of(d):
    return next(o for o in d['Instances'].values() if o.get('$type') == 'MaterialGridData')

def make_stub(key, nsmap):
    part_g = str(uuid.uuid5(nsmap, 'stub:partition'))
    fixed = {t: str(uuid.uuid5(nsmap, 'stub:' + t))
             for t in ('SubWorldData', 'RegistryContainer', 'InterfaceDescriptorData')}
    name = 'vehgrid/gx_' + key
    d = json.load(open(STUB_TEMPLATE, encoding='utf-8'))
    insts = d['Instances']; prim_g = d['PrimaryInstanceGuid']; prim = insts[prim_g]
    reg_g = prim['RegistryContainer']['InstanceGuid']; desc_g = prim['Descriptor']['InstanceGuid']
    keep = [prim_g, reg_g, desc_g]
    remap = {g: fixed[insts[g]['$type']] for g in keep}
    def fix_ref(r):
        if isinstance(r, dict) and r.get('InstanceGuid') in remap:
            r['InstanceGuid'] = remap[r['InstanceGuid']]; r['PartitionGuid'] = part_g
        return r
    new_insts = {}
    for g in keep:
        i = insts[g]
        if i.get('$type') == 'SubWorldData':
            i['Objects'] = []; i['PropertyConnections'] = []; i['LinkConnections'] = []
            i['EventConnections'] = []; i['InterfaceHasConnections'] = False; i['NeedNetworkId'] = False
            i['Name'] = name; fix_ref(i['RegistryContainer']); fix_ref(i['Descriptor'])
        elif i.get('$type') == 'RegistryContainer':
            i['EntityRegistry'] = []; i['AssetRegistry'] = []; i['BlueprintRegistry'] = []; i['ReferenceObjectRegistry'] = []
        elif i.get('$type') == 'InterfaceDescriptorData':
            i['Fields'] = []; i['InputEvents'] = []; i['OutputEvents'] = []; i['InputLinks'] = []; i['OutputLinks'] = []
        new_insts[remap[g]] = i
    out = {'PartitionGuid': part_g, 'PrimaryInstanceGuid': remap[prim_g], 'Name': name, 'Instances': new_insts}
    p = os.path.join(OUT, key + '_stub.json')
    json.dump(out, open(p, 'w', encoding='utf-8'), indent=1)
    return name

def build_map(key, base_path):
    nsmap = uuid.uuid5(NS, key)
    base = json.load(open(base_path))
    bg = grid_of(base)
    bim = bg['MaterialIndexMap']
    print('[%s] base locals=%d' % (key, len(bg['InteractionGrid'])))

    # ── pass 1 (v29): CHAINED multi-donor ADD — each donor contributes only the materials still
    # absent after the previous ones (mp_017's confirmed rows stay authoritative).
    cur_in = base_path
    add = []                       # every material added (any donor) — pass-2/3 iterate these
    have = set(g for g in range(180) if bim[g] > 0)
    for di, (dname, dpath) in enumerate(ADD_DONORS):
        dgrid = grid_of(json.load(open(dpath)))
        dim = dgrid['MaterialIndexMap']
        todo = [g for g in range(180) if g not in have and dim[g] > 0]
        if not todo:
            print('   donor %-12s: nothing new' % dname); continue
        out_p = os.path.join(OUT, '%s_p1_%d.json' % (key, di))
        r = subprocess.run([sys.executable, os.path.join(SP, 'gridmerge.py'), cur_in, dpath, out_p]
                           + [str(g) for g in todo], capture_output=True, text=True)
        if r.returncode != 0:
            print(r.stderr[-800:]); sys.exit(1)
        print('   donor %-12s: +%d materials %s' % (dname, len(todo), todo))
        have |= set(todo); add += todo; cur_in = out_p
    merged = cur_in

    # surfaces of the map that mp_017 lacks (the empty-cell set pass 2/3 must fill)
    src017 = grid_of(json.load(open('F:/tmp/mp017grid_ordered.json')))
    missing = [g for g in range(180) if bim[g] > 0 and src017['MaterialIndexMap'][g] == 0]

    # pass 2: donor fill of empty (added-mat x missing-surface) cells
    d = json.load(open(merged))
    base_part = d['PartitionGuid']
    g2 = grid_of(d); im2 = g2['MaterialIndexMap']
    donors = []
    for nm in DONORS:
        p = 'F:/tmp/allgrids/%s.json' % nm
        if not os.path.isfile(p): continue
        dd = json.load(open(p)); gg = grid_of(dd)
        donors.append((nm, dd, gg, gg['MaterialIndexMap']))
    def is_empty(c): return not c['PhysicsMaterialProperties'] and not c['PhysicsPropertyProperties']
    copied = {'n': 0}
    def copyrefs(reflist, srcD):
        out_ = []
        for ref in reflist:
            gid = ref['InstanceGuid']
            so = srcD['Instances'].get(gid)
            if so is None: continue
            if gid not in d['Instances']:
                d['Instances'][gid] = copy.deepcopy(so); copied['n'] += 1
            out_.append({'PartitionGuid': base_part, 'InstanceGuid': gid})
        return out_
    filled, unfill = 0, 0
    for m in add:
        Lm = im2[m]
        for s in missing:
            Ls = im2[s]
            if Lm == 0 or Ls == 0: continue
            if not (is_empty(g2['InteractionGrid'][Lm]['Items'][Ls]) and is_empty(g2['InteractionGrid'][Ls]['Items'][Lm])):
                continue
            done = False
            for nm, dd, gg, dim in donors:
                if dim[m] > 0 and dim[s] > 0:
                    sc = gg['InteractionGrid'][dim[m]]['Items'][dim[s]]
                    if is_empty(sc): continue
                    cell = {'PhysicsMaterialProperties': copyrefs(sc['PhysicsMaterialProperties'], dd),
                            'PhysicsPropertyProperties': copyrefs(sc['PhysicsPropertyProperties'], dd)}
                    g2['InteractionGrid'][Lm]['Items'][Ls] = cell
                    g2['InteractionGrid'][Ls]['Items'][Lm] = copy.deepcopy(cell)
                    filled += 1; done = True; break
            if not done: unfill += 1
    print('[%s] donor-filled %d cells (+%d instances), unfillable %d' % (key, filled, copied['n'], unfill))

    # pass 3: ANALOG fill (v25.1, the skybar lesson): CQ interiors use XP2-specific surface variants
    # (Brick_XP2 159, Concrete_XP2 160, Marble_XP2 161, Wood_XP2 162, Tile 155, Plaster 156...) that
    # mp_017 never met -> (added-mat x interior-wall) pairs exist NOWHERE in DICE data -> tank blast
    # on any interior wall = empty cell = no fx. Fill each empty cell from the SAME grid's cell vs an
    # ANALOG surface (Tank x Concrete_XP2 := Tank x Concrete): pure ref copy, zero new instances/closure.
    # Enum names: F:/tmp/material_names.json (MaterialContainer.MaterialNames). 129=NoCraters & special
    # collision classes are deliberately left empty.
    SURFACE_ANALOG = {
        155: [8, 14, 2, 3],     # Tile -> Concrete, Stone, Brick, Metal
        156: [8, 2, 14],        # Plaster -> Concrete, Brick
        159: [2, 8],            # Brick_XP2 -> Brick
        160: [8, 14],           # Concrete_XP2 -> Concrete
        161: [67, 14, 8],       # Marble_XP2 -> Marble, Stone, Concrete
        67:  [14, 8],           # Marble -> Stone, Concrete
        162: [13],              # Wood_XP2 -> Wood
        169: [14, 8],           # Ice -> Stone, Concrete
        19:  [12, 11, 16],      # Mud -> Sand, Gravel, Grass
        142: [9, 15],           # PlasticBag -> Plastic, Cloth
        136: [20, 16],          # Forest -> Foliage, Grass
        103: [13, 20],          # Tree_Branch -> Wood, Foliage
        23:  [22, 13],          # Destructible -> Destructible(22), Wood
        57:  [],                # Frag (weapon class) - skip
        50:  [], 129: [], 152: [], 157: [],   # Passthrough/NoCraters/collision classes - deliberate
    }
    analog_filled = 0
    for m in add:
        Lm = im2[m]
        if Lm == 0: continue
        for s in missing:
            Ls = im2[s]
            if Ls == 0: continue
            if not (is_empty(g2['InteractionGrid'][Lm]['Items'][Ls]) and is_empty(g2['InteractionGrid'][Ls]['Items'][Lm])):
                continue
            for a in SURFACE_ANALOG.get(s, [8, 14, 3]):   # default analogs: Concrete, Stone, Metal
                La = im2[a] if a < len(im2) else 0
                if La == 0: continue
                src = g2['InteractionGrid'][Lm]['Items'][La]
                if is_empty(src): continue
                cell = copy.deepcopy(src)
                g2['InteractionGrid'][Lm]['Items'][Ls] = cell
                g2['InteractionGrid'][Ls]['Items'][Lm] = copy.deepcopy(cell)
                analog_filled += 1
                break
    print('[%s] ANALOG-filled %d empty cells (same-grid ref copies)' % (key, analog_filled))

    # freshen (deterministic per map)
    old_part = d['PartitionGuid']
    new_part = str(uuid.uuid5(nsmap, 'partition:' + old_part))
    remap = {g: str(uuid.uuid5(nsmap, 'instance:' + g)) for g in d['Instances']}
    NAME = 'levels/realitymod/realitymod/gridext_' + key
    def rewrite(o):
        if isinstance(o, dict):
            if o.get('PartitionGuid') == old_part and 'InstanceGuid' in o:
                o['PartitionGuid'] = new_part
                o['InstanceGuid'] = remap.get(o['InstanceGuid'], o['InstanceGuid'])
            for v in o.values(): rewrite(v)
        elif isinstance(o, list):
            for v in o: rewrite(v)
    new_inst = {}
    for g, obj in d['Instances'].items():
        rewrite(obj)
        if obj.get('$type') == 'MaterialGridData' and 'Name' in obj:
            obj['Name'] = NAME
        new_inst[remap[g]] = obj
    prim = remap[d['PrimaryInstanceGuid']]
    out = {'PartitionGuid': new_part, 'PrimaryInstanceGuid': prim, 'Name': NAME, 'Instances': new_inst}
    gp = os.path.join(OUT, key + '_grid.json')
    json.dump(out, open(gp, 'w'))
    bundle = make_stub(key, nsmap)
    print('[%s] grid=%s | bundle=%s' % (key, os.path.basename(gp), bundle))
    return key, bundle, new_part, prim, NAME

results = []
for key, path in sorted(MAPS.items()):
    results.append(build_map(key, path))

print('\n-- Lua GRID_TARGET entries --')
for key, bundle, part, inst, name in results:
    print('\t%s = { sb = "vehgrid/gridpm", bundle = "%s", part = Guid("%s"), inst = Guid("%s") },' % (key, bundle, part, inst))
print('\n-- build script lines --')
for key, bundle, part, inst, name in results:
    print('build_bundle win32/%s' % bundle)
    print('add_json_partition %s F:/tmp/gridpm/%s_stub.json' % (bundle, key))
    print('add_json_partition %s F:/tmp/gridpm/%s_grid.json' % (name, key))
    print('resolve_partition_dependencies')
    print('build')
