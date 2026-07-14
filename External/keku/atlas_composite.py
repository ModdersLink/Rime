#!/usr/bin/env python3
"""Per-map COMPOSITE emitter atlas (Phase C-lite, 2026-07-14).

The emitter swap (LevelData.emitterSystemAsset -> MP_017) fixes vehicle particles but breaks every
MAP emitter whose sprite is absent from MP_017's TextureInfos (skybar searchlight, subway tracers).
Composite per map: canvas = MP_017's atlas pair (vehicle sprites intact, UVs unchanged) + block-copy
the map's UNIQUE sprite cells from the map's own atlas into FREE 64px-aligned slots + TextureInfos =
mp_017's entries + the map's unique entries remapped to the grafted slots.

Outputs per map (F:/tmp/atlas/): comp_<key>_base.dds, comp_<key>_normal.dds, emitsys_<key>.json,
texasset_<key>_{base,normal}.json + prints GRID_CFG lua lines & build-script lines.
All guids deterministic (uuid5) -> rebuild-stable.
"""
import json, os, struct, sys, uuid, copy

ATLAS = r"F:\tmp\atlas"
NS = uuid.UUID('7c1e9d2a-44b0-4f6e-9a3d-1f2e3c4b5a69')   # atlas-composite namespace
MAPS = ["mp_subway", "xp2_skybar", "xp2_palace", "xp2_office", "xp2_factory"]
ESA = {
    "mp_017":      "F:/tmp/esa_mp017.json",
    "mp_subway":   "F:/tmp/esa_subway_ordered.json",
    "xp2_skybar":  "F:/tmp/esa_skybar.json",
    "xp2_palace":  "F:/tmp/esa_palace.json",
    "xp2_office":  "F:/tmp/esa_office.json",
    "xp2_factory": "F:/tmp/esa_factory.json",
}

def val(x): return x.get('$value', x) if isinstance(x, dict) else x

def load_esa(path):
    d = json.load(open(path))
    esa = next(o for o in d['Instances'].values() if o.get('$type') == 'EmitterSystemAsset')
    ti = val(esa['TextureInfos'])
    out = []
    for e in ti:
        name = str(val(e.get('TextureName'))).lower()
        def vec(v):
            v = val(v)
            return (float(val(v.get('x'))), float(val(v.get('y'))))
        out.append({'name': name, 'min': vec(e.get('MinUv')), 'max': vec(e.get('MaxUv')), 'raw': e})
    return d, esa, out

def canvas_of(name):
    b = name.rsplit('/', 1)[-1]
    return 'normal' if (b.endswith('_n') or 'normalmap' in b or 'defaultnormalmap' in b) else 'base'

# ── DDS block surgery (BC3/DXT5 = 16B per 4x4 block; both canvases are BC-16B) ─────────────────
class Dds:
    def __init__(self, path):
        self.raw = bytearray(open(path, 'rb').read())
        assert self.raw[:4] == b'DDS '
        h = struct.unpack_from('<7I', self.raw, 4)
        self.h, self.w, self.mips = h[2], h[3], h[6]
        self.hdr = 148 if self.raw[84:88] == b'DX10' else 128
    def mip_off(self, m):
        off = self.hdr
        for i in range(m):
            bw = max(1, (self.w >> i) + 3 >> 2); bh = max(1, (self.h >> i) + 3 >> 2)
            off += bw * bh * 16
        return off
    def copy_rect(self, src, sx, sy, dx, dy, cw, ch):
        """copy a cw x ch px rect (all 64px-aligned) from src Dds at (sx,sy) to self at (dx,dy),
        across every mip where the rect still spans >= 1 block."""
        for m in range(min(self.mips, src.mips)):
            w_m = cw >> m; h_m = ch >> m
            if w_m < 4 or h_m < 4: break
            sbx, sby = (sx >> m) // 4, (sy >> m) // 4
            dbx, dby = (dx >> m) // 4, (dy >> m) // 4
            nbx, nby = w_m // 4, h_m // 4
            srow = max(1, (src.w >> m) + 3 >> 2)
            drow = max(1, (self.w >> m) + 3 >> 2)
            soff, doff = src.mip_off(m), self.mip_off(m)
            for r in range(nby):
                s0 = soff + ((sby + r) * srow + sbx) * 16
                d0 = doff + ((dby + r) * drow + dbx) * 16
                self.raw[d0:d0 + nbx * 16] = src.raw[s0:s0 + nbx * 16]
    def save(self, path):
        open(path, 'wb').write(bytes(self.raw))

