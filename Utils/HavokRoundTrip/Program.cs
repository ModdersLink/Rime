using System.Numerics;
using RimeLib.Havok.Frostbite2_0;
using RimeLib.IO;

// Reads shipped HavokPhysicsData resources, writes them back, and diffs the BYTES.
//
// Lives outside the REPL on purpose: a full BF3 mount is expensive and shared, so the resources are
// dumped once (round_trip_writers <dir>) and this iterates against the files. The verdict is
// guarded on content -- if no file parsed, that is reported as such and not as a clean sweep.
if (args.Length < 1)
{
    Console.Error.WriteLine("Usage: HavokRoundTrip <directory-of-dumped-resources> [max-failures-to-list]");
    return 2;
}

var s_Files = Directory.GetFiles(args[0], "*.bin").OrderBy(p => p).ToArray();
var s_ListLimit = args.Length > 1 ? int.Parse(args[1]) : 10;

// Optional substring: print the shape breakdown for the resources whose name contains it. Named
// resources are how the claims in the docs are checked against something a person can picture.
var s_Detail = args.Length > 2 ? args[2] : null;

var s_Parsed = 0;
var s_Unparseable = 0;
var s_Identical = 0;
var s_LengthDiffers = 0;
var s_ContentDiffers = 0;

long s_TotalBytes = 0;
long s_ModelledBytes = 0;
long s_CopiedBytes = 0;

var s_Failures = new List<string>();
var s_Unparsed = new List<string>();

var s_Descriptors = 0;
var s_DescriptorInfos = 0;
var s_Translations = 0;
var s_Aabbs = 0;
var s_Probed = 0;
var s_Unprobed = 0;
var s_ProbeFailed = 0;

// SHAPE COVERAGE. Byte round-tripping says nothing about whether the geometry can be READ, and
// until now it could not: the reader swept the virtual fixups for shape classes instead of walking
// the graph, so an instanced shape came back once and a rotated placement came back at the origin.
var s_Placements = 0;
var s_MeshVertices = 0;
var s_MeshTriangles = 0;
var s_ByKind = new Dictionary<string, int>();
var s_UnreadByClass = new Dictionary<string, int>();
var s_FullyRead = 0;
var s_PartlyRead = 0;

// Guard A: the flat virtual-fixup census counts the wrapper objects; the walk reaches them. The two
// are computed by completely different routes, so agreement is evidence the walk missed no subtree.
var s_Wrappers = 0;
var s_WrappersReached = 0;
var s_WrapperShort = new List<string>();

// The same two numbers over the WHOLE corpus, undecodable classes included. This is the honest
// coverage figure; the pair above is the one held to equality, because a resource whose graph runs
// through an SDK-baked mesh legitimately hides placements inside it.
var s_WrappersAll = 0;
var s_WrappersReachedAll = 0;

// For the wrappers the walk never stands on, WHO points at them. Without this, "reached n of m" is
// a number with no explanation and no way to tell a missed subtree from a shape the format keeps
// somewhere this deliberately does not go.
var s_MissedOwners = new Dictionary<string, int>();

// Guard B: a Havok placement is rigid, so its rotation determinant is 1. A column read at the wrong
// offset still produces confident-looking geometry; this is what would catch it.
var s_Rotations = 0;
var s_Rotated = 0;
var s_BadDeterminant = 0;
var s_WorstDeterminant = 0.0;

