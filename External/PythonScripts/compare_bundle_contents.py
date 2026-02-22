import json
import sys

def compare_json_arrays(arr1, arr2, label, out):
    if not isinstance(arr1, list) or not isinstance(arr2, list):
        raise ValueError("Both JSON files must contain arrays.")

    set1 = set(arr1)
    set2 = set(arr2)

    only_in_1 = sorted(set1 - set2)
    only_in_2 = sorted(set2 - set1)

    out.write(f"=== {label} ===\n")

    out.write("Only in first file:\n")
    for item in only_in_1:
        out.write(f"  {item}\n")

    out.write("\nOnly in second file:\n")
    for item in only_in_2:
        out.write(f"  {item}\n")

    out.write("\n")


def compare_bundle_contents(file1, file2, output_file):
    with open(file1, "r", encoding="utf-8") as f:
        bundle1 = json.load(f)

    with open(file2, "r", encoding="utf-8") as f:
        bundle2 = json.load(f)

    with open(output_file, "w", encoding="utf-8") as out:
        compare_json_arrays(bundle1["ebx"], bundle2["ebx"], "EBX", out)
        compare_json_arrays(bundle1["res"], bundle2["res"], "RES", out)
        compare_json_arrays(bundle1["chunks"], bundle2["chunks"], "CHUNKS", out)


if __name__ == "__main__":
    if len(sys.argv) not in (3, 4):
        print("Usage: python compare_json_arrays.py file1.json file2.json [output.txt]")
        sys.exit(1)

    output_path = sys.argv[3] if len(sys.argv) == 4 else "comparison.txt"
    compare_bundle_contents(sys.argv[1], sys.argv[2], output_path)

# usage add the output from the Rime export_bundle_contents command and the output of the db_object_parser command (which only works for cas bundles)
# to get the differences between the custom rebuild bundle and the original bundle