///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class BangerSpawnImpulseParams : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinHorizontalAngle { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxHorizontalAngle { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MinVerticalAngle { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxVerticalAngle { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinStrength { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxStrength { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float WaterStrengthModifier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float LinearDamping { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngularDamping { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1294078192:
					MinHorizontalAngle = (float) p_Value;
					break;

				case 3734684206:
					MaxHorizontalAngle = (float) p_Value;
					break;

				case 335615388:
					MinVerticalAngle = (float) p_Value;
					break;

				case 3164410690:
					MaxVerticalAngle = (float) p_Value;
					break;

				case 1539610890:
					MinStrength = (float) p_Value;
					break;

				case 1356104340:
					MaxStrength = (float) p_Value;
					break;

				case 778848386:
					WaterStrengthModifier = (float) p_Value;
					break;

				case 1796037280:
					LinearDamping = (float) p_Value;
					break;

				case 2055444159:
					AngularDamping = (float) p_Value;
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
				case 1294078192:
					return MinHorizontalAngle;

				case 3734684206:
					return MaxHorizontalAngle;

				case 335615388:
					return MinVerticalAngle;

				case 3164410690:
					return MaxVerticalAngle;

				case 1539610890:
					return MinStrength;

				case 1356104340:
					return MaxStrength;

				case 778848386:
					return WaterStrengthModifier;

				case 1796037280:
					return LinearDamping;

				case 2055444159:
					return AngularDamping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1294078192:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinHorizontalAngle));

				case 3734684206:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxHorizontalAngle));

				case 335615388:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinVerticalAngle));

				case 3164410690:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxVerticalAngle));

				case 1539610890:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinStrength));

				case 1356104340:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxStrength));

				case 778848386:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(WaterStrengthModifier));

				case 1796037280:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(LinearDamping));

				case 2055444159:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(AngularDamping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
