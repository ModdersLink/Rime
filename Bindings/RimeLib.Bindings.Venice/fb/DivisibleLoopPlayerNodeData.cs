///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DivisibleLoopPlayerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Stop { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort FreezeSegment { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Output { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new CtrRef<SoundWaveAsset>(); // 0x30 (48)
		
		[ContainerField(52)]
		public AudioGraphNodePort ExternalWave { get; set; } = new AudioGraphNodePort(); // 0x34 (52)
		
		[ContainerField(60)]
		public List<DivisibleLoopPlayerPlugins> Plugins { get; set; } = new List<DivisibleLoopPlayerPlugins>(); // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float CrossFadeLength { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool StartAtRandomPosition { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 3532981773:
					FreezeSegment = (AudioGraphNodePort) p_Value;
					break;

				case 2895736442:
					Output = (AudioGraphNodePort) p_Value;
					break;

				case 2089277184:
					Wave = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2162866621:
					ExternalWave = (AudioGraphNodePort) p_Value;
					break;

				case 14514271:
					Plugins = (List<DivisibleLoopPlayerPlugins>) p_Value;
					break;

				case 2603726337:
					CrossFadeLength = (float) p_Value;
					break;

				case 663970258:
					StartAtRandomPosition = (bool) p_Value;
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
				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 698564572:
					return Amplitude;

				case 3532981773:
					return FreezeSegment;

				case 2895736442:
					return Output;

				case 2089277184:
					return Wave;

				case 2162866621:
					return ExternalWave;

				case 14514271:
					return Plugins;

				case 2603726337:
					return CrossFadeLength;

				case 663970258:
					return StartAtRandomPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230748069:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Stop));

				case 698564572:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Amplitude));

				case 3532981773:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(FreezeSegment));

				case 2895736442:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Output));

				case 2089277184:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Wave));

				case 2162866621:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(ExternalWave));

				case 14514271:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Plugins));

				case 2603726337:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(CrossFadeLength));

				case 663970258:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(StartAtRandomPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
