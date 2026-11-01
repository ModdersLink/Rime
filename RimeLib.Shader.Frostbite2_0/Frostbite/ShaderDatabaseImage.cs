using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// A shader database container as its records' bytes, with only the fields that index into other
/// pools taken out. Writing an unchanged image gives back the input bytes; shaders can be moved
/// between images by copying their records and renumbering the indices.
/// </summary>
public class ShaderDatabaseImage
{
    public class Permutation
    {
        /// <summary>From the guid up to the indices: guid, bytecode size, bytecode.</summary>
        public byte[] Head { get; set; } = [];

        public uint Constant { get; set; }
        public uint ConstantFunction { get; set; }
        public uint TextureFunction { get; set; }

        /// <summary>The rest: input signature and elements (vertex shaders), instruction count.</summary>
        public byte[] Tail { get; set; } = [];
    }

    public class Solution
    {
        public const int Size = 64;
        private const int c_IndexOffset = 24;

        /// <summary>The record, with the indices still in place.</summary>
        public byte[] Bytes { get; set; } = new byte[Size];

        public ulong StateHash => BitConverter.ToUInt64(Bytes, 0);

        /// <summary>Vertex, pixel and geometry permutation, vertex and pixel constants; -1 for none.</summary>
        public long GetIndex(int p_Slot) => BitConverter.ToInt64(Bytes, c_IndexOffset + p_Slot * 8);

        public void SetIndex(int p_Slot, long p_Value) => BitConverter.TryWriteBytes(Bytes.AsSpan(c_IndexOffset + p_Slot * 8, 8), p_Value);
    }

    public class ShaderEntry
    {
        /// <summary>The lowercase name hash of the shader asset.</summary>
        public uint Key { get; set; }

        /// <summary>Type, flags, bool parameters and streamable textures, up to the solution count.</summary>
        public byte[] Info { get; set; } = [];

        public List<ushort> Solutions { get; set; } = new();
    }

    public class Database
    {
        public uint RenderPathKey { get; set; }
        public uint Version { get; set; }
        public uint RenderPath { get; set; }

        /// <summary>Each with its size field.</summary>
        public List<byte[]> Constants { get; } = new();
        public List<byte[]> ConstantFunctions { get; } = new();
        public List<byte[]> TextureFunctions { get; } = new();
        public List<Permutation> VertexPermutations { get; } = new();
        public List<Permutation> PixelPermutations { get; } = new();
        public List<byte[]> GeometryPermutations { get; } = new();
        public List<Solution> Solutions { get; } = new();

        /// <summary>One per solution, in the same order.</summary>
        public List<byte[]> States { get; } = new();

        public List<(uint Hash, byte[] Desc)> Declarations { get; } = new();
        public List<ShaderEntry> Shaders { get; } = new();

        /// <summary>Whatever follows the shader table.</summary>
        public byte[] Trailing { get; set; } = [];
    }

    private const int c_StateSize = 32;
    private const int c_DeclarationSize = 16 * 4 + 4 * 2 + 4;

    public List<Database> Databases { get; } = new();

