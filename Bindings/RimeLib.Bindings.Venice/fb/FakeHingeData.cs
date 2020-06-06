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
	public class FakeHingeData : 
		FakePhysicsData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Pivot { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 RotationAxis { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ExtensionAxis { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinAngle { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxAngle { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float AngularDampening { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float PullbackAcceleration { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float ProgressiveExponent { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float InertiaModifier { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232602033:
					Pivot = (Vec3) p_Value;
					break;

				case 3148542130:
					RotationAxis = (Vec3) p_Value;
					break;

				case 4281429311:
					ExtensionAxis = (Vec3) p_Value;
					break;

				case 3356124462:
					MinAngle = (float) p_Value;
					break;

				case 417488496:
					MaxAngle = (float) p_Value;
					break;

				case 705185012:
					AngularDampening = (float) p_Value;
					break;

				case 1407037897:
					PullbackAcceleration = (float) p_Value;
					break;

				case 487101329:
					ProgressiveExponent = (float) p_Value;
					break;

				case 3532865534:
					InertiaModifier = (float) p_Value;
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
				case 232602033:
					return Pivot;

				case 3148542130:
					return RotationAxis;

				case 4281429311:
					return ExtensionAxis;

				case 3356124462:
					return MinAngle;

				case 417488496:
					return MaxAngle;

				case 705185012:
					return AngularDampening;

				case 1407037897:
					return PullbackAcceleration;

				case 487101329:
					return ProgressiveExponent;

				case 3532865534:
					return InertiaModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232602033:
					return typeof(FakeHingeData).GetProperty(nameof(Pivot));

				case 3148542130:
					return typeof(FakeHingeData).GetProperty(nameof(RotationAxis));

				case 4281429311:
					return typeof(FakeHingeData).GetProperty(nameof(ExtensionAxis));

				case 3356124462:
					return typeof(FakeHingeData).GetProperty(nameof(MinAngle));

				case 417488496:
					return typeof(FakeHingeData).GetProperty(nameof(MaxAngle));

				case 705185012:
					return typeof(FakeHingeData).GetProperty(nameof(AngularDampening));

				case 1407037897:
					return typeof(FakeHingeData).GetProperty(nameof(PullbackAcceleration));

				case 487101329:
					return typeof(FakeHingeData).GetProperty(nameof(ProgressiveExponent));

				case 3532865534:
					return typeof(FakeHingeData).GetProperty(nameof(InertiaModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
