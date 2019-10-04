using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Content.Venice.Mounting
{
    public class EngineMounterFactory : IEngineMounterFactory
    {
        public EngineType GetSupportedEngine()
        {
            return EngineType.Frostbite2_0;
        }

        public IEngineMounter Create()
        {
            return new EngineMounter();
        }
    }
}
