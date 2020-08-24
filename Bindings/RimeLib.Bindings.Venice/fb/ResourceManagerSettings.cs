///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class ResourceManagerSettings : 
		SystemSettings
	{
		protected int m_CasBundleReadBufferSizeKb = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1627350526)]
		public int CasBundleReadBufferSizeKb { get { return m_CasBundleReadBufferSizeKb; } set { if (OnPropertyChanging("ResourceManagerSettings." + nameof(CasBundleReadBufferSizeKb), this, m_CasBundleReadBufferSizeKb, value)) m_CasBundleReadBufferSizeKb = value; } } // 0xC (12)
		
		protected int m_CasBundleDecompressBufferSizeKb = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4137626923)]
		public int CasBundleDecompressBufferSizeKb { get { return m_CasBundleDecompressBufferSizeKb; } set { if (OnPropertyChanging("ResourceManagerSettings." + nameof(CasBundleDecompressBufferSizeKb), this, m_CasBundleDecompressBufferSizeKb, value)) m_CasBundleDecompressBufferSizeKb = value; } } // 0x10 (16)
		
		protected int m_CasBundleDecompressBufferCount = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2318797924)]
		public int CasBundleDecompressBufferCount { get { return m_CasBundleDecompressBufferCount; } set { if (OnPropertyChanging("ResourceManagerSettings." + nameof(CasBundleDecompressBufferCount), this, m_CasBundleDecompressBufferCount, value)) m_CasBundleDecompressBufferCount = value; } } // 0x14 (20)
		
		protected bool m_BundleProfilingEnable = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2207788158)]
		public bool BundleProfilingEnable { get { return m_BundleProfilingEnable; } set { if (OnPropertyChanging("ResourceManagerSettings." + nameof(BundleProfilingEnable), this, m_BundleProfilingEnable, value)) m_BundleProfilingEnable = value; } } // 0x18 (24)
		
		protected bool m_SPUDecompressEnable = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2656801749)]
		public bool SPUDecompressEnable { get { return m_SPUDecompressEnable; } set { if (OnPropertyChanging("ResourceManagerSettings." + nameof(SPUDecompressEnable), this, m_SPUDecompressEnable, value)) m_SPUDecompressEnable = value; } } // 0x19 (25)
		
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
