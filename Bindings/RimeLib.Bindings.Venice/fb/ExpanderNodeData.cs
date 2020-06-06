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
	public class ExpanderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Threshold { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Ratio { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort AttackTime { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort ReleaseTime { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public ExpanderChannelMode ChannelMode { get; set; } = new ExpanderChannelMode(); // 0x38 (56)
		
		[ContainerField(60)]
		public SoundGraphPluginRef Plugin { get; set; } = new SoundGraphPluginRef(); // 0x3C (60)
		
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

				case 230084836:
					Ratio = (AudioGraphNodePort) p_Value;
					break;

				case 1150936440:
					AttackTime = (AudioGraphNodePort) p_Value;
					break;

				case 892319833:
					ReleaseTime = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2243633477:
					ChannelMode = (ExpanderChannelMode) Enum.ToObject(typeof(ExpanderChannelMode), p_Value);
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

				case 230084836:
					return Ratio;

				case 1150936440:
					return AttackTime;

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
					return typeof(ExpanderNodeData).GetProperty(nameof(In));

				case 3768602130:
					return typeof(ExpanderNodeData).GetProperty(nameof(Threshold));

				case 230084836:
					return typeof(ExpanderNodeData).GetProperty(nameof(Ratio));

				case 1150936440:
					return typeof(ExpanderNodeData).GetProperty(nameof(AttackTime));

				case 892319833:
					return typeof(ExpanderNodeData).GetProperty(nameof(ReleaseTime));

				case 193453899:
					return typeof(ExpanderNodeData).GetProperty(nameof(Out));

				case 2243633477:
					return typeof(ExpanderNodeData).GetProperty(nameof(ChannelMode));

				case 3384353452:
					return typeof(ExpanderNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
