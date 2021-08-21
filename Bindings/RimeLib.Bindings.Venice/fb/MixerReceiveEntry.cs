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
	public class MixerReceiveEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 8, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("MixerReceiveEntry." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x8 (8)
		
		protected CtrRef<AudioGraphParameter> m_Source = new CtrRef<AudioGraphParameter>();
		[ContainerField(Name: "Source", Offset: 16, NameHash: 3339738264, Flags: 53)]
		public CtrRef<AudioGraphParameter> Source { get { return m_Source; } set { if (OnPropertyChanging("MixerReceiveEntry." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x10 (16)
		
		protected CtrRef<MixerAsset> m_Mixer = new CtrRef<MixerAsset>();
		[ContainerField(Name: "Mixer", Offset: 20, NameHash: 209965422, Flags: 53)]
		public CtrRef<MixerAsset> Mixer { get { return m_Mixer; } set { if (OnPropertyChanging("MixerReceiveEntry." + nameof(Mixer), this, m_Mixer, value)) m_Mixer = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<AudioGraphParameter>) p_Value;
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
				case 193453899:
					return Out;

				case 3339738264:
					return Source;

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
				case 193453899:
					return typeof(MixerReceiveEntry).GetProperty(nameof(Out));

				case 3339738264:
					return typeof(MixerReceiveEntry).GetProperty(nameof(Source));

				case 209965422:
					return typeof(MixerReceiveEntry).GetProperty(nameof(Mixer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
