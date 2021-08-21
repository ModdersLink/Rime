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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class MobilityData : 
		DataContainer
	{
		protected float m_MaxSpeed = new float();
		[ContainerField(Name: "MaxSpeed", Offset: 8, NameHash: 396228950, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("MobilityData." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0x8 (8)
		
		protected bool m_Use3DWaypoints = new bool();
		[ContainerField(Name: "Use3DWaypoints", Offset: 12, NameHash: 184580769, Flags: 49325), LayoutImmutable, Blittable]
		public bool Use3DWaypoints { get { return m_Use3DWaypoints; } set { if (OnPropertyChanging("MobilityData." + nameof(Use3DWaypoints), this, m_Use3DWaypoints, value)) m_Use3DWaypoints = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 184580769:
					Use3DWaypoints = (bool) p_Value;
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
				case 396228950:
					return MaxSpeed;

				case 184580769:
					return Use3DWaypoints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 396228950:
					return typeof(MobilityData).GetProperty(nameof(MaxSpeed));

				case 184580769:
					return typeof(MobilityData).GetProperty(nameof(Use3DWaypoints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
