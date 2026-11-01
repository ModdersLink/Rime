# Level builder plan

Goal: build level superbundles from a description instead of by hand. Start from an empty level
that loads, extend it bundle by bundle, and let the builder take care of everything a change in one
bundle implies for the others (the main bundle in particular). Ship templates such as "all weapons"
or "xp4 soldiers" on top.

This plan is grounded in measurements, not guesses: `analyze_level` (RimeREPL) explains every item
of every bundle of a retail level, and the rules below are what it found. Rerun it after any change
to the rules; a rule set is complete when it leaves nothing unexplained.

Status: every bundle of BF3 `mp_subway` and BF4 `mp_siege` is explained (0 unexplained items).
Getting BF4 there took two reader fixes (see [BF4](#bf4)).

## How a retail level is organised (BF3, measured on `mp_subway`)

| Bundle kind | Example | Root the engine starts from | Holds |
|---|---|---|---|
| Main bundle | `mp_subway` | `LevelData` partition named like the bundle | Level geometry, terrain, Enlighten, the level `RegistryContainer`, the only shader database, weapon mesh variation databases, and content the gamemodes need (see below) |
| Sub-world (gamemode, team, common) | `rush`, `teams_large`, `common` | `SubWorldData` partition named like the bundle | Its own `RegistryContainer` and `meshvariationdb_win32` |
| UI bundles | `mp_subway_uiplaying`, `..._uiendofround` | none | SWF movies and textures used by the main bundle's UI and the gamemodes |
| Settings / config | `mp_subway_settings_win32`, `..._gameconfiglight_win32`, `..._loading_music` | their own entry points (1-4 each) | Profile options, dog tags, level descriptions, game tips |

`LevelData` lists every sub-world as a `SubWorldReferenceObjectData` (bundle name plus a
`SubWorldInclusionSetting` deciding which gamemodes load it).

## Where everything comes from (BF3, `mp_subway`, 18152 main-bundle items)

Coverage of each bundle, built up from the roots the engine reaches without a reference:

| Main bundle covered by | Items |
|---|---|
| Closure of `LevelData` | 17101 |
| Mesh variation databases, found by name (the level's and 204 `weapon_shaderstateassets/*`) | 282 |
| Entry points only other levels import (leftovers, see below) | 13 |
| Entry points nothing in the game imports | 313 |
| Supplied for sub-worlds (in a gamemode's closure, not the main bundle's own) | 443 |
| Unexplained | 0 |

"Nothing in the game imports" is checked against the import table of every partition of the mounted
game (`mount_game ... true` first). An importer in a shared superbundle would load the item with that
superbundle; there are none in either game. Importers that are only in *other levels* don't load with
this level, so those items are leftovers here (7 shaders, an effect, a sound wave in `mp_subway`).

Sub-worlds: 97-99 % from their `SubWorldData`, plus their mesh variation database; the rest is
content they supply for the main bundle. UI bundles: everything is supplied for the main bundle's UI
and the gamemodes. Every bundle of the level: 0 unexplained.

## The rules

### Cross-bundle effects
| When a bundle gets | The builder also has to |
|---|---|
| A mesh | add its entry to *that* bundle's mesh variation database |
| A mesh whose shader the level lacks | add the shader to the **main** bundle's shader database, with a solution for each way it is drawn (see [How the shader database is filled](#how-the-shader-database-is-filled)) |
| Textures a main-database shader binds | ship them where the shader's users are; retail keeps them in the gamemode bundles |
| A networked entity, blueprint, asset or reference object | list it in that sub-world's `RegistryContainer`. Sub-world registries **also list main-bundle content** they use: `rush`'s `AssetRegistry` has 1077 own entries plus 1568 from the main bundle |
| A mesh whose geometry is in the main bundle | still list it in the sub-world's mesh variation database (`rush`: 420 own meshes plus 573 main-bundle meshes) |
| A new sub-world | add a `SubWorldReferenceObjectData` and its inclusion setting to the main `LevelData` |
| Anything an always-loaded parent bundle already has | leave it out; registering it twice can freeze the client (two mesh variation registrations do) |
| Content only gamemodes need | may live in the main bundle: 109 `SoldierWeaponUnlockAsset`, 100 `ValueUnlockAsset`, UI graphs and combat-area assets, shaders and effects |

### Registry rules (BF3)
`analyze_registry <level partition>` compares a registry with the closure of its level partition,
instance by instance, and searches for the property that decides whether an instance is listed.
`derive_registry <level partition>` builds the registries from the closure with the rules below
(`IRegistryRules`, per engine) and compares them with the shipped ones entry by entry.

What counts as the level's content: the instances reached by reference from the level partition's
primary instance, not every instance of every partition in the closure. A partition can be in the
closure for one instance only: `carrier_nongroupable_autogen`, a flattened copy of the carrier
prefab, borrows its sequence tracks, and the carrier blueprint itself is not listed. A partition
whose primary instance is reached counts whole, because destruction prefabs place loose reference
objects that nothing references (`parisfacade_02_s1024_destruction` and its debris clusters). The
values an `InterfaceDescriptorData` holds (`LevelData`'s interface defaults point at container
variations) don't count, and neither do the registries themselves.

| Registry | Rule |
|---|---|
| `EntityRegistry` | every instance of the networked entity types: weapons, controllables (vehicles, soldiers), projectiles except bullets, vehicle projectiles, pickups, bangers, vegetation trees, synced bool/sequence/transform, event syncs, objectives, capture points, map markers, combat areas, game interactions, life and ticket counters, pre-round, round-over, coop lobby; debris clusters only when `ClientSideOnly` is false |
| `AssetRegistry` | every unlock, object variation and soldier customization; skinned meshes only when an unlock points at them (`UnlockAsset.LinkedTo`, or the `BaseAsset` of a `BlueprintAndVariationPair` there) |
| `BlueprintRegistry` | blueprints with `NeedNetworkId`; and prefabs without it (world parts above all) that hold a listed object directly, hold `SoldierTestEntityData`, or whose interface starts a `ModelAnimationEntityData` by event (building collapses; cloth animations started inside the prefab don't count) |
| `ReferenceObjectRegistry` | reference objects whose blueprint has `NeedNetworkId` (not `LevelData.LevelReference`), spawn and sub-world reference objects, and reference objects of the prefabs listed above; runs to a fixed point, since listing a reference object can list the prefab holding it |

A sub-world's registry lists its own content. The level's own registry (in `LevelData`) also lists
its sub-worlds' entries, but only those whose partition ships in a bundle loaded with the level
(`win32/<level>`, `win32/<level>_settings_win32`): that is how it gets the weapons, vehicles and
~1500 unlocks every gamemode shares, and not the gamemode logic.

Measured on 19 BF3 registries (13 MP and XP1 main levels, `mp_subway`'s `rush`, `conquest_small` and
`teams_large`, `mp_018`'s `rush`, `coop_002`, `sp_bank`): 14 match the shipped registries exactly as
sets, all four lists each. What remains:
- Loose reference objects: `xp1_001` and `xp1_003` list 3 more than shipped in `mec_house_high_01_breakable`,
  whose unreferenced instances are not listed while those of the Paris facade are. Listing too
  much only costs network ids; listing too little leaves objects unsynced, so the rule errs this way.
- Unlocks that no closure reaches but that ship in the level bundle: `aavheupgrade` (XP1 levels),
  `sp_valley_sprint_unlock` (`mp_007`).
- Singleplayer (`sp_bank`): a mortar and 14 vehicle unlocks from no closure, and one visual
  environment blueprint.
- Order: the shipped order is not closure order; whether the engine needs a particular order is open.

### Registry rules (BF4)
BF4 keeps one list per bundle, shared bundles included: the `NetworkRegistryAsset` of
`<bundle>_networkregistry_win32`. A bundle's registry covers the networked content that bundle
ships, whether the level reaches it or not (vehicle missiles and vehicle unlocks nothing in the level
references are listed), and none of what other bundles ship: the vehicle spawner prefabs the
gamemode uses are registered in their own blueprint bundles. So the closure doesn't matter here; the
bundle's contents do.

The types are BF3's, with these differences: bit 0 of `DataBusData.Flags` is `NeedNetworkId`; object
variations and event syncs are not listed; soldier customizations, synced ints and floats, kill
counters, commanders, track-player, get-player-name and play-animation data are; sub-world reference
objects are listed when they name a bundle; the level's own `LevelData`/`SubWorldData` is not.

Measured on 23 BF4 registries (all 11 MP main levels, 8 `conquestlarge0`, `teamdeathmatch0`,
`rushlarge0`, `squaddeathmatch0`, `obliteration`, plus `mp_siege`'s `content`): all match exactly.

`generate_registry_container` predates these rules: it scans only the partitions of the bundle being
built and uses a fixed type list, so on cloned retail bundles it misses most entries (`rush`: 2056
assets, 146 entities, 118 blueprints) and adds others. `derive_registry_container [partition] [game]`
applies the rules in bundle building instead: it reads the bundle's own partitions first and the
mounted game for the rest, and stores the engine's registry object in the context. On cloned retail
`rush` and `mp_subway`, `compare_registry_containers` reports all four lists identical.
`emit_subworld_registry` consumes it for BF3; writing BF4's `_networkregistry_win32` partition is
still to do.

### Mesh variation databases
A database lists entries keyed by (mesh, variation name hash); an entry binds each of the mesh's
materials to a material variation and textures. Shipped mesh materials carry no textures (the cook
moved them into the databases), so an entry can't be built from the mesh. It doesn't have to be:
across all 664 BF3 databases (8635 keys) and 2208 BF4 ones (11096 keys) every key binds exactly the
same thing in every database that has it. The entries come from that pool; what has to be derived is
which keys a database holds.

`derive_mesh_variation_db <level partition>` derives them and compares with the shipped database:
walk from the level partition carrying the variation that applies. A placement switches it: a
reference object places its blueprint with its `ObjectVariation`, a static model group places each
member with the per-instance hash in `InstanceObjectVariation`, an unlock pair places its asset with
its variation; a placement without a variation of its own keeps the one around it (a destruction
prefab's debris clusters take the trash bin's). Every mesh the walk reaches is used with the
variation that applies there. Variations reached also pair with every mesh reached plainly (unlocks
list variations and meshes side by side), as far as the pool has the pair. A mesh the level's own
bundle ships that nothing gives a key, here or in a sub-world, gets its plain entry (the fallback that
binds every shipped mesh somewhere). BF3 particle emitters use their meshes without the database; BF4
lists them, and lists a mesh's plain entry whenever it lists a variation of it.

Results: BF3 13 MP/XP1 main levels and 5 gamemode sub-worlds: 9 exact, the rest within 2 entries
(a weapon socket's reticule mesh in every gamemode, terrain scattering meshes, a destruction mesh); BF4 15 databases
(5 main levels, 5 content and 5 conquest sub-worlds): every shipped key derived except 1 to 2 per
database (terrain scattering, shell casing particles), up to 3 % extra. Coop and singleplayer differ
more (`coop_002` lists none of the weapons its bundle ships).

`build_mesh_variation_db [partition] [game]` builds the database partition in bundle building and
reads it back: on cloned retail `mp_subway` all 1025 entries, `rush` all 993 plus the reticule mesh.

### Things the engine finds by name (roots of their own)
- `<bundle>/meshvariationdb_win32`, one per bundle, plus `weapon_shaderstateassets/*/meshvariationdb_win32`.
- BF4 also: `<bundle>_networkregistry_win32` and `<bundle>_win32_antstate` (`AntStateAsset`), one
  per bundle; `UIResourceTable` and `UILoadingScreenData` in the UI bundles.
- Shared UI: 115 `ui/assets/*` UI assets and 58 of their textures. Identical in every level. BF4
  ships the `ui/assets/*_iN` texture pages in every gamemode bundle (8 each).
- About 40 shared assets: root and headgear shaders, `b_basicassetsmp` animation packages, muzzle
  flash emitters, weapon sounds, vegetation skeletons, generic textures. All also ship elsewhere.
  BF4 has the same kinds: vegetation skeletons, `_edit/*/animtrackdata/*` resources, a handful of
  textures borrowed from other levels.
- Same-name asset/resource pairs: a name in a resource payload refers to the asset of that name as
  well. Terrain is the visible case: the `TerrainDecalsData` and `TerrainStreamingTreeAsset`
  partitions hold only a `Name`, nothing references them, and the `Terrain` and `VisualTerrain`
  payloads name `X.streamingtree` and `X.decals`, which exist as both a resource and a partition.
- The level's shader database: the resource named after `LevelData` plus `/shaderdb`
  (`levels/mp_subway/mp_subway/shaderdb`). It names its shaders and their textures, and those names
  are partitions. This is the only way to about 90 generated terrain shader permutations
  (`levels/mp_subway/terrain/mp_subway_terrain__0ms_1m_2ms__maskscale2d__0`, `...__0mv_5mv__2d__0`,
  `...__0md__3d__0`, one per layer combination), `defaultterrainsurfaceshader`, the
  `systems/terrain/surface/*` and `systems/terrain/decal/*` shaders, and about 20 terrain textures
  (some borrowed from other levels). No EBX or terrain resource references any of them, so a level
  builder has to generate the terrain permutations into the shader database, not just copy shaders.
- Terrain roots nothing references at all: `systems/terrain/noisetexture2d` (`NoiseTextureAsset`)
  and its `noisetexture2d_output_win32`, `grey50percentdxt1`, `grey50percentrgb`. BF4 has
  `X.layercombinations_win32` (`TerrainLayerCombinationsData`) and its terrain chunks (26 in the main
  bundle); Rime can't walk BF4's `VisualTerrain` and `TerrainStreamingTree` payloads yet, which is
  probably where those are named.
- The level's material grid: `LevelData.RuntimeMaterialGrid` (see [Material grid](#material-grid)).

### How the shader database is filled
One per level, in the main bundle, named after `LevelData` plus `/shaderdb`. It holds:

| | BF3 `mp_subway` | BF4 `mp_siege` |
|---|---|---|
| Shaders | 640 | 551 |
| used by main-bundle content | 497 | 26 |
| used only by sub-world content | 23 | 437 (`content`, `gen4_content`) |
| generated terrain permutations (`<terrain>__<layers>__<mode>__0`), used by no content | 81 | 37 |
| used only by shared content (imported by vehicles, weapons, decal templates, effects in shared superbundles) | 0 | 35 |
| engine defaults nothing references (`Systems/*`: default mesh, decal volume, sky, emitter, Enlighten debug, terrain surface roots; the terrain's default surface shader) | 37 | 2 |
| terrain decal shaders nothing references (road markings, skid marks, `whitedecal2d`) | 0 | 10 |
| other shaders nothing references (electric cables, a glass shard) | 0 | 3 |
| imported only by other levels | 2 | 1 |

So it is the union of every shader any bundle of the level uses, the shaders of shared content the
level loads (BF4 keeps those in the level database; BF3 apparently doesn't), the engine's default
shaders, and generated terrain permutations. In BF4 nearly all level content sits in the `content`
and `gen4_content` sub-worlds, so nearly all its shaders are theirs. BF3 reaches its terrain decal
shaders through the names in the `TerrainDecals` payload; BF4's payload doesn't name them, so they
probably go by hash or through the terrain payloads Rime can't walk yet.

Per shader the database holds solutions, one per way the shader is drawn (permutation and vertex
layout): BF4 `mp_siege` has 25270 solution entries for 551 shaders. Textures are named as strings.
Building one therefore means compiling or copying solutions per shader and per vertex layout of the
meshes that use it. Copying from retail databases covers retail shaders with retail meshes; terrain
permutations depend on the level's layer combinations and have to be generated.

### Building one (BF3)
`build_shader_database` copies shaders from the mounted databases. The format pools its records
(constants, constant and texture functions, vertex, pixel and geometry permutations, solutions and
their states, geometry declarations) and the shaders index into the pools; Rime keeps each record's
bytes and renumbers only the indices, so all 33 retail databases read and write back byte-identical
(`round_trip_shader_databases`), and identical records are stored once when shaders from several
databases are combined. Each shader comes from the level's namesake database when there is one,
else from the first that has it; with `all_solutions` it also gets the solutions only later
databases have. Copying can't make solutions retail has never compiled: built from the other 32
databases, `mp_subway` lacks 195 of its shaders and, even with all solutions, 4 % of the solutions of
the rest.

The shaders a level's database holds:
- what its bundles' content draws with: shaders non-mesh partitions reference, and per mesh
  variation database entry, each material's variation shader, or the material's when it has none
  (a mesh's own materials count only where something draws it without the database, like mesh
  particles). The gamemode bundles' shaders are collected while they are built
  (`collect_drawn_shaders`), so the main bundle goes last;
- the engine's own: shaders nearly every database holds that no partition imports, and for a level
  with terrain, the terrain system's (shaders nearly every database with terrain shaders holds and
  none without);
- the generated ones, named after a partition of the bundle: the terrain's permutations
  (`<terrain>__<layers>__<mode>__0`) and default surface shader.

The shaders it lists ship in its bundle as partitions; the bundle also carries the textures they bind,
except those another bundle of the superbundle carries.

### Building one (BF4)
Version 194 pools its records the same way, with a quality level in the header, hull and domain
permutation pools (render path 3 uses them), 80-byte solutions with seven indices and the
tessellation fragment in the solution state. Shaders name their textures only by hash; the names are
in the texture constants of their solutions. Both versions share one reader, writer and merger
(`RimeLib.Shader.Pooled`); an engine only describes its layout. All 32 BF4 databases read and write
back byte-identical, and `mp_siege` rebuilt from its own database matches every solution.

Unlike BF3, BF4 compiles a shader per level: for the same shader and solution state, `mp_siege` and
`mp_flooded` have different pixel bytecode and constants in 3280 of their 7245 shared solutions,
because the level's textures are compiled in (`mp_siege`'s dirt mask, `mp_flooded`'s rain drops).
Copying a shader from another level gives it that level's look, so the level's own database is the
only faithful source for its shaders. Built from the other 31 databases, `mp_siege` lacks 117 of its
551 shaders.

### Material grid
Every level ships its own cooked grid (`levels/<level>/<level>/materialgrid_win32` in BF4,
`.../materialgrid_win32/grid` in BF3), referenced by `LevelData.RuntimeMaterialGrid`. BF4
`mp_siege`'s `MaterialGridData`:
- `MaterialIndexMap`: 240 entries, one per global material index (the index meshes and Havok data
  carry), mapping it to a grid row, 0 for "default". 165 rows used.
- `MaterialProperties`: 165 entries of per-material property data (sound, terrain, impulse).
- `InteractionGrid`: 165 × 165 `MaterialRelationPropertyPair`s with damage, effect, sound,
  penetration, decal, vehicle, terrain-destruction and tire-trail relations. They reference about 200
  effects and sounds, which is how impact effects get into a level.

Every level's grid is a consistent piece of one global grid. Across the 19 BF4 grids (33275 material
pairs that occur in more than one level) and the 33 BF3 grids (17265), no pair's relations and no
material's properties differ between levels. A level's grid holds exactly the materials it uses: up to
171 of the 190 that appear in any BF4 grid (240 global indices), up to 121 of 138 in BF3 (180).

The grids are cooked, and their source doesn't fully ship: BF3 ships `materials/materialcontainer`
(in `win32/globals` and each level's `gameconfiglight` bundle), which defines the materials and which
each grid's `DefaultMaterial` and `MaterialPairs` (180 × 180) point at, but not the relations. BF4 has
no container at all; its grids use packed material indices.

So the builder derives a grid instead of cooking one:
1. Build the global grid once per game: the union of every retail grid, keyed by global material
   index. Consistency makes the union well defined.
2. Collect the global material indices everything in the level uses (meshes, Havok physics data,
   terrain, and the soldiers, weapons and vehicles the level loads).
3. Emit the level's grid: one row per used material, the index map, and the relations between used
   pairs, copied from the global grid. A material no retail grid has (50 BF4 indices, 42 BF3) can't be
   derived; no retail content uses them in a level, so this should only matter for new materials.
4. Ship every effect and sound the copied relations reference. Retail levels carry leftovers here:
   `mp_siege` holds effects and sounds that only other levels' grids reference.

The simplest version for a level cloned from a retail one: keep its grid, and add rows only for
materials the new content brings in.

Step 2 needs the material indices in mesh and Havok payloads, which Rime doesn't read yet.
`build_material_grid <partition> <all|grid,...>` implements steps 1, 3 and 4 with the material set
given as grids: rows for the materials of those grids, relations from every grid in the game, and a
`GRID-REF` line for every partition the relations reference. Rebuilding `mp_subway`'s and `mp_001`'s
grids from their own material sets reproduces every relation and property (10506 and 12432). `all`
gives every material any BF3 grid has (138); 812 of those pairs never occur together in a retail
level and take the default material's relation.

## Builder design

### Level recipe
One file describing the level: name; base (empty, or a clone of a retail level); the bundle tree
(main bundle, sub-worlds with parent and gamemode inclusion, UI and settings bundles); per bundle only
the content actually wanted (root partitions, templates, imported files). Everything else is derived.
The existing REPL commands stay as the building blocks.

### Pipeline (`build_level <recipe>`)
1. **Resolve**: closure per bundle with the parent bundles as dependencies (no double registration),
   scenarios for mutually exclusive gamemodes, and hoisting of content several gamemodes share.
2. **Derive**: per bundle its mesh variation database, `RegistryContainer` and `SubWorldData`
   (sub-worlds); for the main bundle the shader database (union of every shader any bundle uses,
   plus terrain permutations), the material grid, `LevelData`'s sub-world references, the level
   registry, and the by-name roots above.
3. **Validate**: unresolved references, double registrations, shaders missing from the shader
   database, superbundle-level chunks, and a coverage check of the built level with `analyze_level`.
4. **Emit**: superbundle and bundles, CAS or non-CAS.

Derivation steps are engine-specific (BF4 has no `RegistryContainer`, for example) and sit behind
engine interfaces, so no version-specific code lives in the general projects.

### Existing building blocks
`reference_existing_partition` (closure, dependency and scenario bundles; its walk is
`AssetReferenceScanner`), `generate_registry_container`, `emit_subworld_registry`,
`mvdb_add_all` / `mvdb_add_entry`, `resolve_shader_textures`, `analyze_level`; derived from content
and compared with retail: `derive_registry`, `derive_mesh_variation_db`; in bundle building:
`derive_registry_container` (also writes BF4's `_networkregistry_win32`), `build_mesh_variation_db`,
`build_material_grid`, `add_shader_textures`, `hoist_content`, `build_shader_database`,
`collect_drawn_shaders`; and `build_level`, which runs them
from a JSON recipe and compares each bundle with its retail namesake.

Missing: material indices from mesh and Havok payloads, `build_level` on a BF4 level (not
tried yet), `LevelData` sub-world reference generation.

### Measured on `mp_subway` (BF3)
Recipe: [`recipes/mp_subway.json`](recipes/mp_subway.json): the 11 gamemode and sub-world bundles,
then the main bundle with its shader database.
- Gamemode bundles, each against the retail main bundle: 6 of 11 exact, the others one or two
  partitions short (`rush` 1541 of 1542); nothing extra.
- Main bundle: 10087 of 10096 partitions, nothing extra; 1023 of 1025 mesh variation entries;
  shader database 639 of 640 shaders, every solution of them identical.
- The recipe lists the by-name roots (UI assets, weapon mesh variation databases, ...) and hoists the
  partitions of type `UI*`, `VeniceUI*`, `EffectBlueprint` and `ShaderGraph` that the gamemodes
  reach. `win32/ui` is not a dependency: the level carries its own copy of the in-game UI flow.
- Missing: two meshes only the retail mesh variation database lists (and the scattering shader and
  texture one of them brings), and five textures of the frontend visual environment.
- A mesh brings the textures of its mesh variation entries only once the bundle's own database is
  derived. Taking them from every retail database adds the camos of every level.

### Templates
Recipe fragments that expand to a root list by querying the mounted game ("all weapons": every weapon
blueprint and unlock; "xp4 soldiers": every soldier asset in the XP4 superbundles), then go through
the same closure, deduplication and derivation. Queries rather than fixed lists, so they survive
patches.

### Empty level
The smallest level that loads: `LevelData`, settings and game config bundles, the UI bundles, the
by-name roots above, possibly a flat terrain. Found by experiment, then extended one gamemode at a
time.

## Phases
1. **Research** with `analyze_level` until every bundle of a BF3 and a BF4 level is explained. Done
   for `mp_subway` and `mp_siege`, including every shader of both shader databases and the material
   grids of every level. Still open: BF4 terrain payloads and terrain decal shader names.
2. **Recipe and pipeline on existing commands.** Oracle: describe a retail level as a recipe, rebuild
   it, and compare the derived parts (mesh variation databases, registries, shader database,
   sub-world references) with retail; then `analyze_level` on the result must leave nothing
   unexplained.
3. **New derivations**: shader database builder, material grid, `LevelData` sub-world references,
   hoisting.
4. **Templates.**
5. **Empty level**, then extend it by one gamemode bundle, end to end in game.

## BF4
Measured on `mp_siege` (26 bundles, 20018 distinct items). Differences from BF3:
- Level content lives in sub-worlds: `content` (11221 items) and `gen4_content` (6981) carry the
  level's objects, the main bundle (2429) mostly terrain, sound, effects and the shader database.
  Gamemode sub-worlds (`conquestlarge0`, `rushlarge0`, ...) hold about 2000 items each.
- No `RegistryContainer`: each bundle has a `<bundle>_networkregistry_win32` partition
  (`NetworkRegistryAsset`) and its `meshvariationdb_win32`.
- EBX refers to resources by id (`ResourceRef`), not by name.

Main bundle: 2293 from `LevelData`'s closure, 88 from its mesh variation database and network
registry, 42 entry points nothing imports (terrain chunks and terrain assets, the ant state, 5
borrowed textures), 3 leftovers, 0 unexplained. Every other bundle: 0 unexplained.

Getting here took two fixes in Rime's BF4 readers:
- The partition GUID index was switched off, so no reference across partitions resolved (#51).
- The EBX reader filled in only the first instance of each run of same-typed instances, leaving the
  rest empty. Of 160 voice-over dialog clips, 159 read as having no takes; 2400 level partitions
  were in import tables without being referenced by any parsed field (#52). `analyze_level` now reports
  such import-table entries the parse misses, so a reader gap like this shows up in the report.

## Open questions
- How BF4 names its terrain decal shaders (10 in `mp_siege`), and walking BF4's `VisualTerrain` and
  `TerrainStreamingTree` payloads.
- Which game first: BF3 (most building work so far) or BF4?
- How builds reach the game: the mod loader's runtime injection (which `emit_subworld_registry`
  targets) or replacing superbundles on disk. This decides whether the main bundle may be changed or
  its derived parts have to ship as sidecars.
- Recipe format: JSON file or REPL script.
