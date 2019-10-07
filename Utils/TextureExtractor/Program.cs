using RimeLib.Content.Mounting;
using RimeLib.Content.Resource;
using RimeLib.Frostbite;
using RimeLib.Texture.Frostbite;
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
            Assembly.Load( "RimeLib.Content.Frostbite2_0" );
            Assembly.Load( "RimeLib.Texture.Frostbite2_0" );

            var s_Thing = MountContent( );
            s_Thing.Wait( );
            GC.Collect( );
            Debug.WriteLine( "Done!" );
        }

        static async Task MountContent( )
        {
            var s_Mounter = EngineMounterRegistry.Create( EngineType.Frostbite2_0 );

            await s_Mounter.Mount( @"F:\Program Files (x86)\Origin Games\Battlefield 3", true );


            SaveTexture( s_Mounter, "weapons/textures/urbancamo02_d", @"F:\bf3\urbancamo.dds" );
            SaveTexture( s_Mounter, "xp4/_commontextures/wood_01_d", @"F:\bf3\wood.dds" );
           
            SaveTexture( s_Mounter, "XP2/Objects/Kitchen/Kitchen_cubemap", @"F:\bf3\testcubetexture.dds" );
            SaveTexture( s_Mounter, "xp2/commontextures/skybarbackdrop_atlas_01_m", @"F:\bf3\skybardrop.dds" );


            Console.WriteLine( "Done here" );
        }





        static bool SaveTexture(  IEngineMounter p_Engine, string p_GamePath, string p_SavePath )
        {
            IMountedObject<IResourceVariant> s_TextureObject = null;

            if ( !p_Engine.TryGetResource( p_GamePath, out s_TextureObject ) )
            {
                Console.WriteLine( "Error finding texture!" );
                return false;
            }

            Console.WriteLine( $"SB: {s_TextureObject.FirstVariant.GetContainedSuperbundle( )}\n B: {s_TextureObject.FirstVariant.GetContainedBundle( )}\n\n" );

            IResource s_TextureResoruce = null;

            if ( !ResourceHelper.LoadResource( p_Engine, s_TextureObject.FirstVariant, out s_TextureResoruce ) )
            {
                Console.WriteLine( "Error loading texture" );
                return false;
            }


            var s_Texture = s_TextureResoruce as ITexture;

            if ( s_Texture == null )
            {
                Console.WriteLine( "Resource is not a texture?!" );
                return false;
            }

            return FBTextureSaver.SaveTexture( s_Texture, p_SavePath );
        }
    }
}
