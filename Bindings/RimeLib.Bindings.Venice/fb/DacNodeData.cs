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
	public class DacNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort SpeakerCount { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort SampleRate { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new SoundGraphPluginRef(); // 0x20 (32)
		
		[ContainerField(35)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new SoundGraphPluginRef(); // 0x23 (35)
		
		[ContainerField(38)]
		public SoundGraphPluginRef DacPlugin { get; set; } = new SoundGraphPluginRef(); // 0x26 (38)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3711188829:
					SpeakerCount = (AudioGraphNodePort) p_Value;
					break;

				case 604757697:
					SampleRate = (AudioGraphNodePort) p_Value;
					break;

				case 2033640783:
					VuPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 3501812877:
					GainPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2354647978:
					DacPlugin = (SoundGraphPluginRef) p_Value;
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

				case 3711188829:
					return SpeakerCount;

				case 604757697:
					return SampleRate;

				case 2033640783:
					return VuPlugin;

				case 3501812877:
					return GainPlugin;

				case 2354647978:
					return DacPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DacNodeData).GetProperty(nameof(In));

				case 3711188829:
					return typeof(DacNodeData).GetProperty(nameof(SpeakerCount));

				case 604757697:
					return typeof(DacNodeData).GetProperty(nameof(SampleRate));

				case 2033640783:
					return typeof(DacNodeData).GetProperty(nameof(VuPlugin));

				case 3501812877:
					return typeof(DacNodeData).GetProperty(nameof(GainPlugin));

				case 2354647978:
					return typeof(DacNodeData).GetProperty(nameof(DacPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
