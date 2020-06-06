///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SamplerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort ExternalWave { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Variation { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Offset { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Delay { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Pitch { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public AudioGraphNodePort EnableStep { get; set; } = new AudioGraphNodePort(); // 0x38 (56)
		
		[ContainerField(64)]
		public AudioGraphNodePort Buffer { get; set; } = new AudioGraphNodePort(); // 0x40 (64)
		
		[ContainerField(72)]
		public AudioGraphNodePort Trigger { get; set; } = new AudioGraphNodePort(); // 0x48 (72)
		
		[ContainerField(80)]
		public AudioGraphNodePort Release { get; set; } = new AudioGraphNodePort(); // 0x50 (80)
		
		[ContainerField(88)]
		public AudioGraphNodePort Step { get; set; } = new AudioGraphNodePort(); // 0x58 (88)
		
		[ContainerField(96)]
		public AudioGraphNodePort Output { get; set; } = new AudioGraphNodePort(); // 0x60 (96)
		
		[ContainerField(104)]
		public AudioGraphNodePort Finished { get; set; } = new AudioGraphNodePort(); // 0x68 (104)
		
		[ContainerField(112)]
		public AudioGraphNodePort Buffered { get; set; } = new AudioGraphNodePort(); // 0x70 (112)
		
		[ContainerField(120)]
		public AudioGraphNodePort Position { get; set; } = new AudioGraphNodePort(); // 0x78 (120)
		
		[ContainerField(128)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float BasePitch { get; set; } // 0x84 (132)
		
		[ContainerField(136)]
		public LoopType Loop { get; set; } = new LoopType(); // 0x88 (136)
		
		[ContainerField(140)]
		public List<SamplerPlugins> Plugins { get; set; } = new List<SamplerPlugins>(); // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool ShuffleSegments { get; set; } // 0x90 (144)
		
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
