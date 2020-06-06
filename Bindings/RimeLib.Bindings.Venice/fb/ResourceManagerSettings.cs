///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ResourceManagerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int CasBundleReadBufferSizeKb { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int CasBundleDecompressBufferSizeKb { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int CasBundleDecompressBufferCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool BundleProfilingEnable { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool SPUDecompressEnable { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1627350526:
					CasBundleReadBufferSizeKb = (int) p_Value;
					break;

				case 4137626923:
					CasBundleDecompressBufferSizeKb = (int) p_Value;
					break;

				case 2318797924:
					CasBundleDecompressBufferCount = (int) p_Value;
					break;

				case 2207788158:
					BundleProfilingEnable = (bool) p_Value;
					break;

				case 2656801749:
					SPUDecompressEnable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1627350526:
					return CasBundleReadBufferSizeKb;

				case 4137626923:
					return CasBundleDecompressBufferSizeKb;

				case 2318797924:
					return CasBundleDecompressBufferCount;

				case 2207788158:
					return BundleProfilingEnable;

				case 2656801749:
					return SPUDecompressEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1627350526:
					return typeof(ResourceManagerSettings).GetProperty(nameof(CasBundleReadBufferSizeKb));

				case 4137626923:
					return typeof(ResourceManagerSettings).GetProperty(nameof(CasBundleDecompressBufferSizeKb));

				case 2318797924:
					return typeof(ResourceManagerSettings).GetProperty(nameof(CasBundleDecompressBufferCount));

				case 2207788158:
					return typeof(ResourceManagerSettings).GetProperty(nameof(BundleProfilingEnable));

				case 2656801749:
					return typeof(ResourceManagerSettings).GetProperty(nameof(SPUDecompressEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
