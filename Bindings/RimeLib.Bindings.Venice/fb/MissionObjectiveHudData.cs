///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MissionObjectiveHudData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraPosition { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 HorizontalBoundaries { get; set; } = new Vec2(); // 0x20 (32)
		
		[ContainerField(40), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 VerticalBoundaries { get; set; } = new Vec2(); // 0x28 (40)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float CameraRotation { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float CameraFov { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float CameraLookDistance { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float CameraDistance { get; set; } // 0x3C (60)
		
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
