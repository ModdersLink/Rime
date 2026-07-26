# keku's format tooling (candidates for C# Rime commands)

Working Python used to RE/build BF3 content during the material-grid / EbxWriter-fidelity work
(2026-07). Per Bree's directive these belong in Rime as commands — this drop is the reference
implementation set for porting. Roughly ordered by port value.

## VU gotcha worth knowing (cost ~6 in-game test cycles)

A bundle injected into a level's bundle set via the `ResourceManager:LoadBundles` hook must be
passed **without the `win32/` prefix** (`vehpack/veh_x_tex`), even though the superbundle toc
declares the id **with** it (`win32/vehpack/veh_x_tex`). Passing the prefixed id makes the level
load hang forever at "creating level" instead of erroring — it silently resolves to no mounted
superbundle. An error (or at least a warning) there would have saved a lot of debugging; the same
bundles realize fine via `SubWorldReferenceObjectData` either way.

## Shader DB (the agreed first port target)
- **shaderdb_merge.py** — the v182 shaderdb toolset: parse, `has`, `appendshader`, `swapentry`,
  `cloneshader`, `mergesol`, `tex2` (by-name texture extraction per shader), `transplant`,
  `analyze`, and more. Everything we know about the format lives here.
- **clonetech.py** — clone one technique's solutions to another technique id inside a shader
  entry (e.g. tech 1 → tech 9 so the vehicle render path's camo request resolves).
  Note: the shader KEY hash = djb2-XOR (`h=5381; h=(h*33)^byte`, 32-bit, over the shader name).

## Noncas binary superbundles
- **ncdiff.py** — parser/differ for the binary noncas bundle format (u32 BE manifestSize; 32B
  header magic 0x970D1C13; sha1s; 12B entry records; resTypes/metas; 28B chunk entries; chunkMeta
  DbObject; textblock; payloads align16).
- **nccover.py** — import-closure coverage: walks a bundle's EBX import tables (dword[3]=count,
  32B entries @0x50, partition guid first) and reports dangling imports. Dangling imports in an
  embedded-EBX noncas bundle wedge the native loader ("creating level" hang).

## EBX / fidelity
- **ebxdiff.py** — EBX partition header/descriptor parser + differ (the byte-fidelity harness).
- **ebxprobe.py** — quick header probe.
- **fidelity_mine.py** — mines per-type SecondaryOffset/flag values from retail EBX into
  `fidelity_fb2.json` (consumed by the rewritten Frostbite2_0 EbxWriter; must sit next to
  RimeREPL.exe).

## CAS superbundles
- **sbdiff.py** — cas .sb/.toc parser + differ (obfuscation: magic 0x00/0x01CED100, hdr 0x22C,
  XOR 0x7B; DbObject TLV). Caught the stale-binary toc-offset bug.

## MaterialGridData transforms (JSON-level, via dump_partition_json + add_json_partition)
- **gridmerge.py** — add absent materials to a grid from a donor grid (rows/cols/properties/
  indexMap), skipping pairs the donor lacks.
- **mkgridpm.py** — per-map "gridext" recipe: map's own grid (layout preserved) + all materials
  mp_017 has that the map lacks + base-game donor fills + ANALOG fill for surface variants that
  never met vehicles anywhere in DICE data (XP2 walls: Brick_XP2/Tile/Plaster/... — see
  MaterialContainer.MaterialNames for the global enum; 129=NoCraters is deliberately empty).
  Deterministic uuid5 guids.
- **gridunion.py / mkuniversal2.py** — union-of-all-levels grid builders. NOTE: the union
  approach is ARCHITECTURALLY DEAD for delivery (its closure inevitably references fx families
  the target map's shaderdb can't render); kept for the transforms.
- **mkgridstub.py** — minimal realizable SubWorldData stub (partition name == bundle name) for
  SWROD-realize delivery of generated partitions (the only path that natively delivers
  generated EBX from a mod noncas sb; LoadBundles-injection of mod-noncas EBX hangs — likely a
  VU serving gap, separate report).

## Emitter atlas
- **atlas_composite.py** — per-map composite emitter atlas: BC-block grafts the map's unique
  sprite cells (from its own atlas) into free slots of MP_017's atlas across the mip chain +
  rewrites EmitterSystemAsset TextureInfos (union). Fixes "swap the emitter system for vehicle
  particles but break map-ambient emitters" (skybar searchlight, subway tracers).
  Note: `add_dds_texture` generates only the RES — the engine binds it by name, so a Name-only
  TextureAsset EBX partition must ship alongside.

## EBX descriptor fidelity: what fidelity_fb2.json is (and is not)

`fidelity_fb2.json` (next to RimeREPL.exe) is a **small mined fallback with a tripwire**, not a claim
of a global type map. The writer takes flags/offsets from the generated C# classes and only consults
the JSON for types that are in it; when the two disagree it warns instead of silently emitting a
wrong layout. It covers the types of the partitions actually byte-verified so far (21).

Why it can't simply be "all types": **the primary field offset is not constant per type name.**
`fidelity_bulk.py` scans the DLC (noncas) superbundles for raw EBX partitions — 215,468 partitions /
1,559 types across XP1–XP5 — and the same type shows up with different primary offsets and sizes in
different partitions, with identical field names, flags and *secondary* offsets, e.g.:

    AIEntryData  size=36 : EquipmentType@12  Armament@16  Mobility@20  StrengthType@24  ...
    AIEntryData  size=112: EquipmentType@12  Armament@48  Mobility@76  StrengthType@100 ...

(both inside XP3_Desert.sb). Presumably that's exactly why EBX carries type descriptors per
partition. Run: `fidelity_bulk.py out.json <sb-or-dir> [...]` to regenerate the full mined map.

Related bug this uncovered: `fb/EmitterTextureAtlasInfo.cs` was generated with its *secondary*
offsets (MinUv@0, MaxUv@8, TextureName@16) instead of the primary ones (TextureName@0, MinUv@4,
MaxUv@12) — the engine memory-maps EBX, so the partition loaded fine and every native read of it was
garbage, while VU-Lua reflection still showed correct-looking values.
