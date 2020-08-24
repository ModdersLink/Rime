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
	public class MissionObjectiveHudData : 
		DataContainer
	{
		protected Vec3 m_CameraPosition = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1421454469)]
		public Vec3 CameraPosition { get { return m_CameraPosition; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(CameraPosition), this, m_CameraPosition, value)) m_CameraPosition = value; } } // 0x10 (16)
		
		protected Vec2 m_HorizontalBoundaries = new Vec2();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2977590629)]
		public Vec2 HorizontalBoundaries { get { return m_HorizontalBoundaries; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(HorizontalBoundaries), this, m_HorizontalBoundaries, value)) m_HorizontalBoundaries = value; } } // 0x20 (32)
		
		protected Vec2 m_VerticalBoundaries = new Vec2();
		[ContainerField(40), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(402891209)]
		public Vec2 VerticalBoundaries { get { return m_VerticalBoundaries; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(VerticalBoundaries), this, m_VerticalBoundaries, value)) m_VerticalBoundaries = value; } } // 0x28 (40)
		
		protected float m_CameraRotation = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2168484520)]
		public float CameraRotation { get { return m_CameraRotation; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(CameraRotation), this, m_CameraRotation, value)) m_CameraRotation = value; } } // 0x30 (48)
		
		protected float m_CameraFov = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1789541379)]
		public float CameraFov { get { return m_CameraFov; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(CameraFov), this, m_CameraFov, value)) m_CameraFov = value; } } // 0x34 (52)
		
		protected float m_CameraLookDistance = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3115939832)]
		public float CameraLookDistance { get { return m_CameraLookDistance; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(CameraLookDistance), this, m_CameraLookDistance, value)) m_CameraLookDistance = value; } } // 0x38 (56)
		
		protected float m_CameraDistance = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3954324415)]
		public float CameraDistance { get { return m_CameraDistance; } set { if (OnPropertyChanging("MissionObjectiveHudData." + nameof(CameraDistance), this, m_CameraDistance, value)) m_CameraDistance = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1421454469:
					CameraPosition = (Vec3) p_Value;
					break;

				case 2977590629:
					HorizontalBoundaries = (Vec2) p_Value;
					break;

				case 402891209:
					VerticalBoundaries = (Vec2) p_Value;
					break;

				case 2168484520:
					CameraRotation = (float) p_Value;
					break;

				case 1789541379:
					CameraFov = (float) p_Value;
					break;

				case 3115939832:
					CameraLookDistance = (float) p_Value;
					break;

				case 3954324415:
					CameraDistance = (float) p_Value;
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
				case 1421454469:
					return CameraPosition;

				case 2977590629:
					return HorizontalBoundaries;

				case 402891209:
					return VerticalBoundaries;

				case 2168484520:
					return CameraRotation;

				case 1789541379:
					return CameraFov;

				case 3115939832:
					return CameraLookDistance;

				case 3954324415:
					return CameraDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1421454469:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(CameraPosition));

				case 2977590629:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(HorizontalBoundaries));

				case 402891209:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(VerticalBoundaries));

				case 2168484520:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(CameraRotation));

				case 1789541379:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(CameraFov));

				case 3115939832:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(CameraLookDistance));

				case 3954324415:
					return typeof(MissionObjectiveHudData).GetProperty(nameof(CameraDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
