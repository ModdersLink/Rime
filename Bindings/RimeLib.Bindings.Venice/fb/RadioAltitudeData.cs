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
	public class RadioAltitudeData : 
		DataContainer
	{
		protected float m_Range = new float();
		[ContainerField(Name: "Range", Offset: 8, NameHash: 230112826, Flags: 49469), LayoutImmutable, Blittable]
		public float Range { get { return m_Range; } set { if (OnPropertyChanging("RadioAltitudeData." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x8 (8)
		
		protected float m_UpdateFrequency = new float();
		[ContainerField(Name: "UpdateFrequency", Offset: 12, NameHash: 219717232, Flags: 49469), LayoutImmutable, Blittable]
		public float UpdateFrequency { get { return m_UpdateFrequency; } set { if (OnPropertyChanging("RadioAltitudeData." + nameof(UpdateFrequency), this, m_UpdateFrequency, value)) m_UpdateFrequency = value; } } // 0xC (12)
		
		protected CollisionMethodEnum m_CollisionMethod = new CollisionMethodEnum();
		[ContainerField(Name: "CollisionMethod", Offset: 16, NameHash: 2308963620, Flags: 137)]
		public CollisionMethodEnum CollisionMethod { get { return m_CollisionMethod; } set { if (OnPropertyChanging("RadioAltitudeData." + nameof(CollisionMethod), this, m_CollisionMethod, value)) m_CollisionMethod = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230112826:
					Range = (float) p_Value;
					break;

				case 219717232:
					UpdateFrequency = (float) p_Value;
					break;

				case 2308963620:
					CollisionMethod = (CollisionMethodEnum) Enum.ToObject(typeof(CollisionMethodEnum), p_Value);
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
				case 230112826:
					return Range;

				case 219717232:
					return UpdateFrequency;

				case 2308963620:
					return CollisionMethod;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230112826:
					return typeof(RadioAltitudeData).GetProperty(nameof(Range));

				case 219717232:
					return typeof(RadioAltitudeData).GetProperty(nameof(UpdateFrequency));

				case 2308963620:
					return typeof(RadioAltitudeData).GetProperty(nameof(CollisionMethod));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
