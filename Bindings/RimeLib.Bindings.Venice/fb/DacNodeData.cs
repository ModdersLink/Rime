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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class DacNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("DacNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_SpeakerCount = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3711188829)]
		public AudioGraphNodePort SpeakerCount { get { return m_SpeakerCount; } set { if (OnPropertyChanging("DacNodeData." + nameof(SpeakerCount), this, m_SpeakerCount, value)) m_SpeakerCount = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_SampleRate = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(604757697)]
		public AudioGraphNodePort SampleRate { get { return m_SampleRate; } set { if (OnPropertyChanging("DacNodeData." + nameof(SampleRate), this, m_SampleRate, value)) m_SampleRate = value; } } // 0x18 (24)
		
		protected SoundGraphPluginRef m_VuPlugin = new SoundGraphPluginRef();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(2033640783)]
		public SoundGraphPluginRef VuPlugin { get { return m_VuPlugin; } set { if (OnPropertyChanging("DacNodeData." + nameof(VuPlugin), this, m_VuPlugin, value)) m_VuPlugin = value; } } // 0x20 (32)
		
		protected SoundGraphPluginRef m_GainPlugin = new SoundGraphPluginRef();
		[ContainerField(35), MemberInfoFlag(41), ContainerFieldNameHash(3501812877)]
		public SoundGraphPluginRef GainPlugin { get { return m_GainPlugin; } set { if (OnPropertyChanging("DacNodeData." + nameof(GainPlugin), this, m_GainPlugin, value)) m_GainPlugin = value; } } // 0x23 (35)
		
		protected SoundGraphPluginRef m_DacPlugin = new SoundGraphPluginRef();
		[ContainerField(38), MemberInfoFlag(41), ContainerFieldNameHash(2354647978)]
		public SoundGraphPluginRef DacPlugin { get { return m_DacPlugin; } set { if (OnPropertyChanging("DacNodeData." + nameof(DacPlugin), this, m_DacPlugin, value)) m_DacPlugin = value; } } // 0x26 (38)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3711188829:
					SpeakerCount = (AudioGraphNodePort) p_Value;
					break;

				case 604757697:
					SampleRate = (AudioGraphNodePort) p_Value;
					break;

				case 2033640783:
					VuPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 3501812877:
					GainPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2354647978:
					DacPlugin = (SoundGraphPluginRef) p_Value;
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

				case 3711188829:
					return SpeakerCount;

				case 604757697:
					return SampleRate;

				case 2033640783:
					return VuPlugin;

				case 3501812877:
					return GainPlugin;

				case 2354647978:
					return DacPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DacNodeData).GetProperty(nameof(In));

				case 3711188829:
					return typeof(DacNodeData).GetProperty(nameof(SpeakerCount));

				case 604757697:
					return typeof(DacNodeData).GetProperty(nameof(SampleRate));

				case 2033640783:
					return typeof(DacNodeData).GetProperty(nameof(VuPlugin));

				case 3501812877:
					return typeof(DacNodeData).GetProperty(nameof(GainPlugin));

				case 2354647978:
					return typeof(DacNodeData).GetProperty(nameof(DacPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