    public static ShaderDatabaseImage Read(byte[] p_Data)
    {
        var s_Image = new ShaderDatabaseImage();
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));

        var s_Count = s_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
        {
            var s_Key = s_Reader.ReadUInt32();
            var s_Size = s_Reader.ReadUInt32();
            var s_End = s_Reader.Position + s_Size;
            s_Image.Databases.Add(ReadDatabase(s_Reader, s_Key, s_End));
            s_Reader.Seek(s_End, SeekOrigin.Begin);
        }

        return s_Image;
    }

    private static Database ReadDatabase(RimeReader p_Reader, uint p_Key, long p_End)
    {
        var s_Database = new Database { RenderPathKey = p_Key, Version = p_Reader.ReadUInt32(), RenderPath = p_Reader.ReadUInt32() };
        if (s_Database.Version != 182)
            throw new Exception($"Unsupported shader database version (expected 182 got {s_Database.Version}).");

        var s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
        {
            var s_Size = p_Reader.ReadUInt32();
            p_Reader.Seek(-4, SeekOrigin.Current);
            s_Database.Constants.Add(p_Reader.ReadBytes((int)s_Size));
        }

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.ConstantFunctions.Add(Slice(p_Reader, p_R =>
            {
                var s_Constants = p_R.ReadUInt16();
                p_R.ReadUInt16();
                p_R.Seek(s_Constants * 8, SeekOrigin.Current);
            }));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.TextureFunctions.Add(Slice(p_Reader, p_R => p_R.Seek(p_R.ReadUInt32() * 4, SeekOrigin.Current)));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.VertexPermutations.Add(ReadPermutation(p_Reader, true));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.PixelPermutations.Add(ReadPermutation(p_Reader, false));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.GeometryPermutations.Add(Slice(p_Reader, p_R =>
            {
                p_R.Seek(16, SeekOrigin.Current);
                p_R.Seek(p_R.ReadUInt32() + 4, SeekOrigin.Current);
            }));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.Solutions.Add(new Solution { Bytes = p_Reader.ReadBytes(Solution.Size) });

        s_Count = p_Reader.ReadUInt32();
        if (s_Count != s_Database.Solutions.Count)
            throw new Exception($"Solution state count {s_Count} doesn't match solution count {s_Database.Solutions.Count}.");
        for (var i = 0; i < s_Count; i++)
            s_Database.States.Add(p_Reader.ReadBytes(c_StateSize));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
            s_Database.Declarations.Add((p_Reader.ReadUInt32(), p_Reader.ReadBytes(c_DeclarationSize)));

        s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
        {
            var s_Shader = new ShaderEntry { Key = p_Reader.ReadUInt32() };
            s_Shader.Info = Slice(p_Reader, p_R =>
            {
                p_R.Seek(4 + 4 + 8 * 4, SeekOrigin.Current);

                var s_Textures = p_R.ReadUInt32();
                for (var t = 0; t < s_Textures; t++)
                {
                    p_R.ReadNullTerminatedString();
                    p_R.Seek(12, SeekOrigin.Current);
                }

                var s_External = p_R.ReadUInt32();
                for (var t = 0; t < s_External; t++)
                {
                    p_R.ReadNullTerminatedString();
                    p_R.Seek(16, SeekOrigin.Current);
                }
            });

            var s_Solutions = p_Reader.ReadUInt32();
            for (var j = 0; j < s_Solutions; j++)
                s_Shader.Solutions.Add(p_Reader.ReadUInt16());

            s_Database.Shaders.Add(s_Shader);
        }

        s_Database.Trailing = p_Reader.ReadBytes((int)(p_End - p_Reader.Position));
        return s_Database;
    }

    private static Permutation ReadPermutation(RimeReader p_Reader, bool p_Vertex)
    {
        var s_Permutation = new Permutation
        {
            Head = Slice(p_Reader, p_R =>
            {
                p_R.Seek(16, SeekOrigin.Current);
                p_R.Seek(p_R.ReadUInt32(), SeekOrigin.Current);
            }),
            Constant = p_Reader.ReadUInt32(),
            ConstantFunction = p_Reader.ReadUInt32(),
            TextureFunction = p_Reader.ReadUInt32(),
        };

        s_Permutation.Tail = Slice(p_Reader, p_R =>
        {
            if (p_Vertex)
            {
                p_R.Seek(p_R.ReadInt32(), SeekOrigin.Current);
                p_R.Seek(p_R.ReadUInt32() * 24, SeekOrigin.Current);
                var s_Names = p_R.ReadUInt32();
                for (var i = 0; i < s_Names; i++)
                    p_R.ReadNullTerminatedString();
            }

            p_R.ReadUInt32();
        });

        return s_Permutation;
    }

    /// <summary>The bytes a skip over the record covers.</summary>
    private static byte[] Slice(RimeReader p_Reader, Action<RimeReader> p_Skip)
    {
        var s_Start = p_Reader.Position;
        p_Skip(p_Reader);
        var s_End = p_Reader.Position;
        p_Reader.Seek(s_Start, SeekOrigin.Begin);
        return p_Reader.ReadBytes((int)(s_End - s_Start));
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

    private static byte[] WriteDatabase(Database p_Database)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        s_Writer.Write(p_Database.Version);
        s_Writer.Write(p_Database.RenderPath);

        WriteAll(s_Writer, p_Database.Constants);
        WriteAll(s_Writer, p_Database.ConstantFunctions);
        WriteAll(s_Writer, p_Database.TextureFunctions);

        foreach (var s_Permutations in new[] { p_Database.VertexPermutations, p_Database.PixelPermutations })
        {
            s_Writer.Write((uint)s_Permutations.Count);
            foreach (var s_Permutation in s_Permutations)
            {
                s_Writer.Write(s_Permutation.Head);
                s_Writer.Write(s_Permutation.Constant);
                s_Writer.Write(s_Permutation.ConstantFunction);
                s_Writer.Write(s_Permutation.TextureFunction);
                s_Writer.Write(s_Permutation.Tail);
            }
        }

        WriteAll(s_Writer, p_Database.GeometryPermutations);

        s_Writer.Write((uint)p_Database.Solutions.Count);
        foreach (var s_Solution in p_Database.Solutions)
            s_Writer.Write(s_Solution.Bytes);

        WriteAll(s_Writer, p_Database.States);

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

    private static void WriteAll(RimeWriter p_Writer, List<byte[]> p_Records)
    {
        p_Writer.Write((uint)p_Records.Count);
        foreach (var s_Record in p_Records)
            p_Writer.Write(s_Record);
    }
}