foreach (var l_File in s_Files)
{
    var s_Original = File.ReadAllBytes(l_File);
    HavokPhysicsData s_Data;

    // The reader outlives the parse on purpose: HavokInstance keeps a LimitedRimeReader over it and
    // GetShapes reads the object bodies through that, so disposing it at the end of the parse would
    // make every shape read throw. `using var` in a loop body still releases it per iteration.
    using var s_Reader = new RimeReader(new MemoryStream(s_Original));

    try
    {
        s_Data = new HavokPhysicsData(s_Reader);
    }
    catch (Exception s_Exception)
    {
        ++s_Unparseable;

        if (s_Unparsed.Count < s_ListLimit)
            s_Unparsed.Add($"{Path.GetFileName(l_File)}: {s_Exception.GetType().Name}: {s_Exception.Message}");

        continue;
    }

    ++s_Parsed;

    if (!s_Data.Serialize(out var s_Written) || s_Written == null)
    {
        ++s_ContentDiffers;

        if (s_Failures.Count < s_ListLimit)
            s_Failures.Add($"{Path.GetFileName(l_File)}: writer returned false");

        continue;
    }

    // How much of the file is written from decoded fields and how much is carried verbatim. The
    // second number is the honest size of what Rime still does not model.
    var s_Copied = (long) s_Data.HavokInstance32.ObjectData.Length
                 + s_Data.HavokInstance64.ObjectData.Length
                 + s_Data.HavokInstance32.FixupData.Length
                 + s_Data.HavokInstance64.FixupData.Length;

    s_TotalBytes += s_Original.Length;
    s_CopiedBytes += s_Copied;
    s_ModelledBytes += s_Original.Length - s_Copied;

    if (s_Written.Length != s_Original.Length)
    {
        ++s_LengthDiffers;

        if (s_Failures.Count < s_ListLimit)
            s_Failures.Add($"{Path.GetFileName(l_File)}: {s_Written.Length} bytes written vs {s_Original.Length} shipped");

        continue;
    }

    var s_Diff = -1;

    for (var i = 0; i < s_Original.Length; ++i)
    {
        if (s_Original[i] != s_Written[i])
        {
            s_Diff = i;
            break;
        }
    }

    if (s_Diff < 0)
    {
        ++s_Identical;

        s_Descriptors += s_Data.HavokInstance32.Descriptors.Count + s_Data.HavokInstance64.Descriptors.Count;
        s_DescriptorInfos += s_Data.HavokInstance32.DescriptorInfos.Count + s_Data.HavokInstance64.DescriptorInfos.Count;
        s_Translations += s_Data.PartTranslations.Count;
        s_Aabbs += s_Data.LocalAabbs.Count;

        // EDIT PROBE. Byte equality on its own does not distinguish a writer that emits fields from
        // one that hands back a copy of what it read -- and this project has shipped that mistake
        // before. So change one decoded field and require that EXACTLY the bytes behind it move.
        var s_Probe = Probe(s_Data, s_Original);

        if (s_Probe == null)
            ++s_Unprobed;
        else if (s_Probe.Length == 0)
            ++s_Probed;
        else if (s_Failures.Count < s_ListLimit)
            s_Failures.Add($"{Path.GetFileName(l_File)}: edit probe -- {s_Probe}");

        if (s_Probe is { Length: > 0 })
            ++s_ProbeFailed;

        Cover(s_Data, Path.GetFileName(l_File));

        continue;
    }

    ++s_ContentDiffers;

    if (s_Failures.Count < s_ListLimit)
        s_Failures.Add($"{Path.GetFileName(l_File)}: first diff at 0x{s_Diff:X} " +
                       $"(shipped 0x{s_Original[s_Diff]:X2}, written 0x{s_Written[s_Diff]:X2}) of {s_Original.Length}");
}

Console.WriteLine($"corpus       {s_Files.Length} resource(s)");
Console.WriteLine($"parsed       {s_Parsed}, unparseable {s_Unparseable}");
Console.WriteLine($"BYTES        {s_Identical} of {s_Parsed} byte-identical " +
                  $"(length differs {s_LengthDiffers}, content differs {s_ContentDiffers})");

if (s_TotalBytes > 0)
    Console.WriteLine($"written from decoded fields {s_ModelledBytes} bytes, carried verbatim {s_CopiedBytes} bytes " +
                      $"({100.0 * s_ModelledBytes / s_TotalBytes:F1}% modelled)");

Console.WriteLine($"content      {s_Descriptors} class descriptor(s), {s_DescriptorInfos} virtual fixup(s), " +
                  $"{s_Translations} part translation(s), {s_Aabbs} local aabb(s)");
Console.WriteLine($"edit probe   {s_Probed} moved exactly the edited bytes, {s_ProbeFailed} did not, " +
                  $"{s_Unprobed} had no array to edit");
Console.WriteLine();
Console.WriteLine($"SHAPES       {s_Placements} placement(s) read across {s_Identical} resource(s); " +
                  $"{s_FullyRead} resource(s) fully read, {s_PartlyRead} hold at least one class this cannot decode");
Console.WriteLine($"  meshes     {s_MeshVertices} vertices, {s_MeshTriangles} triangles from storage subparts");
Console.WriteLine("  by kind    " + string.Join(", ", s_ByKind.OrderByDescending(p => p.Value)
                                                              .Select(p => $"{p.Key} {p.Value}")));
Console.WriteLine($"  wrappers   {s_WrappersReachedAll} of {s_WrappersAll} placement wrappers reached corpus-wide; " +
                  $"{s_WrappersReached} of {s_Wrappers} in resources with no undecodable class " +
                  "(flat virtual-fixup census vs traversal)");
Console.WriteLine($"  rotations  {s_Rotations} rigid placement(s), of which {s_Rotated} carry a rotation; " +
                  $"{s_BadDeterminant} with a non-unit determinant " +
                  $"(worst |det - 1| = {s_WorstDeterminant:E2})");
