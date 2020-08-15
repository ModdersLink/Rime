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
	[ContainerType(4)]
	public class TurretData : 
		DataContainer
	{
		protected float m_PitchP = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(3380975443)]
		public float PitchP { get { return m_PitchP; } set { if (OnPropertyChanging("TurretData." + nameof(PitchP), this, m_PitchP, value)) m_PitchP = value; } } // 0x8 (8)
		
		protected float m_YawP = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2089497178)]
		public float YawP { get { return m_YawP; } set { if (OnPropertyChanging("TurretData." + nameof(YawP), this, m_YawP, value)) m_YawP = value; } } // 0xC (12)
		
		protected float m_FakeShootSpaceMinDistance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4286661422)]
		public float FakeShootSpaceMinDistance { get { return m_FakeShootSpaceMinDistance; } set { if (OnPropertyChanging("TurretData." + nameof(FakeShootSpaceMinDistance), this, m_FakeShootSpaceMinDistance, value)) m_FakeShootSpaceMinDistance = value; } } // 0x10 (16)
		
		protected float m_FakeShootSpaceMaxDistance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1645003312)]
		public float FakeShootSpaceMaxDistance { get { return m_FakeShootSpaceMaxDistance; } set { if (OnPropertyChanging("TurretData." + nameof(FakeShootSpaceMaxDistance), this, m_FakeShootSpaceMaxDistance, value)) m_FakeShootSpaceMaxDistance = value; } } // 0x14 (20)
		
		protected CtrRef<AIAimingConstraintsData> m_AimingConstraints = new CtrRef<AIAimingConstraintsData>();
		[ContainerField(24), ContainerFieldNameHash(1523178198)]
		public CtrRef<AIAimingConstraintsData> AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("TurretData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3380975443:
					PitchP = (float) p_Value;
					break;

				case 2089497178:
					YawP = (float) p_Value;
					break;

				case 4286661422:
					FakeShootSpaceMinDistance = (float) p_Value;
					break;

				case 1645003312:
					FakeShootSpaceMaxDistance = (float) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (CtrRef<AIAimingConstraintsData>) p_Value;
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
				case 3380975443:
					return PitchP;

				case 2089497178:
					return YawP;

				case 4286661422:
					return FakeShootSpaceMinDistance;

				case 1645003312:
					return FakeShootSpaceMaxDistance;

				case 1523178198:
					return AimingConstraints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3380975443:
					return typeof(TurretData).GetProperty(nameof(PitchP));

				case 2089497178:
					return typeof(TurretData).GetProperty(nameof(YawP));

				case 4286661422:
					return typeof(TurretData).GetProperty(nameof(FakeShootSpaceMinDistance));

				case 1645003312:
					return typeof(TurretData).GetProperty(nameof(FakeShootSpaceMaxDistance));

				case 1523178198:
					return typeof(TurretData).GetProperty(nameof(AimingConstraints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
