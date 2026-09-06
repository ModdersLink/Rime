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

foreach (var l_File in s_Files)
{
    var s_Original = File.ReadAllBytes(l_File);
    HavokPhysicsData s_Data;

    try
    {
        using var s_Reader = new RimeReader(new MemoryStream(s_Original));
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

foreach (var l_Failure in s_Failures)
    Console.WriteLine($"  FAIL {l_Failure}");

foreach (var l_Unparsed in s_Unparsed)
    Console.WriteLine($"  UNPARSED {l_Unparsed}");

if (s_Parsed == 0 || s_Descriptors == 0 || s_Translations == 0 || s_Probed == 0)
{
    Console.WriteLine("RESULT       NOTHING TESTED -- parsed, decoded or probed nothing, so no verdict is available.");
    return 1;
}

var s_Pass = s_Identical == s_Parsed && s_ProbeFailed == 0;

Console.WriteLine(s_Pass ? "RESULT       PASS" : "RESULT       FAIL");

return s_Pass ? 0 : 1;

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