Console.WriteLine("  unreached  " + (s_MissedOwners.Count == 0
    ? "none"
    : "held only by " + string.Join(", ", s_MissedOwners.OrderByDescending(p => p.Value)
                                                        .Select(p => $"{p.Key} ({p.Value} pointer slot(s))"))));
Console.WriteLine("  NOT READ   " + (s_UnreadByClass.Count == 0
    ? "nothing"
    : string.Join(", ", s_UnreadByClass.OrderByDescending(p => p.Value).Select(p => $"{p.Key} {p.Value}"))));

foreach (var l_Short in s_WrapperShort.Take(s_ListLimit))
    Console.WriteLine($"  WRAPPERS MISSED {l_Short}");

foreach (var l_Failure in s_Failures)
    Console.WriteLine($"  FAIL {l_Failure}");

foreach (var l_Unparsed in s_Unparsed)
    Console.WriteLine($"  UNPARSED {l_Unparsed}");

if (s_Parsed == 0 || s_Descriptors == 0 || s_Translations == 0 || s_Probed == 0 || s_Placements == 0)
{
    Console.WriteLine("RESULT       NOTHING TESTED -- parsed, decoded, probed or read nothing, so no verdict is available.");
    return 1;
}

var s_Pass = s_Identical == s_Parsed && s_ProbeFailed == 0
             && s_WrappersReached == s_Wrappers && s_BadDeterminant == 0;

Console.WriteLine(s_Pass ? "RESULT       PASS" : "RESULT       FAIL");

return s_Pass ? 0 : 1;

// Walks the shapes and folds the coverage numbers in. Declared as a local function so it can reach
// the counters above; everything it touches is measured, nothing is assumed.
void Cover(HavokPhysicsData p_Data, string p_Name)
{
    var s_Shapes = p_Data.GetShapes(out var s_Unread);

    s_Placements += s_Shapes.Count;
    s_MeshVertices += s_Shapes.Sum(p => p.Kind == "mesh" ? p.Vertices.Count : 0);
    s_MeshTriangles += s_Shapes.Sum(p => p.Kind == "mesh" ? p.Indices.Count / 3 : 0);

    foreach (var l_Shape in s_Shapes)
    {
        s_ByKind[l_Shape.Kind] = s_ByKind.TryGetValue(l_Shape.Kind, out var l_Kind) ? l_Kind + 1 : 1;

        ++s_Rotations;

        // Placements the previous reader could not have expressed at all: it carried a centre and
        // no orientation, so a rotated shape came back axis-aligned.
        if (Vector3.Distance(l_Shape.Placement.Column0, Vector3.UnitX) > 1e-6f
            || Vector3.Distance(l_Shape.Placement.Column1, Vector3.UnitY) > 1e-6f
            || Vector3.Distance(l_Shape.Placement.Column2, Vector3.UnitZ) > 1e-6f)
            ++s_Rotated;

        var l_Off = Math.Abs(l_Shape.Placement.Determinant() - 1.0);

        if (l_Off > s_WorstDeterminant)
            s_WorstDeterminant = l_Off;

        if (l_Off > 1e-3)
            ++s_BadDeterminant;
    }

    if (s_Detail != null && p_Name.Contains(s_Detail, StringComparison.OrdinalIgnoreCase))
    {
        var s_Kinds = s_Shapes.GroupBy(p => p.Kind).OrderByDescending(g => g.Count());
        var s_Rot = s_Shapes.Count(p => Vector3.Distance(p.Placement.Column0, Vector3.UnitX) > 1e-6f
                                        || Vector3.Distance(p.Placement.Column1, Vector3.UnitY) > 1e-6f
                                        || Vector3.Distance(p.Placement.Column2, Vector3.UnitZ) > 1e-6f);

        Console.WriteLine($"DETAIL {p_Name}: {s_Shapes.Count} placement(s) of " +
                          $"{s_Shapes.Select(p => p.Offset).Distinct().Count()} distinct shape(s) -- " +
                          string.Join(", ", s_Kinds.Select(g => $"{g.Count()} {g.Key}")) +
                          $"; {s_Rot} rotated; " +
                          $"{s_Shapes.Sum(q => q.Vertices.Count)} vertices, " +
                          $"{s_Shapes.Sum(q => q.Indices.Count) / 3} triangle(s); unread " +
                          (s_Unread.Count == 0 ? "nothing"
                           : string.Join(", ", s_Unread.Select(q => $"{q.Key} {q.Value}"))));
    }

    foreach (var l_Pair in s_Unread)
        s_UnreadByClass[l_Pair.Key] = s_UnreadByClass.TryGetValue(l_Pair.Key, out var l_Count)
            ? l_Count + l_Pair.Value : l_Pair.Value;

    if (s_Unread.Count == 0)
        ++s_FullyRead;
    else
        ++s_PartlyRead;

    // The independent half: name every wrapper object from the FLAT virtual-fixup table, then ask
    // which of them the traversal actually stood on.
    var s_Instance = p_Data.HavokInstance32;
    var s_NameOf = new Dictionary<long, string>();

    foreach (var l_Descriptor in s_Instance.Descriptors)
        s_NameOf[l_Descriptor.Key] = l_Descriptor.Name;

    var s_WrapperOffsets = new HashSet<long>();

    foreach (var l_Info in s_Instance.DescriptorInfos)
    {
        if (!s_NameOf.TryGetValue(l_Info.Key, out var l_Name))
            continue;

        if (l_Name == "hkpConvexTranslateShape" || l_Name == "hkpConvexTransformShape")
            s_WrapperOffsets.Add(l_Info.Offset);
    }

    var s_Reached = new HashSet<long>(s_Shapes.Select(p => p.PlacementOffset)
                                              .Where(s_WrapperOffsets.Contains));

    s_WrappersAll += s_WrapperOffsets.Count;
    s_WrappersReachedAll += s_Reached.Count;

    if (s_Reached.Count != s_WrapperOffsets.Count)
    {
        var s_Starts = s_Instance.DescriptorInfos.Select(i => i.Offset).Distinct().OrderBy(o => o).ToArray();

        foreach (var l_Pair in s_Instance.ObjectOffsets)
        {
            if (s_Reached.Contains(l_Pair.Value) || !s_WrapperOffsets.Contains(l_Pair.Value))
                continue;

            // The owner of a pointer slot is the last object that starts at or before it.
            var l_At = Array.BinarySearch(s_Starts, l_Pair.Key);

            if (l_At < 0)
                l_At = ~l_At - 1;

            var l_Owner = l_At >= 0 && s_NameOf.TryGetValue(
                s_Instance.DescriptorInfos.First(i => i.Offset == s_Starts[l_At]).Key, out var l_Name)
                ? l_Name : "<unknown>";

            s_MissedOwners[l_Owner] = s_MissedOwners.TryGetValue(l_Owner, out var l_Count) ? l_Count + 1 : 1;
        }
    }

    // A resource that holds a class this cannot decode may legitimately hide wrappers inside it --
    // hkpExtendedMeshShape carries its own -- so only the fully-read ones are held to equality.
    if (s_Unread.Count > 0)
        return;

    s_Wrappers += s_WrapperOffsets.Count;
    s_WrappersReached += s_Reached.Count;

    if (s_Reached.Count != s_WrapperOffsets.Count)
        s_WrapperShort.Add($"{p_Name}: reached {s_Reached.Count} of {s_WrapperOffsets.Count}");
}

