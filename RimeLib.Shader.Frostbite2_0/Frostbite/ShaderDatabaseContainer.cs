using RimeLib.IO;
using System.Collections.Generic;
using System.IO;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderDatabaseContainer
{
    public Dictionary<ShaderRenderPath, ShaderDatabase> Databases { get; set; } = new();

    public ShaderDatabaseContainer()
    {
    }

    public ShaderDatabaseContainer(RimeReader p_Reader)
    {
        var s_ShaderRenderPaths = p_Reader.ReadUInt32();

        for (var i = 0; i < s_ShaderRenderPaths; i++)
        {
            var s_ShaderPath = p_Reader.ReadUInt32();
            var s_ShaderDbSize = p_Reader.ReadUInt32();

            var s_CurrentPosition = p_Reader.BaseStream.Position;

            using (var s_LimitedStream = new LimitedRimeReader(p_Reader, s_ShaderDbSize))
                Databases.Add((ShaderRenderPath) s_ShaderPath, new ShaderDatabase(s_LimitedStream));

            p_Reader.Seek(s_CurrentPosition + s_ShaderDbSize, SeekOrigin.Begin);
        }
    }
}