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
	[ContainerType(4)]
	public class SoundPatchConfigurationAssetEntry : 
		SoundPatchConfigurationEntry
	{
		protected uint m_NameHash = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(994057744)]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("SoundPatchConfigurationAssetEntry." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0x8 (8)
		
		protected CtrRef<Asset> m_Value = new CtrRef<Asset>();
		[ContainerField(12), ContainerFieldNameHash(225375086)]
		public CtrRef<Asset> Value { get { return m_Value; } set { if (OnPropertyChanging("SoundPatchConfigurationAssetEntry." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 225375086:
					Value = (CtrRef<Asset>) p_Value;
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
				case 994057744:
					return NameHash;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 994057744:
					return typeof(SoundPatchConfigurationAssetEntry).GetProperty(nameof(NameHash));

				case 225375086:
					return typeof(SoundPatchConfigurationAssetEntry).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
