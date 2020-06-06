///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class InspectEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOffset { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable]
		public string UIName { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxLookAtHeight { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public List<InspectViewPointData> ViewPoints { get; set; } = new List<InspectViewPointData>(); // 0x78 (120)
		
		[ContainerField(124)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new RefArray<TargetCameraData>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float MinLookAtHeight { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float MinDistance { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ZoomScrollSpeed { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0x8C (140)
		
		[ContainerField(144)]
		public AntRef AnimationSignal { get; set; } = new AntRef(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float ZoomScrollAcceleration { get; set; } // 0x94 (148)
		
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
