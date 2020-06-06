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
	public class IrReverbNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Reverb0 { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Amplitude0 { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Reverb1 { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Amplitude1 { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float MaxReverbLength { get; set; } // 0x38 (56)
		
		[ContainerField(60)]
		public SoundGraphPluginRef ReverbPlugin { get; set; } = new SoundGraphPluginRef(); // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 1309052001:
					Reverb0 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794412:
					Amplitude0 = (AudioGraphNodePort) p_Value;
					break;

				case 1309052000:
					Reverb1 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794413:
					Amplitude1 = (AudioGraphNodePort) p_Value;
					break;

				case 812921689:
					MaxReverbLength = (float) p_Value;
					break;

				case 2571271960:
					ReverbPlugin = (SoundGraphPluginRef) p_Value;
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
				case 5862146:
					return In;

				case 193453899:
					return Out;

				case 1309052001:
					return Reverb0;

				case 1577794412:
					return Amplitude0;

				case 1309052000:
					return Reverb1;

				case 1577794413:
					return Amplitude1;

				case 812921689:
					return MaxReverbLength;

				case 2571271960:
					return ReverbPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(IrReverbNodeData).GetProperty(nameof(In));

				case 193453899:
					return typeof(IrReverbNodeData).GetProperty(nameof(Out));

				case 1309052001:
					return typeof(IrReverbNodeData).GetProperty(nameof(Reverb0));

				case 1577794412:
					return typeof(IrReverbNodeData).GetProperty(nameof(Amplitude0));

				case 1309052000:
					return typeof(IrReverbNodeData).GetProperty(nameof(Reverb1));

				case 1577794413:
					return typeof(IrReverbNodeData).GetProperty(nameof(Amplitude1));

				case 812921689:
					return typeof(IrReverbNodeData).GetProperty(nameof(MaxReverbLength));

				case 2571271960:
					return typeof(IrReverbNodeData).GetProperty(nameof(ReverbPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
