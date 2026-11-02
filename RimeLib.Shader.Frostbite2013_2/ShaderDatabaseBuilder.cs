using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2013_2.Frostbite;
using RimeLib.Shader.Pooled;

namespace RimeLib.Shader.Frostbite2013_2;

public class ShaderDatabaseBuilder : PooledShaderDatabaseBuilder
{
    protected override PooledShaderDatabaseFormat Format => ShaderDatabaseFormat.Instance;

    public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

    // mp_siege's main bundle carries the 438 shaders only its sub-worlds draw with.
    public override bool ShipsEveryShader => true;
}
