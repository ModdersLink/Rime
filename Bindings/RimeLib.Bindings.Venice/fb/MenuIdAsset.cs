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
	public class MenuIdAsset : 
		Asset
	{
		protected string m_ShortName = string.Empty;
		[ContainerField(Name: "ShortName", Offset: 12, NameHash: 1803010032, Flags: 16509), LayoutImmutable]
		public string ShortName { get { return m_ShortName; } set { if (OnPropertyChanging("MenuIdAsset." + nameof(ShortName), this, m_ShortName, value)) m_ShortName = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1803010032:
					ShortName = (string) p_Value;
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
				case 1803010032:
					return ShortName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1803010032:
					return typeof(MenuIdAsset).GetProperty(nameof(ShortName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
