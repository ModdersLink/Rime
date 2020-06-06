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
	public class GainFaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort StartTime { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort FadeTime { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public GainFaderFadeType FadeType { get; set; } = new GainFaderFadeType(); // 0x38 (56)
		
		[ContainerField(60)]
		public SoundGraphPluginRef Plugin { get; set; } = new SoundGraphPluginRef(); // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 3727579056:
					StartTime = (AudioGraphNodePort) p_Value;
					break;

				case 4001222838:
					FadeTime = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 4001206363:
					FadeType = (GainFaderFadeType) Enum.ToObject(typeof(GainFaderFadeType), p_Value);
					break;

				case 3384353452:
					Plugin = (SoundGraphPluginRef) p_Value;
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

				case 230748069:
					return Start;

				case 3727579056:
					return StartTime;

				case 4001222838:
					return FadeTime;

				case 698564572:
					return Amplitude;

				case 193453899:
					return Out;

				case 4001206363:
					return FadeType;

				case 3384353452:
					return Plugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(GainFaderNodeData).GetProperty(nameof(In));

				case 230748069:
					return typeof(GainFaderNodeData).GetProperty(nameof(Start));

				case 3727579056:
					return typeof(GainFaderNodeData).GetProperty(nameof(StartTime));

				case 4001222838:
					return typeof(GainFaderNodeData).GetProperty(nameof(FadeTime));

				case 698564572:
					return typeof(GainFaderNodeData).GetProperty(nameof(Amplitude));

				case 193453899:
					return typeof(GainFaderNodeData).GetProperty(nameof(Out));

				case 4001206363:
					return typeof(GainFaderNodeData).GetProperty(nameof(FadeType));

				case 3384353452:
					return typeof(GainFaderNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
