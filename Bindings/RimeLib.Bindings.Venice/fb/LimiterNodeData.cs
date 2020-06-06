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
	public class LimiterNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Threshold { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort ReleaseTime { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public LimiterChannelMode ChannelMode { get; set; } = new LimiterChannelMode(); // 0x28 (40)
		
		[ContainerField(44)]
		public SoundGraphPluginRef Plugin { get; set; } = new SoundGraphPluginRef(); // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3768602130:
					Threshold = (AudioGraphNodePort) p_Value;
					break;

				case 892319833:
					ReleaseTime = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2243633477:
					ChannelMode = (LimiterChannelMode) Enum.ToObject(typeof(LimiterChannelMode), p_Value);
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

				case 3768602130:
					return Threshold;

				case 892319833:
					return ReleaseTime;

				case 193453899:
					return Out;

				case 2243633477:
					return ChannelMode;

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
					return typeof(LimiterNodeData).GetProperty(nameof(In));

				case 3768602130:
					return typeof(LimiterNodeData).GetProperty(nameof(Threshold));

				case 892319833:
					return typeof(LimiterNodeData).GetProperty(nameof(ReleaseTime));

				case 193453899:
					return typeof(LimiterNodeData).GetProperty(nameof(Out));

				case 2243633477:
					return typeof(LimiterNodeData).GetProperty(nameof(ChannelMode));

				case 3384353452:
					return typeof(LimiterNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
