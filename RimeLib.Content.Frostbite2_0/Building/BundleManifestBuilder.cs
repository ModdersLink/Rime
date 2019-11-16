using System;
using System.Linq;
using RimeLib.Content.Building;

namespace RimeLib.Content.Frostbite2_0.Building
{
    public class BundleManifestBuilder
    {
        public BundleManifestBuilder(BundleDescriptor p_Descriptor)
        {
            if (p_Descriptor.Chunks.Any())
                throw new Exception("Creating bundles with chunks in them is not currently supported. Please add these chunks to the superbundle instead.");


        }
    }
}
