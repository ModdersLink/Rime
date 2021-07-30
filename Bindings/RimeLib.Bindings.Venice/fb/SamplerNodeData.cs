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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 148)]
	public class SamplerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_ExternalWave = new AudioGraphNodePort();
		[ContainerField(Name: "ExternalWave", Offset: 8, NameHash: 2162866621, Flags: 41)]
		public AudioGraphNodePort ExternalWave { get { return m_ExternalWave; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(ExternalWave), this, m_ExternalWave, value)) m_ExternalWave = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Variation = new AudioGraphNodePort();
		[ContainerField(Name: "Variation", Offset: 16, NameHash: 2945980116, Flags: 41)]
		public AudioGraphNodePort Variation { get { return m_Variation; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Variation), this, m_Variation, value)) m_Variation = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Offset = new AudioGraphNodePort();
		[ContainerField(Name: "Offset", Offset: 24, NameHash: 2871410728, Flags: 41)]
		public AudioGraphNodePort Offset { get { return m_Offset; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Delay = new AudioGraphNodePort();
		[ContainerField(Name: "Delay", Offset: 32, NameHash: 208768368, Flags: 41)]
		public AudioGraphNodePort Delay { get { return m_Delay; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Delay), this, m_Delay, value)) m_Delay = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Pitch = new AudioGraphNodePort();
		[ContainerField(Name: "Pitch", Offset: 40, NameHash: 232604323, Flags: 41)]
		public AudioGraphNodePort Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(Name: "Amplitude", Offset: 48, NameHash: 698564572, Flags: 41)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x30 (48)
		
		protected AudioGraphNodePort m_EnableStep = new AudioGraphNodePort();
		[ContainerField(Name: "EnableStep", Offset: 56, NameHash: 1191446550, Flags: 41)]
		public AudioGraphNodePort EnableStep { get { return m_EnableStep; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(EnableStep), this, m_EnableStep, value)) m_EnableStep = value; } } // 0x38 (56)
		
		protected AudioGraphNodePort m_Buffer = new AudioGraphNodePort();
		[ContainerField(Name: "Buffer", Offset: 64, NameHash: 2686813381, Flags: 41)]
		public AudioGraphNodePort Buffer { get { return m_Buffer; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Buffer), this, m_Buffer, value)) m_Buffer = value; } } // 0x40 (64)
		
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(Name: "Trigger", Offset: 72, NameHash: 2606354109, Flags: 41)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0x48 (72)
		
		protected AudioGraphNodePort m_Release = new AudioGraphNodePort();
		[ContainerField(Name: "Release", Offset: 80, NameHash: 1335266828, Flags: 41)]
		public AudioGraphNodePort Release { get { return m_Release; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Release), this, m_Release, value)) m_Release = value; } } // 0x50 (80)
		
		protected AudioGraphNodePort m_Step = new AudioGraphNodePort();
		[ContainerField(Name: "Step", Offset: 88, NameHash: 2089400887, Flags: 41)]
		public AudioGraphNodePort Step { get { return m_Step; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Step), this, m_Step, value)) m_Step = value; } } // 0x58 (88)
		
		protected AudioGraphNodePort m_Output = new AudioGraphNodePort();
		[ContainerField(Name: "Output", Offset: 96, NameHash: 2895736442, Flags: 41)]
		public AudioGraphNodePort Output { get { return m_Output; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Output), this, m_Output, value)) m_Output = value; } } // 0x60 (96)
		
		protected AudioGraphNodePort m_Finished = new AudioGraphNodePort();
		[ContainerField(Name: "Finished", Offset: 104, NameHash: 1223765815, Flags: 41)]
		public AudioGraphNodePort Finished { get { return m_Finished; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Finished), this, m_Finished, value)) m_Finished = value; } } // 0x68 (104)
		
		protected AudioGraphNodePort m_Buffered = new AudioGraphNodePort();
		[ContainerField(Name: "Buffered", Offset: 112, NameHash: 1067040100, Flags: 41)]
		public AudioGraphNodePort Buffered { get { return m_Buffered; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Buffered), this, m_Buffered, value)) m_Buffered = value; } } // 0x70 (112)
		
		protected AudioGraphNodePort m_Position = new AudioGraphNodePort();
		[ContainerField(Name: "Position", Offset: 120, NameHash: 3402582524, Flags: 41)]
		public AudioGraphNodePort Position { get { return m_Position; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x78 (120)
		
		protected CtrRef<SoundWaveAsset> m_Wave = new CtrRef<SoundWaveAsset>();
		[ContainerField(Name: "Wave", Offset: 128, NameHash: 2089277184, Flags: 53)]
		public CtrRef<SoundWaveAsset> Wave { get { return m_Wave; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Wave), this, m_Wave, value)) m_Wave = value; } } // 0x80 (128)
		
		protected float m_BasePitch = new float();
		[ContainerField(Name: "BasePitch", Offset: 132, NameHash: 1679241558, Flags: 49469), LayoutImmutable, Blittable]
		public float BasePitch { get { return m_BasePitch; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(BasePitch), this, m_BasePitch, value)) m_BasePitch = value; } } // 0x84 (132)
		
		protected LoopType m_Loop = new LoopType();
		[ContainerField(Name: "Loop", Offset: 136, NameHash: 2089019673, Flags: 137)]
		public LoopType Loop { get { return m_Loop; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Loop), this, m_Loop, value)) m_Loop = value; } } // 0x88 (136)
		
		protected List<SamplerPlugins> m_Plugins = new List<SamplerPlugins>();
		[ContainerField(Name: "Plugins", Offset: 140, NameHash: 14514271, Flags: 65)]
		public List<SamplerPlugins> Plugins { get { return m_Plugins; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(Plugins), this, m_Plugins, value)) m_Plugins = value; } } // 0x8C (140)
		
		protected bool m_ShuffleSegments = new bool();
		[ContainerField(Name: "ShuffleSegments", Offset: 144, NameHash: 3924973362, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShuffleSegments { get { return m_ShuffleSegments; } set { if (OnPropertyChanging("SamplerNodeData." + nameof(ShuffleSegments), this, m_ShuffleSegments, value)) m_ShuffleSegments = value; } } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2162866621:
					ExternalWave = (AudioGraphNodePort) p_Value;
					break;

				case 2945980116:
					Variation = (AudioGraphNodePort) p_Value;
					break;

				case 2871410728:
					Offset = (AudioGraphNodePort) p_Value;
					break;

				case 208768368:
					Delay = (AudioGraphNodePort) p_Value;
					break;

				case 232604323:
					Pitch = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 1191446550:
					EnableStep = (AudioGraphNodePort) p_Value;
					break;

				case 2686813381:
					Buffer = (AudioGraphNodePort) p_Value;
					break;

				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 1335266828:
					Release = (AudioGraphNodePort) p_Value;
					break;

				case 2089400887:
					Step = (AudioGraphNodePort) p_Value;
					break;

				case 2895736442:
					Output = (AudioGraphNodePort) p_Value;
					break;

				case 1223765815:
					Finished = (AudioGraphNodePort) p_Value;
					break;

				case 1067040100:
					Buffered = (AudioGraphNodePort) p_Value;
					break;

				case 3402582524:
					Position = (AudioGraphNodePort) p_Value;
					break;

				case 2089277184:
					Wave = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 1679241558:
					BasePitch = (float) p_Value;
					break;

				case 2089019673:
					Loop = (LoopType) Enum.ToObject(typeof(LoopType), p_Value);
					break;

				case 14514271:
					Plugins = (List<SamplerPlugins>) p_Value;
					break;

				case 3924973362:
					ShuffleSegments = (bool) p_Value;
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
				case 2162866621:
					return ExternalWave;

				case 2945980116:
					return Variation;

				case 2871410728:
					return Offset;

				case 208768368:
					return Delay;

				case 232604323:
					return Pitch;

				case 698564572:
					return Amplitude;

				case 1191446550:
					return EnableStep;

				case 2686813381:
					return Buffer;

				case 2606354109:
					return Trigger;

				case 1335266828:
					return Release;

				case 2089400887:
					return Step;

				case 2895736442:
					return Output;

				case 1223765815:
					return Finished;

				case 1067040100:
					return Buffered;

				case 3402582524:
					return Position;

				case 2089277184:
					return Wave;

				case 1679241558:
					return BasePitch;

				case 2089019673:
					return Loop;

				case 14514271:
					return Plugins;

				case 3924973362:
					return ShuffleSegments;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2162866621:
					return typeof(SamplerNodeData).GetProperty(nameof(ExternalWave));

				case 2945980116:
					return typeof(SamplerNodeData).GetProperty(nameof(Variation));

				case 2871410728:
					return typeof(SamplerNodeData).GetProperty(nameof(Offset));

				case 208768368:
					return typeof(SamplerNodeData).GetProperty(nameof(Delay));

				case 232604323:
					return typeof(SamplerNodeData).GetProperty(nameof(Pitch));

				case 698564572:
					return typeof(SamplerNodeData).GetProperty(nameof(Amplitude));

				case 1191446550:
					return typeof(SamplerNodeData).GetProperty(nameof(EnableStep));

				case 2686813381:
					return typeof(SamplerNodeData).GetProperty(nameof(Buffer));

				case 2606354109:
					return typeof(SamplerNodeData).GetProperty(nameof(Trigger));

				case 1335266828:
					return typeof(SamplerNodeData).GetProperty(nameof(Release));

				case 2089400887:
					return typeof(SamplerNodeData).GetProperty(nameof(Step));

				case 2895736442:
					return typeof(SamplerNodeData).GetProperty(nameof(Output));

				case 1223765815:
					return typeof(SamplerNodeData).GetProperty(nameof(Finished));

				case 1067040100:
					return typeof(SamplerNodeData).GetProperty(nameof(Buffered));

				case 3402582524:
					return typeof(SamplerNodeData).GetProperty(nameof(Position));

				case 2089277184:
					return typeof(SamplerNodeData).GetProperty(nameof(Wave));

				case 1679241558:
					return typeof(SamplerNodeData).GetProperty(nameof(BasePitch));

				case 2089019673:
					return typeof(SamplerNodeData).GetProperty(nameof(Loop));

				case 14514271:
					return typeof(SamplerNodeData).GetProperty(nameof(Plugins));

				case 3924973362:
					return typeof(SamplerNodeData).GetProperty(nameof(ShuffleSegments));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
