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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class AdvertisementComponentData : 
		PartComponentData
	{
		protected string m_Identifier = string.Empty;
		[ContainerField(Name: "Identifier", Offset: 112, NameHash: 3512790342, Flags: 16509), LayoutImmutable]
		public string Identifier { get { return m_Identifier; } set { if (OnPropertyChanging("AdvertisementComponentData." + nameof(Identifier), this, m_Identifier, value)) m_Identifier = value; } } // 0x70 (112)
		
		protected string m_AdTexture = string.Empty;
		[ContainerField(Name: "AdTexture", Offset: 116, NameHash: 1084313599, Flags: 16509), LayoutImmutable]
		public string AdTexture { get { return m_AdTexture; } set { if (OnPropertyChanging("AdvertisementComponentData." + nameof(AdTexture), this, m_AdTexture, value)) m_AdTexture = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1084313599:
					AdTexture = (string) p_Value;
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
				case 3512790342:
					return Identifier;

				case 1084313599:
					return AdTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(AdvertisementComponentData).GetProperty(nameof(Identifier));

				case 1084313599:
					return typeof(AdvertisementComponentData).GetProperty(nameof(AdTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
