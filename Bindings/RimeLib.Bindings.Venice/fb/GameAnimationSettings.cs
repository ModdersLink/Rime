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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 72)]
	public class GameAnimationSettings : 
		SystemSettings
	{
		protected float m_TemporalLoddingFourthDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingFourthDeltaTime", Offset: 12, NameHash: 1100927269, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDeltaTime { get { return m_TemporalLoddingFourthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFourthDeltaTime), this, m_TemporalLoddingFourthDeltaTime, value)) m_TemporalLoddingFourthDeltaTime = value; } } // 0xC (12)
		
		protected List<string> m_AntOnClientOnlyGamemodes = new List<string>();
		[ContainerField(Name: "AntOnClientOnlyGamemodes", Offset: 16, NameHash: 3192598540, Flags: 65)]
		public List<string> AntOnClientOnlyGamemodes { get { return m_AntOnClientOnlyGamemodes; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(AntOnClientOnlyGamemodes), this, m_AntOnClientOnlyGamemodes, value)) m_AntOnClientOnlyGamemodes = value; } } // 0x10 (16)
		
		protected float m_TemporalLoddingFarDistance = new float();
		[ContainerField(Name: "TemporalLoddingFarDistance", Offset: 20, NameHash: 2564620012, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFarDistance { get { return m_TemporalLoddingFarDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFarDistance), this, m_TemporalLoddingFarDistance, value)) m_TemporalLoddingFarDistance = value; } } // 0x14 (20)
		
		protected float m_TemporalLoddingSixthDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingSixthDeltaTime", Offset: 24, NameHash: 1927033737, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDeltaTime { get { return m_TemporalLoddingSixthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSixthDeltaTime), this, m_TemporalLoddingSixthDeltaTime, value)) m_TemporalLoddingSixthDeltaTime = value; } } // 0x18 (24)
		
		protected float m_TemporalLoddingFifthDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingFifthDeltaTime", Offset: 28, NameHash: 2513484066, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDeltaTime { get { return m_TemporalLoddingFifthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFifthDeltaTime), this, m_TemporalLoddingFifthDeltaTime, value)) m_TemporalLoddingFifthDeltaTime = value; } } // 0x1C (28)
		
		protected float m_TemporalLoddingFirstDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingFirstDeltaTime", Offset: 32, NameHash: 2463190253, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDeltaTime { get { return m_TemporalLoddingFirstDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFirstDeltaTime), this, m_TemporalLoddingFirstDeltaTime, value)) m_TemporalLoddingFirstDeltaTime = value; } } // 0x20 (32)
		
		protected float m_TemporalLoddingSecondDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingSecondDeltaTime", Offset: 36, NameHash: 2529580871, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDeltaTime { get { return m_TemporalLoddingSecondDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSecondDeltaTime), this, m_TemporalLoddingSecondDeltaTime, value)) m_TemporalLoddingSecondDeltaTime = value; } } // 0x24 (36)
		
		protected float m_TemporalLoddingThirdDeltaTime = new float();
		[ContainerField(Name: "TemporalLoddingThirdDeltaTime", Offset: 40, NameHash: 4084107540, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDeltaTime { get { return m_TemporalLoddingThirdDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingThirdDeltaTime), this, m_TemporalLoddingThirdDeltaTime, value)) m_TemporalLoddingThirdDeltaTime = value; } } // 0x28 (40)
		
		protected float m_TemporalLoddingSixthDistance = new float();
		[ContainerField(Name: "TemporalLoddingSixthDistance", Offset: 44, NameHash: 847080615, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDistance { get { return m_TemporalLoddingSixthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSixthDistance), this, m_TemporalLoddingSixthDistance, value)) m_TemporalLoddingSixthDistance = value; } } // 0x2C (44)
		
		protected float m_TemporalLoddingSecondDistance = new float();
		[ContainerField(Name: "TemporalLoddingSecondDistance", Offset: 48, NameHash: 1492660521, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDistance { get { return m_TemporalLoddingSecondDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSecondDistance), this, m_TemporalLoddingSecondDistance, value)) m_TemporalLoddingSecondDistance = value; } } // 0x30 (48)
		
		protected float m_TemporalLoddingFifthDistance = new float();
		[ContainerField(Name: "TemporalLoddingFifthDistance", Offset: 52, NameHash: 770539884, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDistance { get { return m_TemporalLoddingFifthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFifthDistance), this, m_TemporalLoddingFifthDistance, value)) m_TemporalLoddingFifthDistance = value; } } // 0x34 (52)
		
		protected float m_TemporalLoddingFirstDistance = new float();
		[ContainerField(Name: "TemporalLoddingFirstDistance", Offset: 56, NameHash: 817037955, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDistance { get { return m_TemporalLoddingFirstDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFirstDistance), this, m_TemporalLoddingFirstDistance, value)) m_TemporalLoddingFirstDistance = value; } } // 0x38 (56)
		
		protected float m_TemporalLoddingThirdDistance = new float();
		[ContainerField(Name: "TemporalLoddingThirdDistance", Offset: 60, NameHash: 2919090970, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDistance { get { return m_TemporalLoddingThirdDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingThirdDistance), this, m_TemporalLoddingThirdDistance, value)) m_TemporalLoddingThirdDistance = value; } } // 0x3C (60)
		
		protected float m_TemporalLoddingFourthDistance = new float();
		[ContainerField(Name: "TemporalLoddingFourthDistance", Offset: 64, NameHash: 2864050507, Flags: 49469), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDistance { get { return m_TemporalLoddingFourthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFourthDistance), this, m_TemporalLoddingFourthDistance, value)) m_TemporalLoddingFourthDistance = value; } } // 0x40 (64)
		
		protected bool m_ServerEnable = new bool();
		[ContainerField(Name: "ServerEnable", Offset: 68, NameHash: 3875294337, Flags: 49325), LayoutImmutable, Blittable]
		public bool ServerEnable { get { return m_ServerEnable; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(ServerEnable), this, m_ServerEnable, value)) m_ServerEnable = value; } } // 0x44 (68)
		
		protected bool m_UseRawGamepadInput = new bool();
		[ContainerField(Name: "UseRawGamepadInput", Offset: 69, NameHash: 2767734287, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseRawGamepadInput { get { return m_UseRawGamepadInput; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(UseRawGamepadInput), this, m_UseRawGamepadInput, value)) m_UseRawGamepadInput = value; } } // 0x45 (69)
		
		protected bool m_ClientEnable = new bool();
		[ContainerField(Name: "ClientEnable", Offset: 70, NameHash: 1069919325, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClientEnable { get { return m_ClientEnable; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(ClientEnable), this, m_ClientEnable, value)) m_ClientEnable = value; } } // 0x46 (70)
		
		protected bool m_UseAnimationDrivenCharacter = new bool();
		[ContainerField(Name: "UseAnimationDrivenCharacter", Offset: 71, NameHash: 1718139563, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAnimationDrivenCharacter { get { return m_UseAnimationDrivenCharacter; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(UseAnimationDrivenCharacter), this, m_UseAnimationDrivenCharacter, value)) m_UseAnimationDrivenCharacter = value; } } // 0x47 (71)
		
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