def cell64(mn, mx, W, H):
    x0 = int(mn[0] * W) // 64 * 64
    y0 = int(mn[1] * H) // 64 * 64
    x1 = -(-int(round(mx[0] * W)) // 64) * 64
    y1 = -(-int(round(mx[1] * H)) // 64) * 64
    return x0, y0, min(x1, W), min(y1, H)

# ── main ────────────────────────────────────────────────────────────────────────────────────────
mpD, mpEsa, mpE = load_esa(ESA['mp_017'])
mp_names = set(e['name'] for e in mpE)
CANVAS_DIMS = {'base': (4096, 4096), 'normal': (1024, 2048)}

lua_lines, build_lines = [], []
for key in MAPS:
    _, _, mapE = load_esa(ESA[key])
    unique = [e for e in mapE if e['name'] not in mp_names]
    print("[%s] unique sprites: %d -> %s" % (key, len(unique), [e['name'].rsplit('/',1)[-1] for e in unique]))

    # free-slot occupancy per canvas from mp_017 entries (64px granularity)
    occ = {}
    for cv, (W, H) in CANVAS_DIMS.items():
        g = [[False] * (W // 64) for _ in range(H // 64)]
        for e in mpE:
            if canvas_of(e['name']) != cv: continue
            x0, y0, x1, y1 = cell64(e['min'], e['max'], W, H)
            for y in range(y0 // 64, y1 // 64):
                for x in range(x0 // 64, x1 // 64):
                    g[y][x] = True
        occ[cv] = g

    def find_slot(cv, cw, ch):
        W, H = CANVAS_DIMS[cv]; g = occ[cv]
        nx, ny = cw // 64, ch // 64
        for y in range(len(g) - ny + 1):
            for x in range(len(g[0]) - nx + 1):
                if all(not g[y + j][x + i] for j in range(ny) for i in range(nx)):
                    for j in range(ny):
                        for i in range(nx): g[y + j][x + i] = True
                    return x * 64, y * 64
        raise RuntimeError("no free slot %dx%d on %s canvas" % (cw, ch, cv))

    comp = {cv: Dds(os.path.join(ATLAS, "mp_017_%s.dds" % cv)) for cv in CANVAS_DIMS}
    srcdds = {cv: Dds(os.path.join(ATLAS, "%s_%s.dds" % (key, cv))) for cv in CANVAS_DIMS}
    new_entries = []
    for e in unique:
        cv = canvas_of(e['name'])
        W, H = CANVAS_DIMS[cv]
        x0, y0, x1, y1 = cell64(e['min'], e['max'], W, H)
        cw, ch = x1 - x0, y1 - y0
        dx, dy = find_slot(cv, cw, ch)
        comp[cv].copy_rect(srcdds[cv], x0, y0, dx, dy, cw, ch)
        # preserve the exact sub-cell insets: newUV = (dst_origin + (uv*Dim - cell_origin)) / Dim
        nmin = ((dx + e['min'][0] * W - x0) / W, (dy + e['min'][1] * H - y0) / H)
        nmax = ((dx + e['max'][0] * W - x0) / W, (dy + e['max'][1] * H - y0) / H)
        new_entries.append({'name': e['name'], 'raw': e['raw'], 'min': nmin, 'max': nmax})
        print("   graft %-46s %s (%d,%d)+%dx%d -> (%d,%d)" % (e['name'].rsplit('/',1)[-1], cv, x0, y0, cw, ch, dx, dy))
    for cv in CANVAS_DIMS:
        comp[cv].save(os.path.join(ATLAS, "comp_%s_%s.dds" % (key, cv)))

    # ── composite ESA partition (template = mp_017's, deterministic freshen per map) ────────────
    nsm = uuid.uuid5(NS, key)
    d = copy.deepcopy(mpD)
    old_part = d['PartitionGuid']
    new_part = str(uuid.uuid5(nsm, 'esa:partition'))
    remap = {g: str(uuid.uuid5(nsm, 'esa:' + g)) for g in d['Instances']}
    tex_part = {cv: str(uuid.uuid5(nsm, 'tex:%s:partition' % cv)) for cv in CANVAS_DIMS}
    tex_inst = {cv: str(uuid.uuid5(nsm, 'tex:%s:instance' % cv)) for cv in CANVAS_DIMS}
    TEXNAME = {cv: 'levels/realitymod/realitymod/emitatlas_%s_%s' % (key, cv) for cv in CANVAS_DIMS}
    ESANAME = 'levels/realitymod/realitymod/emitsys_%s' % key

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
        if obj.get('$type') == 'EmitterSystemAsset':
            if 'Name' in obj: obj['Name'] = ESANAME
            # retarget the atlas texture refs to the per-map composite TextureAssets
            obj['BaseAtlasTexture'] = {'PartitionGuid': tex_part['base'], 'InstanceGuid': tex_inst['base']}
            obj['NormalAtlasTexture'] = {'PartitionGuid': tex_part['normal'], 'InstanceGuid': tex_inst['normal']}
            # append the map's unique entries with the grafted UVs (clone a raw entry as template)
            ti = obj['TextureInfos']
            arr = ti['$value'] if isinstance(ti, dict) else ti
            for ne in new_entries:
                entry = copy.deepcopy(ne['raw'])
                def setvec(field, xy):
                    v = entry[field]
                    tgt = v['$value'] if isinstance(v, dict) and '$value' in v else v
                    tgt['x'] = xy[0] if not isinstance(tgt.get('x'), dict) else {'$type': tgt['x'].get('$type','Single'), '$value': xy[0]}
                    tgt['y'] = xy[1] if not isinstance(tgt.get('y'), dict) else {'$type': tgt['y'].get('$type','Single'), '$value': xy[1]}
                setvec('MinUv', ne['min']); setvec('MaxUv', ne['max'])
                arr.append(entry)
        new_inst[remap[g]] = obj
    d['Instances'] = new_inst
    d['PartitionGuid'] = new_part
    d['PrimaryInstanceGuid'] = remap[d['PrimaryInstanceGuid']]
    d['Name'] = ESANAME
    json.dump(d, open(os.path.join(ATLAS, 'emitsys_%s.json' % key), 'w'))

    # TextureAsset partitions (Name-only, engine binds the res by name)
    for cv in CANVAS_DIMS:
        ta = {'PartitionGuid': tex_part[cv], 'PrimaryInstanceGuid': tex_inst[cv], 'Name': TEXNAME[cv],
              'Instances': {tex_inst[cv]: {'$type': 'TextureAsset', 'Name': TEXNAME[cv]}}}
        json.dump(ta, open(os.path.join(ATLAS, 'texasset_%s_%s.json' % (key, cv)), 'w'), indent=1)

    prim = d['PrimaryInstanceGuid']
    lua_lines.append('\t%s: emit = { part = Guid("%s"), inst = Guid("%s") }' % (key, new_part, prim))
    build_lines.append('REM -- %s (into its gx/gridext bundle):' % key)
    build_lines.append('add_json_partition %s F:/tmp/atlas/emitsys_%s.json' % (ESANAME, key))
    for cv in CANVAS_DIMS:
        build_lines.append('add_json_partition %s F:/tmp/atlas/texasset_%s_%s.json' % (TEXNAME[cv], key, cv))
        srgb = 'true' if cv == 'base' else 'false'
        build_lines.append('add_dds_texture "%s" "F:/tmp/atlas/comp_%s_%s.dds" %s false false' % (TEXNAME[cv], key, cv, srgb))

print("\n-- GRID_CFG emit lines --"); [print(l) for l in lua_lines]
print("\n-- build lines --"); [print(l) for l in build_lines]
