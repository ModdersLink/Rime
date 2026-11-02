using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.IO;

namespace RimeLib.Shader.Pooled;

/// <summary>A place in a record that holds an index into a pool; -1 means none.</summary>
public readonly record struct RecordRef(int Offset, bool Wide, int Pool);

/// <summary>A pool record as its bytes, with the places that index other pools.</summary>
public sealed class PooledRecord
{
    public byte[] Bytes { get; init; } = [];
    public IReadOnlyList<RecordRef> Refs { get; init; } = [];

    public long GetIndex(RecordRef p_Ref)
    {
        using var s_Reader = ReaderAt(Bytes, p_Ref.Offset);
        return p_Ref.Wide ? s_Reader.ReadInt64() : s_Reader.ReadInt32();
    }

    public void SetIndex(RecordRef p_Ref, long p_Value)
    {
        using var s_Writer = new RimeWriter(new MemoryStream(Bytes, true));
        s_Writer.Seek(p_Ref.Offset, SeekOrigin.Begin);
        if (p_Ref.Wide)
            s_Writer.Write(p_Value);
        else
            s_Writer.Write((int)p_Value);
    }

    public static RimeReader ReaderAt(byte[] p_Bytes, int p_Offset)
    {
        var s_Reader = new RimeReader(new MemoryStream(p_Bytes, false));
        s_Reader.Seek(p_Offset, SeekOrigin.Begin);
        return s_Reader;
    }

    public PooledRecord Clone() => new() { Bytes = (byte[])Bytes.Clone(), Refs = Refs };

    /// <summary>
    /// Reads one record. The callback skips over it and calls the given ref function where it holds
    /// an index (pool, wide), which also skips the index.
    /// </summary>
    public static PooledRecord Read(RimeReader p_Reader, Action<RimeReader, Action<int, bool>> p_Skip)
    {
        var s_Start = p_Reader.Position;
        List<RecordRef>? s_Refs = null;
        p_Skip(p_Reader, (p_Pool, p_Wide) =>
        {
            (s_Refs ??= new()).Add(new RecordRef((int)(p_Reader.Position - s_Start), p_Wide, p_Pool));
            p_Reader.Seek(p_Wide ? 8 : 4, SeekOrigin.Current);
        });

        var s_End = p_Reader.Position;
        p_Reader.Seek(s_Start, SeekOrigin.Begin);
        return new PooledRecord { Bytes = p_Reader.ReadBytes((int)(s_End - s_Start)), Refs = (IReadOnlyList<RecordRef>?)s_Refs ?? [] };
    }
}

public sealed class PooledShaderEntry
{
    /// <summary>The lowercase name hash of the shader asset.</summary>
    public uint Key { get; set; }

    /// <summary>Everything between the key and the solution count.</summary>
    public byte[] Info { get; set; } = [];

    public List<ushort> Solutions { get; set; } = new();
}

/// <summary>One render path's database.</summary>
public sealed class PooledDatabase
{
    public PooledShaderDatabaseFormat Format { get; init; } = null!;
    public uint RenderPathKey { get; init; }

    /// <summary>From the version up to the first pool.</summary>
    public byte[] Header { get; init; } = [];

    /// <summary>One list per pool of the format, in file order; the last holds the solutions.</summary>
    public List<PooledRecord>[] Pools { get; init; } = [];

    public List<PooledRecord> Solutions => Pools[^1];

    /// <summary>One per solution, in the same order.</summary>
    public List<byte[]> States { get; } = new();

    public List<(uint Hash, byte[] Desc)> Declarations { get; } = new();
    public List<PooledShaderEntry> Shaders { get; } = new();

    /// <summary>Whatever follows the shader table.</summary>
    public byte[] Trailing { get; set; } = [];

    public static ulong StateHash(PooledRecord p_Solution)
    {
        using var s_Reader = PooledRecord.ReaderAt(p_Solution.Bytes, 0);
        return s_Reader.ReadUInt64();
    }

    public uint DeclarationHash(int p_Solution)
    {
        using var s_Reader = PooledRecord.ReaderAt(States[p_Solution], Format.DeclarationHashOffset);
        return s_Reader.ReadUInt32();
    }

    /// <summary>A database of the same format and render path, with nothing in it.</summary>
    public PooledDatabase CreateEmpty() => new()
    {
        Format = Format,
        RenderPathKey = RenderPathKey,
        Header = Header,
        Pools = Pools.Select(_ => new List<PooledRecord>()).ToArray(),
    };
}

/// <summary>
/// The layout of one shader database version. The databases pool their records (constants,
/// functions, permutations, solutions), each pool a count followed by its records, then the
/// solution states, the geometry declarations and the shader table.
/// </summary>
public abstract class PooledShaderDatabaseFormat
{
    public abstract uint Version { get; }

    /// <summary>Bytes from the version up to the first pool.</summary>
    public abstract int HeaderSize { get; }

    /// <summary>Name and reader per pool, in file order; the solutions come last.</summary>
    public abstract IReadOnlyList<(string Name, Func<RimeReader, PooledRecord> Read)> Pools { get; }

    public abstract int StateSize { get; }
    public abstract int DeclarationHashOffset { get; }

    /// <summary>A geometry declaration without its hash.</summary>
    public abstract int DeclarationSize { get; }

