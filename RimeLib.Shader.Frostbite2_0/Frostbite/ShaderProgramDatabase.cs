using System.Diagnostics;
using fb;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderProgramDatabase
{
    public ShaderProgramDatabase(RimeReader p_Reader)
    {
        var s_Endianness = p_Reader.Endianness;
        p_Reader.Endianness = Endianness.LittleEndian;
        
        var s_PathCount = p_Reader.ReadUInt32();

        for (var i = 0; i < s_PathCount; ++i)
        {
            var s_RenderPath = p_Reader.ReadInt32();
            var s_Size = p_Reader.ReadInt32();

            for (var s_Stage = ShaderStageType.ShaderStageType_Vertex;
                 s_Stage < ShaderStageType.ShaderStageTypeCount;
                 ++s_Stage)
            {
                var s_ShaderCount = p_Reader.ReadUInt32();
                
                Debug.WriteLine($"Found {s_ShaderCount} for stage {s_Stage}.");

                for (var j = 0; j < s_ShaderCount; ++j)
                {
                    var s_Name = p_Reader.ReadNullTerminatedString();
                    var s_ShaderSize = p_Reader.ReadInt32();
                    
                    Debug.WriteLine($"[{j} / {s_ShaderCount}] {s_Stage} shader '{s_Name}' with {s_ShaderSize} bytes.");

                    var s_ShaderCode = p_Reader.ReadBytes(s_ShaderSize);

                    if (s_Stage == ShaderStageType.ShaderStageType_Vertex)
                    {
                        var s_GeometryDeclaration = new GeometryDeclarationDesc(p_Reader);
                    }
                }
            }

            for (var j = 0; j < (int)ShaderProgram.ShaderProgramCount; ++j)
            {
                p_Reader.ReadBytes(24);
            }

            var s_PermutationCount = p_Reader.ReadUInt32();

            for (var j = 0; j < s_PermutationCount; ++j)
            {
                var s_Mask = p_Reader.ReadUInt32();
                var s_Index = p_Reader.ReadUInt32();
            }
        }
        
        p_Reader.Endianness = s_Endianness;
    }
}