// Mutates one decoded value and reports whether re-serializing moved exactly the bytes behind it.
// Returns null when the resource carries no array to edit, an empty string on success, and a
// description otherwise.
static string? Probe(HavokPhysicsData p_Data, byte[] p_Original)
{
    long s_Offset;
    int s_Width;

    if (p_Data.PartTranslations.Count > 0)
    {
        // A float32, so flip it to a value nothing else in the file can coincide with.
        p_Data.PartTranslations[0].x = -12345.678f;
        s_Offset = p_Data.PartTranslationsOffset;
        s_Width = 4;
    }
    else if (p_Data.MaterialIndices.Count > 0)
    {
        p_Data.MaterialIndices[0] ^= 0xFF;
        s_Offset = p_Data.MaterialIndicesOffset;
        s_Width = 1;
    }
    else
    {
        return null;
    }

    if (!p_Data.Serialize(out var s_Edited) || s_Edited == null)
        return "the writer refused the edited resource";

    if (s_Edited.Length != p_Original.Length)
        return $"length changed to {s_Edited.Length} from {p_Original.Length}";

    var s_Moved = new List<int>();

    for (var i = 0; i < p_Original.Length; ++i)
        if (p_Original[i] != s_Edited[i])
            s_Moved.Add(i);

    // The assertion is on the SPAN, not the count: a float whose original bytes happen to share one
    // with the probe value moves 3 bytes rather than 4, and 26 of BF3's resources do exactly that.
    // What must hold is that something moved and that nothing outside the edited field did.
    if (s_Moved.Count == 0)
        return "nothing changed -- the writer is not emitting from the field";

    var s_Outside = s_Moved.Where(o => o < s_Offset || o >= s_Offset + s_Width).ToList();

    if (s_Outside.Count > 0)
        return $"{s_Outside.Count} byte(s) changed outside the edited field, first at 0x{s_Outside[0]:X} " +
               $"(field is 0x{s_Offset:X}..0x{s_Offset + s_Width:X})";

    return string.Empty;
}
