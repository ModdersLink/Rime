using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Texture;
using RimeLib.Texture.Frostbite;

namespace RimeLib.Cmd.Contexts
{
    public class GameContext : ExecutionContext
    {
        protected int m_Id;
        protected IEngineMounter m_Mounter;

        public GameContext(BaseContext p_Parent, int p_Id, IEngineMounter p_Mounter)
        {
            Parent = p_Parent;
            m_Id = p_Id;
            m_Mounter = p_Mounter;

            RegisterCommand<ListSbCommand>();
            RegisterCommand<MountSbCommand>();
            RegisterCommand<ListMountedSbCommand>();
            RegisterCommand<ListBundlesCommand>();
            RegisterCommand<MountBundleCommand>();
            RegisterCommand<MountAllBundlesCommand>();
            RegisterCommand<ListMountedBundlesCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<ListDuplicateChunksCommand>();
            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<ListPartitionsCommand>();
            RegisterCommand<ListBundleChunksCommand>();
            RegisterCommand<ListBundleResourcesCommand>();
            RegisterCommand<ListBundlePartitionsCommand>();
            RegisterCommand<DumpChunkCommand>();
            RegisterCommand<DumpResourceCommand>();
            RegisterCommand<DumpPartitionCommand>();
            RegisterCommand<DumpTextureCommand>();

#if DEBUG
            RegisterCommand<DebugVerifyTexturesBitCount>();
#endif

        }

        public override string GetShortDescription()
        {
            return $"{m_Id} - {m_Mounter.GetGamePath()} - {m_Mounter.GetEngineType()}";
        }

        public override string GetLongDescription()
        {
            var s_Text = "Mounted Game Context\n\n";
            s_Text += $"Game ID: {m_Id}\n";
            s_Text += $"Game Path: {m_Mounter.GetGamePath()}\n";
            s_Text += $"Game Engine: {m_Mounter.GetEngineType()}";
            return s_Text;
        }

        internal void MountSuperbundle(string p_Name, bool p_AutoMount)
        {
            m_Mounter.MountSuperbundle(p_Name, p_AutoMount).Wait();
        }

        internal void MountBundle(string p_Name)
        {
            m_Mounter.MountBundle(p_Name).Wait();
        }

        internal IEnumerable<string> GetAvailableSuperbundles()
        {
            return m_Mounter.GetAvailableSuperbundles();
        }

        internal IEnumerable<string> GetAvailableBundles()
        {
            return m_Mounter.GetAvailableBundles();
        }

        internal IEnumerable<string> GetMountedSuperbundles()
        {
            return m_Mounter.GetMountedSuperbundles();
        }

        internal IEnumerable<string> GetMountedBundles()
        {
            return m_Mounter.GetMountedBundles();
        }




        internal void DumpChunk(GUID p_Guid, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetChunk(p_Guid, out var s_Chunk))
                throw new Exception($"Could not find chunk with id '{p_Guid.ToString("D")}'.");

            using var s_Reader = s_Chunk!.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal void DumpResource(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            using var s_Reader = s_Resource!.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal void DumpTexture(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            if( !TextureHelper.LoadTexture( m_Mounter, s_Resource!.FirstVariant, out var s_Texture) )
                throw new Exception($"Could not load resource with name '{p_Name}'.");

            using var s_FileStream = File.Create(p_Destination.FullName);

            var s_TextureFileHandler = TextureFileHandlerRegistry.FindHandler("dds");

            s_TextureFileHandler?.Save(s_Texture!, new RimeWriter(s_FileStream));
            //DDSExporter.WriteTextureToStream(new IO.RimeWriter(s_FileStream), s_Texture!);
        }


#if DEBUG
        internal void Debug_VerifyBitCount(TextWriter p_Writer)
        {

            var s_FoundList = new Dictionary<TextureFormat,TextureFormat>();
            foreach (var s_Resource in m_Mounter.GetResources())
            {
                if (s_Resource.Value.FirstVariant.GetResourceType() != Content.Frostbite.ResourceType.DxTexture &&
                    s_Resource.Value.FirstVariant.GetResourceType() != Content.Frostbite.ResourceType.Ps3Texture &&
                    s_Resource.Value.FirstVariant.GetResourceType() != Content.Frostbite.ResourceType.XenonTexture)
                    continue;

                if (!TextureHelper.LoadTexture(m_Mounter, s_Resource.Value.FirstVariant, out var s_Texture))
                {
                    p_Writer.WriteLine($"Could not load resource with name '{s_Resource.Key}'.");
                    continue;
                }

                if (s_FoundList.TryGetValue(s_Texture!.Format, out var _))
                    continue;


                if (s_Texture!.MipmapCount < 1)
                    continue;

                throw new NotImplementedException();
                // TODO: fix the code below
                //TextureUtils.ComputePitch(s_Texture!.Format, s_Texture!.Width, s_Texture!.Height, out var _, out var s_SlicePitch);

                //if (s_Texture!.GetMipmapSize(0) == s_SlicePitch)
                //    continue;

                
                

                //p_Writer.WriteLine($"Texture with format {s_Texture!.Format} W:H {s_Texture!.Width}:{s_Texture!.Height} has invalid bit size! Generated {s_SlicePitch} but original has {s_Texture!.GetMipmapSize(0)}");


                //TextureUtils.ComputePitch(s_Texture!.Format, s_Texture!.Width, s_Texture!.Height, out var _, out var _);


                //s_FoundList[s_Texture!.Format] = s_Texture!.Format;
            }
        }
#endif

        internal void DumpPartition(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Partition))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            using var s_Reader = s_Partition!.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal IEnumerable<GUID> GetBundleChunks(string p_Bundle)
        {
            return m_Mounter.GetChunksInBundle(p_Bundle);
        }

        internal IEnumerable<string> GetBundleResources(string p_Bundle)
        {
            return m_Mounter.GetResourcesInBundle(p_Bundle);
        }

        internal IEnumerable<string> GetBundlePartitions(string p_Bundle)
        {
            return m_Mounter.GetPartitionsInBundle(p_Bundle);
        }

        internal IEnumerable<GUID> GetMountedChunks()
        {
            return m_Mounter.GetChunks().Keys;
        }

        internal IEnumerable<string> GetMountedResources()
        {
            return m_Mounter.GetResources().Keys;
        }

        internal IEnumerable<string> GetMountedPartitions()
        {
            return m_Mounter.GetPartitions().Keys;
        }

        internal IReadOnlyDictionary<GUID, IMountedObject<IChunkVariant>> GetMountedChunkVariations()
        {
            return m_Mounter.GetChunks();
        }
    }
}
