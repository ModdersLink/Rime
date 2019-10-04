using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace ContentExtractor
{
    class Program
    {
        static void Main(string[] p_Args)
        {
            // Load the venice support assembly.
            Assembly.Load("RimeLib.Content.Venice");

            var s_Thing = MountContent();
            s_Thing.Wait();
            GC.Collect();
            Debug.WriteLine("Done!");
        }

        static async Task MountContent()
        {
            var s_Mounter = EngineMounterRegistry.Create(EngineType.Frostbite2_0);

            await s_Mounter.Mount(@"C:\Games\Battlefield 3", true);
            
            foreach (var s_Bundle in s_Mounter.GetAvailableSuperbundles())
                Console.WriteLine(s_Bundle);

            foreach (var s_Bundle in s_Mounter.GetAvailableBundles())
                Console.WriteLine(s_Bundle);

            Console.WriteLine("Done here");
        }
    }
}
