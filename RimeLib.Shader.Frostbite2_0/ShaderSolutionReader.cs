using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;

namespace RimeLib.Shader.Frostbite2_0;

/// <summary>The solutions of this engine's shader databases.</summary>
public class ShaderSolutionReader : IShaderSolutionReader
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlyList<ShaderSolutionPixel> GetPixelShaders(byte[] p_Database, uint p_Key)
    {
        var s_Container = new ShaderDatabaseContainer();
        s_Container.Deserialize(p_Database);

        var s_Result = new List<ShaderSolutionPixel>();
        foreach (var (s_Path, s_Database) in s_Container.Databases)
        {
            var s_Info = s_Database.ShaderInfos.FirstOrDefault(p_I => p_I.Key == p_Key);
            if (s_Info == null)
                continue;

            for (var i = 0; i < s_Info.Solutions.Length; i++)
            {
                if (s_Info.Solutions[i].PixelPermutation?.ShaderBytecode is { Length: > 0 } s_Bytecode)
                    s_Result.Add(new ShaderSolutionPixel(s_Path.ToString(), i, s_Bytecode));
            }
        }

        return s_Result;
    }
}