    /// <summary>Skips a shader entry's info, from after its key up to its solution count.</summary>
    public abstract void SkipShaderInfo(RimeReader p_Reader);
}

/// <summary>
/// A shader database container (a count, then per render path its key, size and database) as its
/// records' bytes. Writing an unchanged image gives back the input bytes; shaders can be moved
/// between images by copying their records and renumbering the indices.
/// </summary>
public sealed class PooledShaderDatabaseImage
{
    public List<PooledDatabase> Databases { get; } = new();

    public static PooledShaderDatabaseImage Read(byte[] p_Data, PooledShaderDatabaseFormat p_Format)
    {
        var s_Image = new PooledShaderDatabaseImage();
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));

        var s_Count = s_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
        {
            var s_Key = s_Reader.ReadUInt32();
            var s_Size = s_Reader.ReadUInt32();
            var s_End = s_Reader.Position + s_Size;
            s_Image.Databases.Add(ReadDatabase(s_Reader, p_Format, s_Key, s_End));
            s_Reader.Seek(s_End, SeekOrigin.Begin);
        }

        return s_Image;
    }

    private static PooledDatabase ReadDatabase(RimeReader p_Reader, PooledShaderDatabaseFormat p_Format, uint p_Key, long p_End)
    {
        var s_Version = p_Reader.ReadUInt32();
        p_Reader.Seek(-4, SeekOrigin.Current);
        var s_Header = p_Reader.ReadBytes(p_Format.HeaderSize);
        if (s_Version != p_Format.Version)
            throw new Exception($"Unsupported shader database version (expected {p_Format.Version} got {s_Version}).");

        var s_Database = new PooledDatabase
        {
            Format = p_Format,
            RenderPathKey = p_Key,
            Header = s_Header,
            Pools = p_Format.Pools.Select(_ => new List<PooledRecord>()).ToArray(),
        };

        for (var p = 0; p < p_Format.Pools.Count; p++)
        {
            var s_Read = p_Format.Pools[p].Read;
            var s_Count = p_Reader.ReadUInt32();
            for (var i = 0; i < s_Count; i++)
                s_Database.Pools[p].Add(s_Read(p_Reader));
        }

        var s_States = p_Reader.ReadUInt32();
        if (s_States != s_Database.Solutions.Count)
            throw new Exception($"Solution state count {s_States} doesn't match solution count {s_Database.Solutions.Count}.");
        for (var i = 0; i < s_States; i++)
            s_Database.States.Add(p_Reader.ReadBytes(p_Format.StateSize));

        var s_Declarations = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Declarations; i++)
            s_Database.Declarations.Add((p_Reader.ReadUInt32(), p_Reader.ReadBytes(p_Format.DeclarationSize)));

        var s_Shaders = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Shaders; i++)
        {
            var s_Shader = new PooledShaderEntry { Key = p_Reader.ReadUInt32() };
            var s_Start = p_Reader.Position;
            p_Format.SkipShaderInfo(p_Reader);
            var s_InfoEnd = p_Reader.Position;
            p_Reader.Seek(s_Start, SeekOrigin.Begin);
            s_Shader.Info = p_Reader.ReadBytes((int)(s_InfoEnd - s_Start));

            var s_Solutions = p_Reader.ReadUInt32();
            for (var j = 0; j < s_Solutions; j++)
                s_Shader.Solutions.Add(p_Reader.ReadUInt16());

            s_Database.Shaders.Add(s_Shader);
        }

        s_Database.Trailing = p_Reader.ReadBytes((int)(p_End - p_Reader.Position));
        return s_Database;
    }

    public byte[] Write()
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        s_Writer.Write((uint)Databases.Count);
        foreach (var s_Database in Databases)
        {
            var s_Bytes = WriteDatabase(s_Database);
            s_Writer.Write(s_Database.RenderPathKey);
            s_Writer.Write((uint)s_Bytes.Length);
            s_Writer.Write(s_Bytes);
        }

        s_Writer.Flush();
        return s_Stream.ToArray();
    }

    private static byte[] WriteDatabase(PooledDatabase p_Database)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        s_Writer.Write(p_Database.Header);
        foreach (var s_Pool in p_Database.Pools)
        {
            s_Writer.Write((uint)s_Pool.Count);
            foreach (var s_Record in s_Pool)
                s_Writer.Write(s_Record.Bytes);
        }

        s_Writer.Write((uint)p_Database.States.Count);
        foreach (var s_State in p_Database.States)
            s_Writer.Write(s_State);

        s_Writer.Write((uint)p_Database.Declarations.Count);
        foreach (var (s_Hash, s_Desc) in p_Database.Declarations)
        {
            s_Writer.Write(s_Hash);
            s_Writer.Write(s_Desc);
        }

        s_Writer.Write((uint)p_Database.Shaders.Count);
        foreach (var s_Shader in p_Database.Shaders)
        {
            s_Writer.Write(s_Shader.Key);
            s_Writer.Write(s_Shader.Info);
            s_Writer.Write((uint)s_Shader.Solutions.Count);
            foreach (var s_Index in s_Shader.Solutions)
                s_Writer.Write(s_Index);
        }

        s_Writer.Write(p_Database.Trailing);
        s_Writer.Flush();
        return s_Stream.ToArray();
    }
}
