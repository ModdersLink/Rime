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
	public class ConeOutputNodeData : 
		OutputNodeData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Direction { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96)]
		public AudioGraphNodePort PositionY { get; set; } = new AudioGraphNodePort(); // 0x60 (96)
		
		[ContainerField(104)]
		public AudioGraphNodePort PositionX { get; set; } = new AudioGraphNodePort(); // 0x68 (104)
		
		[ContainerField(112)]
		public AudioGraphNodePort PositionZ { get; set; } = new AudioGraphNodePort(); // 0x70 (112)
		
		[ContainerField(120)]
		public AudioGraphNodePort OuterAngle { get; set; } = new AudioGraphNodePort(); // 0x78 (120)
		
		[ContainerField(128)]
		public AudioGraphNodePort InnerAngle { get; set; } = new AudioGraphNodePort(); // 0x80 (128)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float OutsideGain { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float PanSize { get; set; } // 0x8C (140)
		
		[ContainerField(144)]
		public AudioGraphNodePort CenterLevel { get; set; } = new AudioGraphNodePort(); // 0x90 (144)
		
		[ContainerField(152)]
		public AudioGraphNodePort LfeLevel { get; set; } = new AudioGraphNodePort(); // 0x98 (152)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float HFDampingAngle { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float ReverbGain { get; set; } // 0xA4 (164)
		
		[ContainerField(168)]
		public CtrRef<SoundBusData> ReverbSend { get; set; } = new CtrRef<SoundBusData>(); // 0xA8 (168)
		
		[ContainerField(172)]
		public SoundGraphPluginRef PanPlugin { get; set; } = new SoundGraphPluginRef(); // 0xAC (172)
		
		[ContainerField(175)]
		public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new SoundGraphPluginRef(); // 0xAF (175)
		
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
