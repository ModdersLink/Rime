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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VeniceUIConfiguration : 
		Asset
	{
		protected string m_MetaDataAssetPath = string.Empty;
		[ContainerField(Name: "MetaDataAssetPath", Offset: 12, NameHash: 1169897301, Flags: 16509), LayoutImmutable]
		public string MetaDataAssetPath { get { return m_MetaDataAssetPath; } set { if (OnPropertyChanging("VeniceUIConfiguration." + nameof(MetaDataAssetPath), this, m_MetaDataAssetPath, value)) m_MetaDataAssetPath = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1169897301:
					MetaDataAssetPath = (string) p_Value;
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
				case 1169897301:
					return MetaDataAssetPath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1169897301:
					return typeof(VeniceUIConfiguration).GetProperty(nameof(MetaDataAssetPath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
