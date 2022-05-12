using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

public class GeometryShaderPermutation
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderBytecode { get; set; } = Array.Empty<byte>();
    public uint InstructionCount { get; set; }
        
    public GeometryShaderPermutation()
    {
    }

    public GeometryShaderPermutation(RimeReader p_Reader)
    {
        Guid = new GUID(p_Reader);

        var s_DataSize = p_Reader.ReadUInt32();
        ShaderBytecode = p_Reader.ReadBytes((int) s_DataSize);

        InstructionCount = p_Reader.ReadUInt32();
    }
}