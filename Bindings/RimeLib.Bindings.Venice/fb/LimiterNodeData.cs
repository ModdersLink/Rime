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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class LimiterNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Threshold = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3768602130)]
		public AudioGraphNodePort Threshold { get { return m_Threshold; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(Threshold), this, m_Threshold, value)) m_Threshold = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_ReleaseTime = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(892319833)]
		public AudioGraphNodePort ReleaseTime { get { return m_ReleaseTime; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(ReleaseTime), this, m_ReleaseTime, value)) m_ReleaseTime = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x20 (32)
		
		protected LimiterChannelMode m_ChannelMode = new LimiterChannelMode();
		[ContainerField(40), MemberInfoFlag(137), ContainerFieldNameHash(2243633477)]
		public LimiterChannelMode ChannelMode { get { return m_ChannelMode; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(ChannelMode), this, m_ChannelMode, value)) m_ChannelMode = value; } } // 0x28 (40)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(44), MemberInfoFlag(41), ContainerFieldNameHash(3384353452)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("LimiterNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x2C (44)
		
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
