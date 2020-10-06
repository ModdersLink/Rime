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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(224), ContainerClass]
	public class ChildComponentData : 
		PartComponentData
	{
		protected LinearTransform m_AlignTransform = new LinearTransform();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4277081604)]
		public LinearTransform AlignTransform { get { return m_AlignTransform; } set { if (OnPropertyChanging("ChildComponentData." + nameof(AlignTransform), this, m_AlignTransform, value)) m_AlignTransform = value; } } // 0x70 (112)
		
		protected CtrRef<MovingBodyData> m_MovingBody = new CtrRef<MovingBodyData>();
		[ContainerField(176), MemberInfoFlag(53), ContainerFieldNameHash(654150049), ContainerCtrRef]
		public CtrRef<MovingBodyData> MovingBody { get { return m_MovingBody; } set { if (OnPropertyChanging("ChildComponentData." + nameof(MovingBody), this, m_MovingBody, value)) m_MovingBody = value; } } // 0xB0 (176)
		
		protected VehicleHealthZoneData m_HealthZone = new VehicleHealthZoneData();
		[ContainerField(180), MemberInfoFlag(41), ContainerFieldNameHash(3196619047)]
		public VehicleHealthZoneData HealthZone { get { return m_HealthZone; } set { if (OnPropertyChanging("ChildComponentData." + nameof(HealthZone), this, m_HealthZone, value)) m_HealthZone = value; } } // 0xB4 (180)
		
		protected float m_SoundEffectStartRpm = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2939554110)]
		public float SoundEffectStartRpm { get { return m_SoundEffectStartRpm; } set { if (OnPropertyChanging("ChildComponentData." + nameof(SoundEffectStartRpm), this, m_SoundEffectStartRpm, value)) m_SoundEffectStartRpm = value; } } // 0xC8 (200)
		
		protected float m_SoundEffectStopRpm = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1267382822)]
		public float SoundEffectStopRpm { get { return m_SoundEffectStopRpm; } set { if (OnPropertyChanging("ChildComponentData." + nameof(SoundEffectStopRpm), this, m_SoundEffectStopRpm, value)) m_SoundEffectStopRpm = value; } } // 0xCC (204)
		
		protected CtrRef<AlignmentData> m_AlignmentSettings = new CtrRef<AlignmentData>();
		[ContainerField(208), MemberInfoFlag(53), ContainerFieldNameHash(870827711), ContainerCtrRef]
		public CtrRef<AlignmentData> AlignmentSettings { get { return m_AlignmentSettings; } set { if (OnPropertyChanging("ChildComponentData." + nameof(AlignmentSettings), this, m_AlignmentSettings, value)) m_AlignmentSettings = value; } } // 0xD0 (208)
		
		protected CtrRef<SoundAsset> m_SoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(212), MemberInfoFlag(53), ContainerFieldNameHash(3556609201), ContainerCtrRef]
		public CtrRef<SoundAsset> SoundEffect { get { return m_SoundEffect; } set { if (OnPropertyChanging("ChildComponentData." + nameof(SoundEffect), this, m_SoundEffect, value)) m_SoundEffect = value; } } // 0xD4 (212)
		
		protected bool m_EnableAlignToCamera = new bool();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2538251595)]
		public bool EnableAlignToCamera { get { return m_EnableAlignToCamera; } set { if (OnPropertyChanging("ChildComponentData." + nameof(EnableAlignToCamera), this, m_EnableAlignToCamera, value)) m_EnableAlignToCamera = value; } } // 0xD8 (216)
		
		protected bool m_WorldSpacePositionLock = new bool();
		[ContainerField(217), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3785410993)]
		public bool WorldSpacePositionLock { get { return m_WorldSpacePositionLock; } set { if (OnPropertyChanging("ChildComponentData." + nameof(WorldSpacePositionLock), this, m_WorldSpacePositionLock, value)) m_WorldSpacePositionLock = value; } } // 0xD9 (217)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4277081604:
					AlignTransform = (LinearTransform) p_Value;
					break;

				case 654150049:
					MovingBody = (CtrRef<MovingBodyData>) p_Value;
					break;

				case 3196619047:
					HealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 2939554110:
					SoundEffectStartRpm = (float) p_Value;
					break;

				case 1267382822:
					SoundEffectStopRpm = (float) p_Value;
					break;

				case 870827711:
					AlignmentSettings = (CtrRef<AlignmentData>) p_Value;
					break;

				case 3556609201:
					SoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2538251595:
					EnableAlignToCamera = (bool) p_Value;
					break;

				case 3785410993:
					WorldSpacePositionLock = (bool) p_Value;
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
				case 4277081604:
					return AlignTransform;

				case 654150049:
					return MovingBody;

				case 3196619047:
					return HealthZone;

				case 2939554110:
					return SoundEffectStartRpm;

				case 1267382822:
					return SoundEffectStopRpm;

				case 870827711:
					return AlignmentSettings;

				case 3556609201:
					return SoundEffect;

				case 2538251595:
					return EnableAlignToCamera;

				case 3785410993:
					return WorldSpacePositionLock;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4277081604:
					return typeof(ChildComponentData).GetProperty(nameof(AlignTransform));

				case 654150049:
					return typeof(ChildComponentData).GetProperty(nameof(MovingBody));

				case 3196619047:
					return typeof(ChildComponentData).GetProperty(nameof(HealthZone));

				case 2939554110:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffectStartRpm));

				case 1267382822:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffectStopRpm));

				case 870827711:
					return typeof(ChildComponentData).GetProperty(nameof(AlignmentSettings));

				case 3556609201:
					return typeof(ChildComponentData).GetProperty(nameof(SoundEffect));

				case 2538251595:
					return typeof(ChildComponentData).GetProperty(nameof(EnableAlignToCamera));

				case 3785410993:
					return typeof(ChildComponentData).GetProperty(nameof(WorldSpacePositionLock));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
