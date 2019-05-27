using System;
using System.Threading.Tasks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace ContentExtractor
{
    class Program
    {
        static void Main(string[] p_Args)
        {
            var s_Thing = MountContent();
            s_Thing.Wait();
        }

        static async Task MountContent()
        {
            var s_Mounter = new ContentMounter(EngineType.Frostbite2_0);

            if (!await s_Mounter.Mount(@"B:\Games\Battlefield 3"))
                throw new Exception("Failed to mount game.");
        }
    }
}
