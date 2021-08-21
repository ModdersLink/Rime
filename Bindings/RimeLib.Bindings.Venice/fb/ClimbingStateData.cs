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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class ClimbingStateData : 
		CharacterStateData
	{
		protected float m_LateralInputScale = new float();
		[ContainerField(Name: "LateralInputScale", Offset: 12, NameHash: 2743831048, Flags: 49469), LayoutImmutable, Blittable]
		public float LateralInputScale { get { return m_LateralInputScale; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(LateralInputScale), this, m_LateralInputScale, value)) m_LateralInputScale = value; } } // 0xC (12)
		
		protected float m_DownAngleLimit = new float();
		[ContainerField(Name: "DownAngleLimit", Offset: 16, NameHash: 3644023203, Flags: 49469), LayoutImmutable, Blittable]
		public float DownAngleLimit { get { return m_DownAngleLimit; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(DownAngleLimit), this, m_DownAngleLimit, value)) m_DownAngleLimit = value; } } // 0x10 (16)
		
		protected float m_DropOffAngle = new float();
		[ContainerField(Name: "DropOffAngle", Offset: 20, NameHash: 3349590818, Flags: 49469), LayoutImmutable, Blittable]
		public float DropOffAngle { get { return m_DropOffAngle; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(DropOffAngle), this, m_DropOffAngle, value)) m_DropOffAngle = value; } } // 0x14 (20)
		
		protected float m_AttractionVelocity = new float();
		[ContainerField(Name: "AttractionVelocity", Offset: 24, NameHash: 2980040799, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractionVelocity { get { return m_AttractionVelocity; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(AttractionVelocity), this, m_AttractionVelocity, value)) m_AttractionVelocity = value; } } // 0x18 (24)
		
		protected float m_PushAwayVelocity = new float();
		[ContainerField(Name: "PushAwayVelocity", Offset: 28, NameHash: 751756002, Flags: 49469), LayoutImmutable, Blittable]
		public float PushAwayVelocity { get { return m_PushAwayVelocity; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(PushAwayVelocity), this, m_PushAwayVelocity, value)) m_PushAwayVelocity = value; } } // 0x1C (28)
		
		protected float m_ClimbHeightOffset = new float();
		[ContainerField(Name: "ClimbHeightOffset", Offset: 32, NameHash: 3576433790, Flags: 49469), LayoutImmutable, Blittable]
		public float ClimbHeightOffset { get { return m_ClimbHeightOffset; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(ClimbHeightOffset), this, m_ClimbHeightOffset, value)) m_ClimbHeightOffset = value; } } // 0x20 (32)
		
		protected float m_ClimbOffVerticalDistance = new float();
		[ContainerField(Name: "ClimbOffVerticalDistance", Offset: 36, NameHash: 1127208370, Flags: 49469), LayoutImmutable, Blittable]
		public float ClimbOffVerticalDistance { get { return m_ClimbOffVerticalDistance; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(ClimbOffVerticalDistance), this, m_ClimbOffVerticalDistance, value)) m_ClimbOffVerticalDistance = value; } } // 0x24 (36)
		
		protected float m_ClimbOffVerticalTime = new float();
		[ContainerField(Name: "ClimbOffVerticalTime", Offset: 40, NameHash: 985548708, Flags: 49469), LayoutImmutable, Blittable]
		public float ClimbOffVerticalTime { get { return m_ClimbOffVerticalTime; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(ClimbOffVerticalTime), this, m_ClimbOffVerticalTime, value)) m_ClimbOffVerticalTime = value; } } // 0x28 (40)
		
		protected float m_ClimbOffHorizontalDistance = new float();
		[ContainerField(Name: "ClimbOffHorizontalDistance", Offset: 44, NameHash: 1672476894, Flags: 49469), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalDistance { get { return m_ClimbOffHorizontalDistance; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(ClimbOffHorizontalDistance), this, m_ClimbOffHorizontalDistance, value)) m_ClimbOffHorizontalDistance = value; } } // 0x2C (44)
		
		protected float m_ClimbOffHorizontalTime = new float();
		[ContainerField(Name: "ClimbOffHorizontalTime", Offset: 48, NameHash: 3744214728, Flags: 49469), LayoutImmutable, Blittable]
		public float ClimbOffHorizontalTime { get { return m_ClimbOffHorizontalTime; } set { if (OnPropertyChanging("ClimbingStateData." + nameof(ClimbOffHorizontalTime), this, m_ClimbOffHorizontalTime, value)) m_ClimbOffHorizontalTime = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2743831048:
					LateralInputScale = (float) p_Value;
					break;

				case 3644023203:
					DownAngleLimit = (float) p_Value;
					break;

				case 3349590818:
					DropOffAngle = (float) p_Value;
					break;

				case 2980040799:
					AttractionVelocity = (float) p_Value;
					break;

				case 751756002:
					PushAwayVelocity = (float) p_Value;
					break;

				case 3576433790:
					ClimbHeightOffset = (float) p_Value;
					break;

				case 1127208370:
					ClimbOffVerticalDistance = (float) p_Value;
					break;

				case 985548708:
					ClimbOffVerticalTime = (float) p_Value;
					break;

				case 1672476894:
					ClimbOffHorizontalDistance = (float) p_Value;
					break;

				case 3744214728:
					ClimbOffHorizontalTime = (float) p_Value;
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
				case 2743831048:
					return LateralInputScale;

				case 3644023203:
					return DownAngleLimit;

				case 3349590818:
					return DropOffAngle;

				case 2980040799:
					return AttractionVelocity;

				case 751756002:
					return PushAwayVelocity;

				case 3576433790:
					return ClimbHeightOffset;

				case 1127208370:
					return ClimbOffVerticalDistance;

				case 985548708:
					return ClimbOffVerticalTime;

				case 1672476894:
					return ClimbOffHorizontalDistance;

				case 3744214728:
					return ClimbOffHorizontalTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2743831048:
					return typeof(ClimbingStateData).GetProperty(nameof(LateralInputScale));

				case 3644023203:
					return typeof(ClimbingStateData).GetProperty(nameof(DownAngleLimit));

				case 3349590818:
					return typeof(ClimbingStateData).GetProperty(nameof(DropOffAngle));

				case 2980040799:
					return typeof(ClimbingStateData).GetProperty(nameof(AttractionVelocity));

				case 751756002:
					return typeof(ClimbingStateData).GetProperty(nameof(PushAwayVelocity));

				case 3576433790:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbHeightOffset));

				case 1127208370:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffVerticalDistance));

				case 985548708:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffVerticalTime));

				case 1672476894:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffHorizontalDistance));

				case 3744214728:
					return typeof(ClimbingStateData).GetProperty(nameof(ClimbOffHorizontalTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
