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
	public class StabilizerData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PitchStrength { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RollStrength { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float VerticalVelocityStrength { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float YawStrength { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool AdvancedYaw { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool Advanced { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 724430630:
					PitchStrength = (float) p_Value;
					break;

				case 3312814269:
					RollStrength = (float) p_Value;
					break;

				case 3950176229:
					VerticalVelocityStrength = (float) p_Value;
					break;

				case 2378860303:
					YawStrength = (float) p_Value;
					break;

				case 2833028724:
					AdvancedYaw = (bool) p_Value;
					break;

				case 2748179067:
					Advanced = (bool) p_Value;
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
				case 724430630:
					return PitchStrength;

				case 3312814269:
					return RollStrength;

				case 3950176229:
					return VerticalVelocityStrength;

				case 2378860303:
					return YawStrength;

				case 2833028724:
					return AdvancedYaw;

				case 2748179067:
					return Advanced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 724430630:
					return typeof(StabilizerData).GetProperty(nameof(PitchStrength));

				case 3312814269:
					return typeof(StabilizerData).GetProperty(nameof(RollStrength));

				case 3950176229:
					return typeof(StabilizerData).GetProperty(nameof(VerticalVelocityStrength));

				case 2378860303:
					return typeof(StabilizerData).GetProperty(nameof(YawStrength));

				case 2833028724:
					return typeof(StabilizerData).GetProperty(nameof(AdvancedYaw));

				case 2748179067:
					return typeof(StabilizerData).GetProperty(nameof(Advanced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
