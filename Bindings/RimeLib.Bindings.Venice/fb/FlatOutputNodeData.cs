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
	public class FlatOutputNodeData : 
		OutputNodeData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float ReverbGain { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public CtrRef<SoundBusData> ReverbSend { get; set; } = new CtrRef<SoundBusData>(); // 0x58 (88)
		
		[ContainerField(92)]
		public AudioGraphNodePort CenterLevel { get; set; } = new AudioGraphNodePort(); // 0x5C (92)
		
		[ContainerField(100)]
		public AudioGraphNodePort LfeLevel { get; set; } = new AudioGraphNodePort(); // 0x64 (100)
		
		[ContainerField(108)]
		public SoundGraphPluginRef PanPlugin { get; set; } = new SoundGraphPluginRef(); // 0x6C (108)
		
		[ContainerField(111)]
		public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new SoundGraphPluginRef(); // 0x6F (111)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205597860:
					Angle = (float) p_Value;
					break;

				case 622241232:
					ReverbGain = (float) p_Value;
					break;

				case 621526765:
					ReverbSend = (CtrRef<SoundBusData>) p_Value;
					break;

				case 3914160568:
					CenterLevel = (AudioGraphNodePort) p_Value;
					break;

				case 2374965052:
					LfeLevel = (AudioGraphNodePort) p_Value;
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
				case 205597860:
					return Angle;

				case 622241232:
					return ReverbGain;

				case 621526765:
					return ReverbSend;

				case 3914160568:
					return CenterLevel;

				case 2374965052:
					return LfeLevel;

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
				case 205597860:
					return typeof(FlatOutputNodeData).GetProperty(nameof(Angle));

				case 622241232:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbGain));

				case 621526765:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbSend));

				case 3914160568:
					return typeof(FlatOutputNodeData).GetProperty(nameof(CenterLevel));

				case 2374965052:
					return typeof(FlatOutputNodeData).GetProperty(nameof(LfeLevel));

				case 941445235:
					return typeof(FlatOutputNodeData).GetProperty(nameof(PanPlugin));

				case 823182532:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbSendPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
