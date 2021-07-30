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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class TrackWheelComponentData : 
		WheelComponentData
	{
		protected string m_BoneName = string.Empty;
		[ContainerField(Name: "BoneName", Offset: 128, NameHash: 1590647844, Flags: 16509), LayoutImmutable]
		public string BoneName { get { return m_BoneName; } set { if (OnPropertyChanging("TrackWheelComponentData." + nameof(BoneName), this, m_BoneName, value)) m_BoneName = value; } } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1590647844:
					BoneName = (string) p_Value;
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
				case 1590647844:
					return BoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1590647844:
					return typeof(TrackWheelComponentData).GetProperty(nameof(BoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
