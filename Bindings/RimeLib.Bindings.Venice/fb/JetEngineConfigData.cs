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
	public class JetEngineConfigData : 
		EngineConfigData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PowerFadeOutRange { get; set; } = new Vec2(); // 0x60 (96)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ForceMagnitudeMultiplier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float AngleInputYMultiplier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float AngleInputPitchMultiplier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint DirectionVectorIndex { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool IsWaterJetEngine { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool IsTurnable { get; set; } // 0x7D (125)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4220367021:
					PowerFadeOutRange = (Vec2) p_Value;
					break;

				case 3209574239:
					ForceMagnitudeMultiplier = (float) p_Value;
					break;

				case 1243559936:
					AngleInputYMultiplier = (float) p_Value;
					break;

				case 872926687:
					AngleInputPitchMultiplier = (float) p_Value;
					break;

				case 81127366:
					MaxVelocity = (float) p_Value;
					break;

				case 3901228711:
					DirectionVectorIndex = (uint) p_Value;
					break;

				case 3093729791:
					IsWaterJetEngine = (bool) p_Value;
					break;

				case 2004357896:
					IsTurnable = (bool) p_Value;
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
				case 4220367021:
					return PowerFadeOutRange;

				case 3209574239:
					return ForceMagnitudeMultiplier;

				case 1243559936:
					return AngleInputYMultiplier;

				case 872926687:
					return AngleInputPitchMultiplier;

				case 81127366:
					return MaxVelocity;

				case 3901228711:
					return DirectionVectorIndex;

				case 3093729791:
					return IsWaterJetEngine;

				case 2004357896:
					return IsTurnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4220367021:
					return typeof(JetEngineConfigData).GetProperty(nameof(PowerFadeOutRange));

				case 3209574239:
					return typeof(JetEngineConfigData).GetProperty(nameof(ForceMagnitudeMultiplier));

				case 1243559936:
					return typeof(JetEngineConfigData).GetProperty(nameof(AngleInputYMultiplier));

				case 872926687:
					return typeof(JetEngineConfigData).GetProperty(nameof(AngleInputPitchMultiplier));

				case 81127366:
					return typeof(JetEngineConfigData).GetProperty(nameof(MaxVelocity));

				case 3901228711:
					return typeof(JetEngineConfigData).GetProperty(nameof(DirectionVectorIndex));

				case 3093729791:
					return typeof(JetEngineConfigData).GetProperty(nameof(IsWaterJetEngine));

				case 2004357896:
					return typeof(JetEngineConfigData).GetProperty(nameof(IsTurnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
