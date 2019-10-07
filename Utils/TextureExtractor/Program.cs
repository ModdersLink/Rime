using RimeLib.Content.Mounting;
using RimeLib.Content.Resource;
using RimeLib.Frostbite;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace TextureExtractor
{
    class Program
    {
        static void Main( string[] p_Args )
        {
            // Load the venice support assembly.
            Assembly.Load( "RimeLib.Content.Venice" );
            Assembly.Load( "RimeLib.Texture.Venice" );

            var s_Thing = MountContent( );
            s_Thing.Wait( );
            GC.Collect( );
            Debug.WriteLine( "Done!" );
        }

        static async Task MountContent( )
        {
            var s_Mounter = EngineMounterRegistry.Create( EngineType.Frostbite2_0 );

            await s_Mounter.Mount( @"F:\Program Files (x86)\Origin Games\Battlefield 3", true );


            IMountedObject<IResourceVariant> s_Texture = null;

            if ( !s_Mounter.TryGetResource( "weapons/textures/urbancamo02_d", out s_Texture ) )
            {
                Console.WriteLine( "Error finding texture!" );
                return;
            }

            if ( s_Texture.FirstVariant == null )
            {
                Console.WriteLine( "Error finding texture stuff!" );
                return;
            }

            IResource s_TextureResoruce = null;

            if ( !ResourceHelper.LoadResource( s_Mounter, s_Texture.FirstVariant, out s_TextureResoruce ) )
            {
                Console.WriteLine( "Error loading texture" );
                return;
            }


            Console.WriteLine( "Done here" );
        }
    }
}
