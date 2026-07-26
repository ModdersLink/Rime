"""Stub realizable SubWorldData for the gridext2 REALIZE pivot.
Port of _make_provider.make_flir_subworld (the PROVEN empty-SubWorld stub recipe):
keep ONLY SubWorldData + RegistryContainer + InterfaceDescriptorData from the rush
template, empty everything, fixed guids. Partition name == bundle name (minus win32/)
so the engine's realize finds the SubWorldData in the loaded bundle:
  SWROD.bundleName = "vehgrid/gridext2"  ->  bundle win32/vehgrid/gridext2
"""
import json

TEMPLATE = r"C:\Users\keku\Documents\Battlefield 3\Server\Admin\Mods\Terrain_Tools\baker\_vehprov\rush_subworld.json"
OUT      = r"F:\tmp\gridprov_stub.json"

PART_G = "aabbccdd-0000-4000-8000-000000000030"
FIXED = {
    "SubWorldData":            "aabbccdd-0000-4000-8000-000000000031",
    "RegistryContainer":       "aabbccdd-0000-4000-8000-000000000032",
    "InterfaceDescriptorData": "aabbccdd-0000-4000-8000-000000000033",
}
NAME = "vehgrid/gridext2"

d = json.load(open(TEMPLATE, encoding="utf-8"))
insts = d["Instances"]
prim_g = d["PrimaryInstanceGuid"]
prim = insts[prim_g]
reg_g = prim["RegistryContainer"]["InstanceGuid"]
desc_g = prim["Descriptor"]["InstanceGuid"]
keep = [prim_g, reg_g, desc_g]           # primary first = compile order
remap = {g: FIXED[insts[g]["$type"]] for g in keep}

def fix_ref(r):
    if isinstance(r, dict) and r.get("InstanceGuid") in remap:
        r["InstanceGuid"] = remap[r["InstanceGuid"]]
        r["PartitionGuid"] = PART_G
    return r

new_insts = {}
for g in keep:
    i = insts[g]
    if i.get("$type") == "SubWorldData":
        i["Objects"] = []; i["PropertyConnections"] = []; i["LinkConnections"] = []
        i["EventConnections"] = []; i["InterfaceHasConnections"] = False; i["NeedNetworkId"] = False
        i["Name"] = NAME
        fix_ref(i["RegistryContainer"]); fix_ref(i["Descriptor"])
    elif i.get("$type") == "RegistryContainer":
        i["EntityRegistry"] = []; i["AssetRegistry"] = []
        i["BlueprintRegistry"] = []; i["ReferenceObjectRegistry"] = []
    elif i.get("$type") == "InterfaceDescriptorData":
        i["Fields"] = []; i["InputEvents"] = []; i["OutputEvents"] = []
        i["InputLinks"] = []; i["OutputLinks"] = []
    new_insts[remap[g]] = i

out = {"PartitionGuid": PART_G, "PrimaryInstanceGuid": remap[prim_g],
       "Name": NAME, "Instances": new_insts}
json.dump(out, open(OUT, "w", encoding="utf-8"), indent=1)
print("stub ->", OUT, "| part", PART_G, "| primary", remap[prim_g], "| insts", len(new_insts))
