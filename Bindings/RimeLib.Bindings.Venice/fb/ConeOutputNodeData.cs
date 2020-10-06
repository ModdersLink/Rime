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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(192), ContainerClass]
	public class ConeOutputNodeData : 
		OutputNodeData
	{
		protected Vec3 m_Direction = new Vec3();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2698949952)]
		public Vec3 Direction { get { return m_Direction; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(Direction), this, m_Direction, value)) m_Direction = value; } } // 0x50 (80)
		
		protected AudioGraphNodePort m_PositionY = new AudioGraphNodePort();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(616073509)]
		public AudioGraphNodePort PositionY { get { return m_PositionY; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(PositionY), this, m_PositionY, value)) m_PositionY = value; } } // 0x60 (96)
		
		protected AudioGraphNodePort m_PositionX = new AudioGraphNodePort();
		[ContainerField(104), MemberInfoFlag(41), ContainerFieldNameHash(616073508)]
		public AudioGraphNodePort PositionX { get { return m_PositionX; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(PositionX), this, m_PositionX, value)) m_PositionX = value; } } // 0x68 (104)
		
		protected AudioGraphNodePort m_PositionZ = new AudioGraphNodePort();
		[ContainerField(112), MemberInfoFlag(41), ContainerFieldNameHash(616073510)]
		public AudioGraphNodePort PositionZ { get { return m_PositionZ; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(PositionZ), this, m_PositionZ, value)) m_PositionZ = value; } } // 0x70 (112)
		
		protected AudioGraphNodePort m_OuterAngle = new AudioGraphNodePort();
		[ContainerField(120), MemberInfoFlag(41), ContainerFieldNameHash(4288979453)]
		public AudioGraphNodePort OuterAngle { get { return m_OuterAngle; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(OuterAngle), this, m_OuterAngle, value)) m_OuterAngle = value; } } // 0x78 (120)
		
		protected AudioGraphNodePort m_InnerAngle = new AudioGraphNodePort();
		[ContainerField(128), MemberInfoFlag(41), ContainerFieldNameHash(3372545274)]
		public AudioGraphNodePort InnerAngle { get { return m_InnerAngle; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(InnerAngle), this, m_InnerAngle, value)) m_InnerAngle = value; } } // 0x80 (128)
		
		protected float m_OutsideGain = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3004661521)]
		public float OutsideGain { get { return m_OutsideGain; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(OutsideGain), this, m_OutsideGain, value)) m_OutsideGain = value; } } // 0x88 (136)
		
		protected float m_PanSize = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3909355039)]
		public float PanSize { get { return m_PanSize; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(PanSize), this, m_PanSize, value)) m_PanSize = value; } } // 0x8C (140)
		
		protected AudioGraphNodePort m_CenterLevel = new AudioGraphNodePort();
		[ContainerField(144), MemberInfoFlag(41), ContainerFieldNameHash(3914160568)]
		public AudioGraphNodePort CenterLevel { get { return m_CenterLevel; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(CenterLevel), this, m_CenterLevel, value)) m_CenterLevel = value; } } // 0x90 (144)
		
		protected AudioGraphNodePort m_LfeLevel = new AudioGraphNodePort();
		[ContainerField(152), MemberInfoFlag(41), ContainerFieldNameHash(2374965052)]
		public AudioGraphNodePort LfeLevel { get { return m_LfeLevel; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(LfeLevel), this, m_LfeLevel, value)) m_LfeLevel = value; } } // 0x98 (152)
		
		protected float m_HFDampingAngle = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1689282354)]
		public float HFDampingAngle { get { return m_HFDampingAngle; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(HFDampingAngle), this, m_HFDampingAngle, value)) m_HFDampingAngle = value; } } // 0xA0 (160)
		
		protected float m_ReverbGain = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(622241232)]
		public float ReverbGain { get { return m_ReverbGain; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(ReverbGain), this, m_ReverbGain, value)) m_ReverbGain = value; } } // 0xA4 (164)
		
		protected CtrRef<SoundBusData> m_ReverbSend = new CtrRef<SoundBusData>();
		[ContainerField(168), MemberInfoFlag(53), ContainerFieldNameHash(621526765), ContainerCtrRef]
		public CtrRef<SoundBusData> ReverbSend { get { return m_ReverbSend; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(ReverbSend), this, m_ReverbSend, value)) m_ReverbSend = value; } } // 0xA8 (168)
		
		protected SoundGraphPluginRef m_PanPlugin = new SoundGraphPluginRef();
		[ContainerField(172), MemberInfoFlag(41), ContainerFieldNameHash(941445235)]
		public SoundGraphPluginRef PanPlugin { get { return m_PanPlugin; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(PanPlugin), this, m_PanPlugin, value)) m_PanPlugin = value; } } // 0xAC (172)
		
		protected SoundGraphPluginRef m_ReverbSendPlugin = new SoundGraphPluginRef();
		[ContainerField(175), MemberInfoFlag(41), ContainerFieldNameHash(823182532)]
		public SoundGraphPluginRef ReverbSendPlugin { get { return m_ReverbSendPlugin; } set { if (OnPropertyChanging("ConeOutputNodeData." + nameof(ReverbSendPlugin), this, m_ReverbSendPlugin, value)) m_ReverbSendPlugin = value; } } // 0xAF (175)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2698949952:
					Direction = (Vec3) p_Value;
					break;

				case 616073509:
					PositionY = (AudioGraphNodePort) p_Value;
					break;

				case 616073508:
					PositionX = (AudioGraphNodePort) p_Value;
					break;

				case 616073510:
					PositionZ = (AudioGraphNodePort) p_Value;
					break;

				case 4288979453:
					OuterAngle = (AudioGraphNodePort) p_Value;
					break;

				case 3372545274:
					InnerAngle = (AudioGraphNodePort) p_Value;
					break;

				case 3004661521:
					OutsideGain = (float) p_Value;
					break;

				case 3909355039:
					PanSize = (float) p_Value;
					break;

				case 3914160568:
					CenterLevel = (AudioGraphNodePort) p_Value;
					break;

				case 2374965052:
					LfeLevel = (AudioGraphNodePort) p_Value;
					break;

				case 1689282354:
					HFDampingAngle = (float) p_Value;
					break;

				case 622241232:
					ReverbGain = (float) p_Value;
					break;

				case 621526765:
					ReverbSend = (CtrRef<SoundBusData>) p_Value;
					break;

				case 941445235:
					PanPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 823182532:
					ReverbSendPlugin = (SoundGraphPluginRef) p_Value;
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
				case 2698949952:
					return Direction;

				case 616073509:
					return PositionY;

				case 616073508:
					return PositionX;

				case 616073510:
					return PositionZ;

				case 4288979453:
					return OuterAngle;

				case 3372545274:
					return InnerAngle;

				case 3004661521:
					return OutsideGain;

				case 3909355039:
					return PanSize;

				case 3914160568:
					return CenterLevel;

				case 2374965052:
					return LfeLevel;

				case 1689282354:
					return HFDampingAngle;

				case 622241232:
					return ReverbGain;

				case 621526765:
					return ReverbSend;

				case 941445235:
					return PanPlugin;

				case 823182532:
					return ReverbSendPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2698949952:
					return typeof(ConeOutputNodeData).GetProperty(nameof(Direction));

				case 616073509:
					return typeof(ConeOutputNodeData).GetProperty(nameof(PositionY));

				case 616073508:
					return typeof(ConeOutputNodeData).GetProperty(nameof(PositionX));

				case 616073510:
					return typeof(ConeOutputNodeData).GetProperty(nameof(PositionZ));

				case 4288979453:
					return typeof(ConeOutputNodeData).GetProperty(nameof(OuterAngle));

				case 3372545274:
					return typeof(ConeOutputNodeData).GetProperty(nameof(InnerAngle));

				case 3004661521:
					return typeof(ConeOutputNodeData).GetProperty(nameof(OutsideGain));

				case 3909355039:
					return typeof(ConeOutputNodeData).GetProperty(nameof(PanSize));

				case 3914160568:
					return typeof(ConeOutputNodeData).GetProperty(nameof(CenterLevel));

				case 2374965052:
					return typeof(ConeOutputNodeData).GetProperty(nameof(LfeLevel));

				case 1689282354:
					return typeof(ConeOutputNodeData).GetProperty(nameof(HFDampingAngle));

				case 622241232:
					return typeof(ConeOutputNodeData).GetProperty(nameof(ReverbGain));

				case 621526765:
					return typeof(ConeOutputNodeData).GetProperty(nameof(ReverbSend));

				case 941445235:
					return typeof(ConeOutputNodeData).GetProperty(nameof(PanPlugin));

				case 823182532:
					return typeof(ConeOutputNodeData).GetProperty(nameof(ReverbSendPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
