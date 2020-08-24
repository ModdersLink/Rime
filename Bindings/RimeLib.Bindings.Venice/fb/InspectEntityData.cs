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
	public class InspectEntityData : 
		GameEntityData
	{
		protected Vec3 m_CenterOffset = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(362641347)]
		public Vec3 CenterOffset { get { return m_CenterOffset; } set { if (OnPropertyChanging("InspectEntityData." + nameof(CenterOffset), this, m_CenterOffset, value)) m_CenterOffset = value; } } // 0x60 (96)
		
		protected string m_UIName = string.Empty;
		[ContainerField(112), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2999506814)]
		public string UIName { get { return m_UIName; } set { if (OnPropertyChanging("InspectEntityData." + nameof(UIName), this, m_UIName, value)) m_UIName = value; } } // 0x70 (112)
		
		protected float m_MaxLookAtHeight = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2912738716)]
		public float MaxLookAtHeight { get { return m_MaxLookAtHeight; } set { if (OnPropertyChanging("InspectEntityData." + nameof(MaxLookAtHeight), this, m_MaxLookAtHeight, value)) m_MaxLookAtHeight = value; } } // 0x74 (116)
		
		protected List<InspectViewPointData> m_ViewPoints = new List<InspectViewPointData>();
		[ContainerField(120), MemberInfoFlag(65), ContainerFieldNameHash(92696663), ContainerArray]
		public List<InspectViewPointData> ViewPoints { get { return m_ViewPoints; } set { if (OnPropertyChanging("InspectEntityData." + nameof(ViewPoints), this, m_ViewPoints, value)) m_ViewPoints = value; } } // 0x78 (120)
		
		protected RefArray<TargetCameraData> m_Cameras = new RefArray<TargetCameraData>();
		[ContainerField(124), MemberInfoFlag(65), ContainerFieldNameHash(3740512847), ContainerRefArray]
		public RefArray<TargetCameraData> Cameras { get { return m_Cameras; } set { if (OnPropertyChanging("InspectEntityData." + nameof(Cameras), this, m_Cameras, value)) m_Cameras = value; } } // 0x7C (124)
		
		protected float m_MinLookAtHeight = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3192024578)]
		public float MinLookAtHeight { get { return m_MinLookAtHeight; } set { if (OnPropertyChanging("InspectEntityData." + nameof(MinLookAtHeight), this, m_MinLookAtHeight, value)) m_MinLookAtHeight = value; } } // 0x80 (128)
		
		protected float m_MinDistance = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1885855628)]
		public float MinDistance { get { return m_MinDistance; } set { if (OnPropertyChanging("InspectEntityData." + nameof(MinDistance), this, m_MinDistance, value)) m_MinDistance = value; } } // 0x84 (132)
		
		protected float m_ZoomScrollSpeed = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3969725080)]
		public float ZoomScrollSpeed { get { return m_ZoomScrollSpeed; } set { if (OnPropertyChanging("InspectEntityData." + nameof(ZoomScrollSpeed), this, m_ZoomScrollSpeed, value)) m_ZoomScrollSpeed = value; } } // 0x88 (136)
		
		protected float m_MaxDistance = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3520454034)]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("InspectEntityData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x8C (140)
		
		protected AntRef m_AnimationSignal = new AntRef();
		[ContainerField(144), MemberInfoFlag(41), ContainerFieldNameHash(2364599213)]
		public AntRef AnimationSignal { get { return m_AnimationSignal; } set { if (OnPropertyChanging("InspectEntityData." + nameof(AnimationSignal), this, m_AnimationSignal, value)) m_AnimationSignal = value; } } // 0x90 (144)
		
		protected float m_ZoomScrollAcceleration = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2121669405)]
		public float ZoomScrollAcceleration { get { return m_ZoomScrollAcceleration; } set { if (OnPropertyChanging("InspectEntityData." + nameof(ZoomScrollAcceleration), this, m_ZoomScrollAcceleration, value)) m_ZoomScrollAcceleration = value; } } // 0x94 (148)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 362641347:
					CenterOffset = (Vec3) p_Value;
					break;

				case 2999506814:
					UIName = (string) p_Value;
					break;

				case 2912738716:
					MaxLookAtHeight = (float) p_Value;
					break;

				case 92696663:
					ViewPoints = (List<InspectViewPointData>) p_Value;
					break;

				case 3740512847:
					Cameras = (RefArray<TargetCameraData>) p_Value;
					break;

				case 3192024578:
					MinLookAtHeight = (float) p_Value;
					break;

				case 1885855628:
					MinDistance = (float) p_Value;
					break;

				case 3969725080:
					ZoomScrollSpeed = (float) p_Value;
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
					break;

				case 2364599213:
					AnimationSignal = (AntRef) p_Value;
					break;

				case 2121669405:
					ZoomScrollAcceleration = (float) p_Value;
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
				case 362641347:
					return CenterOffset;

				case 2999506814:
					return UIName;

				case 2912738716:
					return MaxLookAtHeight;

				case 92696663:
					return ViewPoints;

				case 3740512847:
					return Cameras;

				case 3192024578:
					return MinLookAtHeight;

				case 1885855628:
					return MinDistance;

				case 3969725080:
					return ZoomScrollSpeed;

				case 3520454034:
					return MaxDistance;

				case 2364599213:
					return AnimationSignal;

				case 2121669405:
					return ZoomScrollAcceleration;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 362641347:
					return typeof(InspectEntityData).GetProperty(nameof(CenterOffset));

				case 2999506814:
					return typeof(InspectEntityData).GetProperty(nameof(UIName));

				case 2912738716:
					return typeof(InspectEntityData).GetProperty(nameof(MaxLookAtHeight));

				case 92696663:
					return typeof(InspectEntityData).GetProperty(nameof(ViewPoints));

				case 3740512847:
					return typeof(InspectEntityData).GetProperty(nameof(Cameras));

				case 3192024578:
					return typeof(InspectEntityData).GetProperty(nameof(MinLookAtHeight));

				case 1885855628:
					return typeof(InspectEntityData).GetProperty(nameof(MinDistance));

				case 3969725080:
					return typeof(InspectEntityData).GetProperty(nameof(ZoomScrollSpeed));

				case 3520454034:
					return typeof(InspectEntityData).GetProperty(nameof(MaxDistance));

				case 2364599213:
					return typeof(InspectEntityData).GetProperty(nameof(AnimationSignal));

				case 2121669405:
					return typeof(InspectEntityData).GetProperty(nameof(ZoomScrollAcceleration));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
