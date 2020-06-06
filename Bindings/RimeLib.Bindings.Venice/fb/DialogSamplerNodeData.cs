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
	public class DialogSamplerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Pitch { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Continue { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Output { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Triggered { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Finished { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public SoundGraphPluginRef SndPlayerPlugin { get; set; } = new SoundGraphPluginRef(); // 0x38 (56)
		
		[ContainerField(59)]
		public SoundGraphPluginRef ResamplePlugin { get; set; } = new SoundGraphPluginRef(); // 0x3B (59)
		
		[ContainerField(62)]
		public SoundGraphPluginRef PausePlugin { get; set; } = new SoundGraphPluginRef(); // 0x3E (62)
		
		[ContainerField(65)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new SoundGraphPluginRef(); // 0x41 (65)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float TailLength { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232604323:
					Pitch = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 333815684:
					Continue = (AudioGraphNodePort) p_Value;
					break;

				case 2895736442:
					Output = (AudioGraphNodePort) p_Value;
					break;

				case 3641208156:
					Triggered = (AudioGraphNodePort) p_Value;
					break;

				case 1223765815:
					Finished = (AudioGraphNodePort) p_Value;
					break;

				case 824187494:
					SndPlayerPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2592670685:
					ResamplePlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2591219422:
					PausePlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 3501812877:
					GainPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 906601577:
					TailLength = (float) p_Value;
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
				case 232604323:
					return Pitch;

				case 698564572:
					return Amplitude;

				case 333815684:
					return Continue;

				case 2895736442:
					return Output;

				case 3641208156:
					return Triggered;

				case 1223765815:
					return Finished;

				case 824187494:
					return SndPlayerPlugin;

				case 2592670685:
					return ResamplePlugin;

				case 2591219422:
					return PausePlugin;

				case 3501812877:
					return GainPlugin;

				case 906601577:
					return TailLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232604323:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Pitch));

				case 698564572:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Amplitude));

				case 333815684:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Continue));

				case 2895736442:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Output));

				case 3641208156:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Triggered));

				case 1223765815:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(Finished));

				case 824187494:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(SndPlayerPlugin));

				case 2592670685:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(ResamplePlugin));

				case 2591219422:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(PausePlugin));

				case 3501812877:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(GainPlugin));

				case 906601577:
					return typeof(DialogSamplerNodeData).GetProperty(nameof(TailLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
