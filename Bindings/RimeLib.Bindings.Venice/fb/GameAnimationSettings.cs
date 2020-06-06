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
    [ContainerType(4)]
	public class GameAnimationSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDeltaTime { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<string> AntOnClientOnlyGamemodes { get; set; } = new List<string>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float TemporalLoddingFarDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDeltaTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDeltaTime { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDeltaTime { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDeltaTime { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDeltaTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDistance { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDistance { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDistance { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDistance { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDistance { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDistance { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool ServerEnable { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseRawGamepadInput { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ClientEnable { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool UseAnimationDrivenCharacter { get; set; } // 0x47 (71)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1100927269:
					TemporalLoddingFourthDeltaTime = (float) p_Value;
					break;

				case 3192598540:
					AntOnClientOnlyGamemodes = (List<string>) p_Value;
					break;

				case 2564620012:
					TemporalLoddingFarDistance = (float) p_Value;
					break;

				case 1927033737:
					TemporalLoddingSixthDeltaTime = (float) p_Value;
					break;

				case 2513484066:
					TemporalLoddingFifthDeltaTime = (float) p_Value;
					break;

				case 2463190253:
					TemporalLoddingFirstDeltaTime = (float) p_Value;
					break;

				case 2529580871:
					TemporalLoddingSecondDeltaTime = (float) p_Value;
					break;

				case 4084107540:
					TemporalLoddingThirdDeltaTime = (float) p_Value;
					break;

				case 847080615:
					TemporalLoddingSixthDistance = (float) p_Value;
					break;

				case 1492660521:
					TemporalLoddingSecondDistance = (float) p_Value;
					break;

				case 770539884:
					TemporalLoddingFifthDistance = (float) p_Value;
					break;

				case 817037955:
					TemporalLoddingFirstDistance = (float) p_Value;
					break;

				case 2919090970:
					TemporalLoddingThirdDistance = (float) p_Value;
					break;

				case 2864050507:
					TemporalLoddingFourthDistance = (float) p_Value;
					break;

				case 3875294337:
					ServerEnable = (bool) p_Value;
					break;

				case 2767734287:
					UseRawGamepadInput = (bool) p_Value;
					break;

				case 1069919325:
					ClientEnable = (bool) p_Value;
					break;

				case 1718139563:
					UseAnimationDrivenCharacter = (bool) p_Value;
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
				case 1100927269:
					return TemporalLoddingFourthDeltaTime;

				case 3192598540:
					return AntOnClientOnlyGamemodes;

				case 2564620012:
					return TemporalLoddingFarDistance;

				case 1927033737:
					return TemporalLoddingSixthDeltaTime;

				case 2513484066:
					return TemporalLoddingFifthDeltaTime;

				case 2463190253:
					return TemporalLoddingFirstDeltaTime;

				case 2529580871:
					return TemporalLoddingSecondDeltaTime;

				case 4084107540:
					return TemporalLoddingThirdDeltaTime;

				case 847080615:
					return TemporalLoddingSixthDistance;

				case 1492660521:
					return TemporalLoddingSecondDistance;

				case 770539884:
					return TemporalLoddingFifthDistance;

				case 817037955:
					return TemporalLoddingFirstDistance;

				case 2919090970:
					return TemporalLoddingThirdDistance;

				case 2864050507:
					return TemporalLoddingFourthDistance;

				case 3875294337:
					return ServerEnable;

				case 2767734287:
					return UseRawGamepadInput;

				case 1069919325:
					return ClientEnable;

				case 1718139563:
					return UseAnimationDrivenCharacter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1100927269:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFourthDeltaTime));

				case 3192598540:
					return typeof(GameAnimationSettings).GetProperty(nameof(AntOnClientOnlyGamemodes));

				case 2564620012:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFarDistance));

				case 1927033737:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingSixthDeltaTime));

				case 2513484066:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFifthDeltaTime));

				case 2463190253:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFirstDeltaTime));

				case 2529580871:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingSecondDeltaTime));

				case 4084107540:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingThirdDeltaTime));

				case 847080615:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingSixthDistance));

				case 1492660521:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingSecondDistance));

				case 770539884:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFifthDistance));

				case 817037955:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFirstDistance));

				case 2919090970:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingThirdDistance));

				case 2864050507:
					return typeof(GameAnimationSettings).GetProperty(nameof(TemporalLoddingFourthDistance));

				case 3875294337:
					return typeof(GameAnimationSettings).GetProperty(nameof(ServerEnable));

				case 2767734287:
					return typeof(GameAnimationSettings).GetProperty(nameof(UseRawGamepadInput));

				case 1069919325:
					return typeof(GameAnimationSettings).GetProperty(nameof(ClientEnable));

				case 1718139563:
					return typeof(GameAnimationSettings).GetProperty(nameof(UseAnimationDrivenCharacter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
