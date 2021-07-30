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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 72)]
	public class DialogSamplerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Pitch = new AudioGraphNodePort();
		[ContainerField(Name: "Pitch", Offset: 8, NameHash: 232604323, Flags: 41)]
		public AudioGraphNodePort Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(Name: "Amplitude", Offset: 16, NameHash: 698564572, Flags: 41)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Continue = new AudioGraphNodePort();
		[ContainerField(Name: "Continue", Offset: 24, NameHash: 333815684, Flags: 41)]
		public AudioGraphNodePort Continue { get { return m_Continue; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Continue), this, m_Continue, value)) m_Continue = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Output = new AudioGraphNodePort();
		[ContainerField(Name: "Output", Offset: 32, NameHash: 2895736442, Flags: 41)]
		public AudioGraphNodePort Output { get { return m_Output; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Output), this, m_Output, value)) m_Output = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Triggered = new AudioGraphNodePort();
		[ContainerField(Name: "Triggered", Offset: 40, NameHash: 3641208156, Flags: 41)]
		public AudioGraphNodePort Triggered { get { return m_Triggered; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Triggered), this, m_Triggered, value)) m_Triggered = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Finished = new AudioGraphNodePort();
		[ContainerField(Name: "Finished", Offset: 48, NameHash: 1223765815, Flags: 41)]
		public AudioGraphNodePort Finished { get { return m_Finished; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(Finished), this, m_Finished, value)) m_Finished = value; } } // 0x30 (48)
		
		protected SoundGraphPluginRef m_SndPlayerPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "SndPlayerPlugin", Offset: 56, NameHash: 824187494, Flags: 41)]
		public SoundGraphPluginRef SndPlayerPlugin { get { return m_SndPlayerPlugin; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(SndPlayerPlugin), this, m_SndPlayerPlugin, value)) m_SndPlayerPlugin = value; } } // 0x38 (56)
		
		protected SoundGraphPluginRef m_ResamplePlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "ResamplePlugin", Offset: 59, NameHash: 2592670685, Flags: 41)]
		public SoundGraphPluginRef ResamplePlugin { get { return m_ResamplePlugin; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(ResamplePlugin), this, m_ResamplePlugin, value)) m_ResamplePlugin = value; } } // 0x3B (59)
		
		protected SoundGraphPluginRef m_PausePlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "PausePlugin", Offset: 62, NameHash: 2591219422, Flags: 41)]
		public SoundGraphPluginRef PausePlugin { get { return m_PausePlugin; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(PausePlugin), this, m_PausePlugin, value)) m_PausePlugin = value; } } // 0x3E (62)
		
		protected SoundGraphPluginRef m_GainPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "GainPlugin", Offset: 65, NameHash: 3501812877, Flags: 41)]
		public SoundGraphPluginRef GainPlugin { get { return m_GainPlugin; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(GainPlugin), this, m_GainPlugin, value)) m_GainPlugin = value; } } // 0x41 (65)
		
		protected float m_TailLength = new float();
		[ContainerField(Name: "TailLength", Offset: 68, NameHash: 906601577, Flags: 49469), LayoutImmutable, Blittable]
		public float TailLength { get { return m_TailLength; } set { if (OnPropertyChanging("DialogSamplerNodeData." + nameof(TailLength), this, m_TailLength, value)) m_TailLength = value; } } // 0x44 (68)
		
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
