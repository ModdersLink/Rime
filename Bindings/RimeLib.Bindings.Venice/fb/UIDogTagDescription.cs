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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class UIDogTagDescription : 
		UIItemDescription
	{
		protected bool m_IgnoreBuild = new bool();
		[ContainerField(Name: "IgnoreBuild", Offset: 16, NameHash: 1608120075, Flags: 49325), LayoutImmutable, Blittable]
		public bool IgnoreBuild { get { return m_IgnoreBuild; } set { if (OnPropertyChanging("UIDogTagDescription." + nameof(IgnoreBuild), this, m_IgnoreBuild, value)) m_IgnoreBuild = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1608120075:
					IgnoreBuild = (bool) p_Value;
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
				case 1608120075:
					return IgnoreBuild;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1608120075:
					return typeof(UIDogTagDescription).GetProperty(nameof(IgnoreBuild));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
