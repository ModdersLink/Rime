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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MixerSendEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("MixerSendEntry." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected CtrRef<AudioGraphParameter> m_Target = new CtrRef<AudioGraphParameter>();
		[ContainerField(Name: "Target", Offset: 16, NameHash: 3215022804, Flags: 53)]
		public CtrRef<AudioGraphParameter> Target { get { return m_Target; } set { if (OnPropertyChanging("MixerSendEntry." + nameof(Target), this, m_Target, value)) m_Target = value; } } // 0x10 (16)
		
		protected CtrRef<MixerAsset> m_Mixer = new CtrRef<MixerAsset>();
		[ContainerField(Name: "Mixer", Offset: 20, NameHash: 209965422, Flags: 53)]
		public CtrRef<MixerAsset> Mixer { get { return m_Mixer; } set { if (OnPropertyChanging("MixerSendEntry." + nameof(Mixer), this, m_Mixer, value)) m_Mixer = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<AudioGraphParameter>) p_Value;
					break;

				case 209965422:
					Mixer = (CtrRef<MixerAsset>) p_Value;
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

				case 3215022804:
					return Target;

				case 209965422:
					return Mixer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MixerSendEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(MixerSendEntry).GetProperty(nameof(Target));

				case 209965422:
					return typeof(MixerSendEntry).GetProperty(nameof(Mixer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
