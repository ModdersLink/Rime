using System;
using System.Collections.Concurrent;
using System.IO;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite2013_2.Mounting;

/// <summary>
/// The partition GUIDs read out of partitions, by the sha1 their payload is named by, kept on disk across runs:
/// the same payload holds the same GUID, so indexing a game again reads only the partitions not seen before
/// instead of opening every one of them (and applying its patch) for the GUID in its header.
/// </summary>
internal sealed class PartitionGuidCache
{
    private const uint c_Magic = 0x43475052; // "RPGC"
    private const int c_Version = 1;

    private static readonly object s_Lock = new();
    private static PartitionGuidCache? s_Instance;

    private readonly ConcurrentDictionary<string, Guid> m_Guids = new(StringComparer.Ordinal);
    private readonly string m_Path;

    private PartitionGuidCache(string p_Path)
    {
        m_Path = p_Path;
    }

    public static PartitionGuidCache Load()
    {
        lock (s_Lock)
        {
            if (s_Instance != null)
                return s_Instance;

            var s_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rime", "cache", "partition-guids-Frostbite2013_2.bin");
            var s_Cache = new PartitionGuidCache(s_Path);
            try
            {
                if (File.Exists(s_Path))
                {
                    using var s_Reader = new BinaryReader(File.OpenRead(s_Path));
                    if (s_Reader.ReadUInt32() == c_Magic && s_Reader.ReadInt32() == c_Version)
                    {
                        var s_Count = s_Reader.ReadInt32();
                        for (var i = 0; i < s_Count; i++)
                            s_Cache.m_Guids[Convert.ToHexString(s_Reader.ReadBytes(20))] = new Guid(s_Reader.ReadBytes(16));
                    }
                }
            }
            catch (Exception)
            {
                // A cache that does not read is no cache: the partitions are read instead.
                s_Cache.m_Guids.Clear();
            }

            return s_Instance = s_Cache;
        }
    }

    public bool TryGet(Sha1 p_Hash, out GUID p_Guid)
    {
        if (m_Guids.TryGetValue(Convert.ToHexString(p_Hash.Hash), out var s_Guid))
        {
            p_Guid = new GUID(s_Guid);
            return true;
        }

        p_Guid = null!;
        return false;
    }

    public void Add(Sha1 p_Hash, GUID p_Guid) => m_Guids[Convert.ToHexString(p_Hash.Hash)] = new Guid(p_Guid.Id);

    public void Save()
    {
        lock (s_Lock)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(m_Path)!);
                var s_Temp = m_Path + ".tmp";
                using (var s_Writer = new BinaryWriter(File.Create(s_Temp)))
                {
                    var s_Entries = m_Guids.ToArray();
                    s_Writer.Write(c_Magic);
                    s_Writer.Write(c_Version);
                    s_Writer.Write(s_Entries.Length);
                    foreach (var (s_Hash, s_Guid) in s_Entries)
                    {
                        s_Writer.Write(Convert.FromHexString(s_Hash));
                        s_Writer.Write(s_Guid.ToByteArray());
                    }
                }

                File.Move(s_Temp, m_Path, true);
            }
            catch (IOException)
            {
                // Not saved: the next run reads the partitions again.
            }
        }
    }
}
