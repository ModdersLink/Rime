using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderProgramDatabaseContainer
{
    private readonly Dictionary<ShaderRenderPath, ShaderProgramDatabase> m_Databases = new();
    
    public ShaderProgramDatabaseContainer(RimeReader p_Reader)
    {
        var s_Endianness = p_Reader.Endianness;
        p_Reader.Endianness = Endianness.LittleEndian;
        
        var s_PathCount = p_Reader.ReadUInt32();

        for (var s_PathIdx = 0; s_PathIdx < s_PathCount; ++s_PathIdx)
        {
            var s_RenderPath = p_Reader.ReadInt32();
            var s_Size = p_Reader.ReadInt32();

            var s_Database = new ShaderProgramDatabase();

            for (var s_Stage = ShaderStageType.ShaderStageType_Vertex;
                 s_Stage < ShaderStageType.ShaderStageTypeCount;
                 ++s_Stage)
            {
                var s_ShaderCount = p_Reader.ReadUInt32();
                
                for (var s_ShaderIdx = 0; s_ShaderIdx < s_ShaderCount; ++s_ShaderIdx)
                {
                    var s_Name = p_Reader.ReadNullTerminatedString();
                    var s_ShaderSize = p_Reader.ReadInt32();

                    var s_ShaderCode = p_Reader.ReadBytes(s_ShaderSize);

                    GeometryDeclarationDesc? s_Desc = null;

                    if (s_Stage == ShaderStageType.ShaderStageType_Vertex)
                        s_Desc = new GeometryDeclarationDesc(p_Reader);
                    
                    s_Database.AddOrUpdateShader(s_Stage, s_Name, new ShaderProgramDatabase.ShaderInfo()
                    {
                        Data = s_ShaderCode,
                        GeometryDeclarationDesc = s_Desc,
                    });
                }
            }

            for (var s_Program = ShaderProgram.ShaderProgram_DebugRender_Font2d; s_Program < ShaderProgram.ShaderProgramCount; ++s_Program)
            {
                var s_ProgramInfo = new ShaderProgramDatabase.ProgramInfo()
                {
                    PermutationCounts = new ushort[6],
                    PermutationOffsets = new ushort[6],
                };

                for (var i = 0; i < 6; ++i)
                    s_ProgramInfo.PermutationCounts[i] = p_Reader.ReadUInt16();

                for (var i = 0; i < 6; ++i)
                    s_ProgramInfo.PermutationOffsets[i] = p_Reader.ReadUInt16();

                s_Database.SetProgramInfo(s_Program, s_ProgramInfo);
            }

            var s_Permutations = new List<ShaderProgramDatabase.Permutation>();

            var s_PermutationCount = p_Reader.ReadUInt32();

            for (var j = 0; j < s_PermutationCount; ++j)
            {
                var s_Mask = p_Reader.ReadUInt32();
                var s_Index = p_Reader.ReadUInt32();
                
                s_Permutations.Add(new ShaderProgramDatabase.Permutation()
                {
                    Mask = s_Mask,
                    Index = s_Index,
                });
            }

            s_Database.Permutations = s_Permutations;

            m_Databases.Add((ShaderRenderPath)s_RenderPath, s_Database);
        }
        
        p_Reader.Endianness = s_Endianness;
    }

    public bool TryGetDatabase(ShaderRenderPath p_Path, [NotNullWhen(true)] out ShaderProgramDatabase? p_Database)
    {
        lock (m_Databases)
        {
            return m_Databases.TryGetValue(p_Path, out p_Database);
        }
    }

    public void AddOrUpdateDatabase(ShaderRenderPath p_Path, ShaderProgramDatabase p_Database)
    {
        lock (m_Databases)
        {
            m_Databases[p_Path] = p_Database;
        }
    }
}