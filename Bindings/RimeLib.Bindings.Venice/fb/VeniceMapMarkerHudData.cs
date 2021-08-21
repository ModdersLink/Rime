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
	public class VeniceMapMarkerHudData : 
		DataContainer
	{
		protected UIHudIcon m_Icon = new UIHudIcon();
		[ContainerField(Name: "Icon", Offset: 8, NameHash: 2088920302, Flags: 137)]
		public UIHudIcon Icon { get { return m_Icon; } set { if (OnPropertyChanging("VeniceMapMarkerHudData." + nameof(Icon), this, m_Icon, value)) m_Icon = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088920302:
					Icon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
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
				case 2088920302:
					return Icon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088920302:
					return typeof(VeniceMapMarkerHudData).GetProperty(nameof(Icon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
