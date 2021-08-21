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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class UIMinimapVolumeEntityData : 
		GameEntityData
	{
		protected CtrRef<Asset> m_Asset = new CtrRef<Asset>();
		[ContainerField(Name: "Asset", Offset: 96, NameHash: 205976053, Flags: 53)]
		public CtrRef<Asset> Asset { get { return m_Asset; } set { if (OnPropertyChanging("UIMinimapVolumeEntityData." + nameof(Asset), this, m_Asset, value)) m_Asset = value; } } // 0x60 (96)
		
		protected bool m_IsDefault = new bool();
		[ContainerField(Name: "IsDefault", Offset: 100, NameHash: 2802724276, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDefault { get { return m_IsDefault; } set { if (OnPropertyChanging("UIMinimapVolumeEntityData." + nameof(IsDefault), this, m_IsDefault, value)) m_IsDefault = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205976053:
					Asset = (CtrRef<Asset>) p_Value;
					break;

				case 2802724276:
					IsDefault = (bool) p_Value;
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
				case 205976053:
					return Asset;

				case 2802724276:
					return IsDefault;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205976053:
					return typeof(UIMinimapVolumeEntityData).GetProperty(nameof(Asset));

				case 2802724276:
					return typeof(UIMinimapVolumeEntityData).GetProperty(nameof(IsDefault));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
