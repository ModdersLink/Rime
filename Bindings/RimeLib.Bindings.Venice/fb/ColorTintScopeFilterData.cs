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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class ColorTintScopeFilterData : 
		ScopeFilterData
	{
		protected ColorTintData m_ColorTintData = new ColorTintData();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(1503443055)]
		public ColorTintData ColorTintData { get { return m_ColorTintData; } set { if (OnPropertyChanging("ColorTintScopeFilterData." + nameof(ColorTintData), this, m_ColorTintData, value)) m_ColorTintData = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1503443055:
					ColorTintData = (ColorTintData) p_Value;
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
				case 1503443055:
					return ColorTintData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1503443055:
					return typeof(ColorTintScopeFilterData).GetProperty(nameof(ColorTintData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
