using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Shader.Pooled;

namespace RimeLib.Shader.Frostbite2_0
{
    public class ShaderDatabaseBuilder : PooledShaderDatabaseBuilder
    {
        protected override PooledShaderDatabaseFormat Format => ShaderDatabaseFormat.Instance;

        public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };
    }
}
