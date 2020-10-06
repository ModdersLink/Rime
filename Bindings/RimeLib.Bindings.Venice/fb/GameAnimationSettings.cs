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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(72), ContainerClass]
	public class GameAnimationSettings : 
		SystemSettings
	{
		protected float m_TemporalLoddingFourthDeltaTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1100927269)]
		public float TemporalLoddingFourthDeltaTime { get { return m_TemporalLoddingFourthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFourthDeltaTime), this, m_TemporalLoddingFourthDeltaTime, value)) m_TemporalLoddingFourthDeltaTime = value; } } // 0xC (12)
		
		protected List<string> m_AntOnClientOnlyGamemodes = new List<string>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3192598540), ContainerArray]
		public List<string> AntOnClientOnlyGamemodes { get { return m_AntOnClientOnlyGamemodes; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(AntOnClientOnlyGamemodes), this, m_AntOnClientOnlyGamemodes, value)) m_AntOnClientOnlyGamemodes = value; } } // 0x10 (16)
		
		protected float m_TemporalLoddingFarDistance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2564620012)]
		public float TemporalLoddingFarDistance { get { return m_TemporalLoddingFarDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFarDistance), this, m_TemporalLoddingFarDistance, value)) m_TemporalLoddingFarDistance = value; } } // 0x14 (20)
		
		protected float m_TemporalLoddingSixthDeltaTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1927033737)]
		public float TemporalLoddingSixthDeltaTime { get { return m_TemporalLoddingSixthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSixthDeltaTime), this, m_TemporalLoddingSixthDeltaTime, value)) m_TemporalLoddingSixthDeltaTime = value; } } // 0x18 (24)
		
		protected float m_TemporalLoddingFifthDeltaTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2513484066)]
		public float TemporalLoddingFifthDeltaTime { get { return m_TemporalLoddingFifthDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFifthDeltaTime), this, m_TemporalLoddingFifthDeltaTime, value)) m_TemporalLoddingFifthDeltaTime = value; } } // 0x1C (28)
		
		protected float m_TemporalLoddingFirstDeltaTime = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2463190253)]
		public float TemporalLoddingFirstDeltaTime { get { return m_TemporalLoddingFirstDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFirstDeltaTime), this, m_TemporalLoddingFirstDeltaTime, value)) m_TemporalLoddingFirstDeltaTime = value; } } // 0x20 (32)
		
		protected float m_TemporalLoddingSecondDeltaTime = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2529580871)]
		public float TemporalLoddingSecondDeltaTime { get { return m_TemporalLoddingSecondDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSecondDeltaTime), this, m_TemporalLoddingSecondDeltaTime, value)) m_TemporalLoddingSecondDeltaTime = value; } } // 0x24 (36)
		
		protected float m_TemporalLoddingThirdDeltaTime = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4084107540)]
		public float TemporalLoddingThirdDeltaTime { get { return m_TemporalLoddingThirdDeltaTime; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingThirdDeltaTime), this, m_TemporalLoddingThirdDeltaTime, value)) m_TemporalLoddingThirdDeltaTime = value; } } // 0x28 (40)
		
		protected float m_TemporalLoddingSixthDistance = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(847080615)]
		public float TemporalLoddingSixthDistance { get { return m_TemporalLoddingSixthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSixthDistance), this, m_TemporalLoddingSixthDistance, value)) m_TemporalLoddingSixthDistance = value; } } // 0x2C (44)
		
		protected float m_TemporalLoddingSecondDistance = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1492660521)]
		public float TemporalLoddingSecondDistance { get { return m_TemporalLoddingSecondDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingSecondDistance), this, m_TemporalLoddingSecondDistance, value)) m_TemporalLoddingSecondDistance = value; } } // 0x30 (48)
		
		protected float m_TemporalLoddingFifthDistance = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(770539884)]
		public float TemporalLoddingFifthDistance { get { return m_TemporalLoddingFifthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFifthDistance), this, m_TemporalLoddingFifthDistance, value)) m_TemporalLoddingFifthDistance = value; } } // 0x34 (52)
		
		protected float m_TemporalLoddingFirstDistance = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(817037955)]
		public float TemporalLoddingFirstDistance { get { return m_TemporalLoddingFirstDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFirstDistance), this, m_TemporalLoddingFirstDistance, value)) m_TemporalLoddingFirstDistance = value; } } // 0x38 (56)
		
		protected float m_TemporalLoddingThirdDistance = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2919090970)]
		public float TemporalLoddingThirdDistance { get { return m_TemporalLoddingThirdDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingThirdDistance), this, m_TemporalLoddingThirdDistance, value)) m_TemporalLoddingThirdDistance = value; } } // 0x3C (60)
		
		protected float m_TemporalLoddingFourthDistance = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2864050507)]
		public float TemporalLoddingFourthDistance { get { return m_TemporalLoddingFourthDistance; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(TemporalLoddingFourthDistance), this, m_TemporalLoddingFourthDistance, value)) m_TemporalLoddingFourthDistance = value; } } // 0x40 (64)
		
		protected bool m_ServerEnable = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3875294337)]
		public bool ServerEnable { get { return m_ServerEnable; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(ServerEnable), this, m_ServerEnable, value)) m_ServerEnable = value; } } // 0x44 (68)
		
		protected bool m_UseRawGamepadInput = new bool();
		[ContainerField(69), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2767734287)]
		public bool UseRawGamepadInput { get { return m_UseRawGamepadInput; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(UseRawGamepadInput), this, m_UseRawGamepadInput, value)) m_UseRawGamepadInput = value; } } // 0x45 (69)
		
		protected bool m_ClientEnable = new bool();
		[ContainerField(70), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1069919325)]
		public bool ClientEnable { get { return m_ClientEnable; } set { if (OnPropertyChanging("GameAnimationSettings." + nameof(ClientEnable), this, m_ClientEnable, value)) m_ClientEnable = value; } } // 0x46 (70)
		
		protected bool m_UseAnimationDrivenCharacter = new bool();
		[ContainerField(71), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1718139563)]
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
