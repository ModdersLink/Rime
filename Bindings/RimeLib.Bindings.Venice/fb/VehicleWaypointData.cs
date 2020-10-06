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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class VehicleWaypointData : 
		WaypointData
	{
		protected float m_Speed = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(230887042)]
		public float Speed { get { return m_Speed; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(Speed), this, m_Speed, value)) m_Speed = value; } } // 0x10 (16)
		
		protected float m_SpeedOverrideMovingTowards = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4149709546)]
		public float SpeedOverrideMovingTowards { get { return m_SpeedOverrideMovingTowards; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(SpeedOverrideMovingTowards), this, m_SpeedOverrideMovingTowards, value)) m_SpeedOverrideMovingTowards = value; } } // 0x14 (20)
		
		protected float m_Angleoffset = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(686454889)]
		public float Angleoffset { get { return m_Angleoffset; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(Angleoffset), this, m_Angleoffset, value)) m_Angleoffset = value; } } // 0x18 (24)
		
		protected float m_StopHereRadius = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3378547103)]
		public float StopHereRadius { get { return m_StopHereRadius; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(StopHereRadius), this, m_StopHereRadius, value)) m_StopHereRadius = value; } } // 0x1C (28)
		
		protected float m_StoppingDeceleration = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2524085644)]
		public float StoppingDeceleration { get { return m_StoppingDeceleration; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(StoppingDeceleration), this, m_StoppingDeceleration, value)) m_StoppingDeceleration = value; } } // 0x20 (32)
		
		protected float m_MinSlowdownSpeed = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3207717373)]
		public float MinSlowdownSpeed { get { return m_MinSlowdownSpeed; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(MinSlowdownSpeed), this, m_MinSlowdownSpeed, value)) m_MinSlowdownSpeed = value; } } // 0x24 (36)
		
		protected bool m_StopHere = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3655484487)]
		public bool StopHere { get { return m_StopHere; } set { if (OnPropertyChanging("VehicleWaypointData." + nameof(StopHere), this, m_StopHere, value)) m_StopHere = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230887042:
					Speed = (float) p_Value;
					break;

				case 4149709546:
					SpeedOverrideMovingTowards = (float) p_Value;
					break;

				case 686454889:
					Angleoffset = (float) p_Value;
					break;

				case 3378547103:
					StopHereRadius = (float) p_Value;
					break;

				case 2524085644:
					StoppingDeceleration = (float) p_Value;
					break;

				case 3207717373:
					MinSlowdownSpeed = (float) p_Value;
					break;

				case 3655484487:
					StopHere = (bool) p_Value;
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
				case 230887042:
					return Speed;

				case 4149709546:
					return SpeedOverrideMovingTowards;

				case 686454889:
					return Angleoffset;

				case 3378547103:
					return StopHereRadius;

				case 2524085644:
					return StoppingDeceleration;

				case 3207717373:
					return MinSlowdownSpeed;

				case 3655484487:
					return StopHere;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230887042:
					return typeof(VehicleWaypointData).GetProperty(nameof(Speed));

				case 4149709546:
					return typeof(VehicleWaypointData).GetProperty(nameof(SpeedOverrideMovingTowards));

				case 686454889:
					return typeof(VehicleWaypointData).GetProperty(nameof(Angleoffset));

				case 3378547103:
					return typeof(VehicleWaypointData).GetProperty(nameof(StopHereRadius));

				case 2524085644:
					return typeof(VehicleWaypointData).GetProperty(nameof(StoppingDeceleration));

				case 3207717373:
					return typeof(VehicleWaypointData).GetProperty(nameof(MinSlowdownSpeed));

				case 3655484487:
					return typeof(VehicleWaypointData).GetProperty(nameof(StopHere));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
