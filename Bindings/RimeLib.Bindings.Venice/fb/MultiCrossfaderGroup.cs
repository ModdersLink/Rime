///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MultiCrossfaderGroup : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Stop { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float FadeAmplitude { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float FadeBegin { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float FadeEnd { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public FaderType FadeType { get; set; } = new FaderType(); // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 282245178:
					FadeAmplitude = (float) p_Value;
					break;

				case 3160511748:
					FadeBegin = (float) p_Value;
					break;

				case 1422737676:
					FadeEnd = (float) p_Value;
					break;

				case 4001206363:
					FadeType = (FaderType) Enum.ToObject(typeof(FaderType), p_Value);
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
				case 698564572:
					return Amplitude;

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 282245178:
					return FadeAmplitude;

				case 3160511748:
					return FadeBegin;

				case 1422737676:
					return FadeEnd;

				case 4001206363:
					return FadeType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 698564572:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Amplitude));

				case 230748069:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Stop));

				case 282245178:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeAmplitude));

				case 3160511748:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeBegin));

				case 1422737676:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeEnd));

				case 4001206363:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
