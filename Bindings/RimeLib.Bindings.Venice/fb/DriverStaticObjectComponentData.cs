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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class DriverStaticObjectComponentData : 
		DriverComponentData
	{
		protected float m_Acceleration = new float();
		[ContainerField(Name: "Acceleration", Offset: 112, NameHash: 62601415, Flags: 49469), LayoutImmutable, Blittable]
		public float Acceleration { get { return m_Acceleration; } set { if (OnPropertyChanging("DriverStaticObjectComponentData." + nameof(Acceleration), this, m_Acceleration, value)) m_Acceleration = value; } } // 0x70 (112)
		
		protected float m_Deceleration = new float();
		[ContainerField(Name: "Deceleration", Offset: 116, NameHash: 8356516, Flags: 49469), LayoutImmutable, Blittable]
		public float Deceleration { get { return m_Deceleration; } set { if (OnPropertyChanging("DriverStaticObjectComponentData." + nameof(Deceleration), this, m_Deceleration, value)) m_Deceleration = value; } } // 0x74 (116)
		
		protected float m_TurningRadius = new float();
		[ContainerField(Name: "TurningRadius", Offset: 120, NameHash: 4134465344, Flags: 49469), LayoutImmutable, Blittable]
		public float TurningRadius { get { return m_TurningRadius; } set { if (OnPropertyChanging("DriverStaticObjectComponentData." + nameof(TurningRadius), this, m_TurningRadius, value)) m_TurningRadius = value; } } // 0x78 (120)
		
		protected bool m_TurnWhileStill = new bool();
		[ContainerField(Name: "TurnWhileStill", Offset: 124, NameHash: 2034681993, Flags: 49325), LayoutImmutable, Blittable]
		public bool TurnWhileStill { get { return m_TurnWhileStill; } set { if (OnPropertyChanging("DriverStaticObjectComponentData." + nameof(TurnWhileStill), this, m_TurnWhileStill, value)) m_TurnWhileStill = value; } } // 0x7C (124)
		
		protected bool m_AlignWithGroundNormal = new bool();
		[ContainerField(Name: "AlignWithGroundNormal", Offset: 125, NameHash: 387843516, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlignWithGroundNormal { get { return m_AlignWithGroundNormal; } set { if (OnPropertyChanging("DriverStaticObjectComponentData." + nameof(AlignWithGroundNormal), this, m_AlignWithGroundNormal, value)) m_AlignWithGroundNormal = value; } } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 62601415:
					Acceleration = (float) p_Value;
					break;

				case 8356516:
					Deceleration = (float) p_Value;
					break;

				case 4134465344:
					TurningRadius = (float) p_Value;
					break;

				case 2034681993:
					TurnWhileStill = (bool) p_Value;
					break;

				case 387843516:
					AlignWithGroundNormal = (bool) p_Value;
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
				case 62601415:
					return Acceleration;

				case 8356516:
					return Deceleration;

				case 4134465344:
					return TurningRadius;

				case 2034681993:
					return TurnWhileStill;

				case 387843516:
					return AlignWithGroundNormal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 62601415:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(Acceleration));

				case 8356516:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(Deceleration));

				case 4134465344:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(TurningRadius));

				case 2034681993:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(TurnWhileStill));

				case 387843516:
					return typeof(DriverStaticObjectComponentData).GetProperty(nameof(AlignWithGroundNormal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
