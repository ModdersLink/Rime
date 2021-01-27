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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class EnlightenDataCreatorParams : 
		DataContainer
	{
		protected string m_AssetName = string.Empty;
		[ContainerField(Name: "AssetName", Offset: 8, NameHash: 3654276786, Flags: 16509), LayoutImmutable]
		public string AssetName { get { return m_AssetName; } set { if (OnPropertyChanging("EnlightenDataCreatorParams." + nameof(AssetName), this, m_AssetName, value)) m_AssetName = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3654276786:
					AssetName = (string) p_Value;
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
				case 3654276786:
					return AssetName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3654276786:
					return typeof(EnlightenDataCreatorParams).GetProperty(nameof(AssetName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
