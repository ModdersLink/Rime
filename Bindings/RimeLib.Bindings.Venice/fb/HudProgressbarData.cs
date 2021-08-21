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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class HudProgressbarData : 
		UIPartData
	{
		protected ProgressType m_ProgressType = new ProgressType();
		[ContainerField(Name: "ProgressType", Offset: 8, NameHash: 1938381824, Flags: 137)]
		public ProgressType ProgressType { get { return m_ProgressType; } set { if (OnPropertyChanging("HudProgressbarData." + nameof(ProgressType), this, m_ProgressType, value)) m_ProgressType = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1938381824:
					ProgressType = (ProgressType) Enum.ToObject(typeof(ProgressType), p_Value);
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
				case 1938381824:
					return ProgressType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1938381824:
					return typeof(HudProgressbarData).GetProperty(nameof(ProgressType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
