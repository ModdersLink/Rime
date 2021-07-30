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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MixerInputEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 8, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("MixerInputEntry." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x8 (8)
		
		protected CtrRef<AudioGraphParameter> m_Source = new CtrRef<AudioGraphParameter>();
		[ContainerField(Name: "Source", Offset: 16, NameHash: 3339738264, Flags: 53)]
		public CtrRef<AudioGraphParameter> Source { get { return m_Source; } set { if (OnPropertyChanging("MixerInputEntry." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x10 (16)
		
		protected MixerValueAccumulateMode m_AccumulateMode = new MixerValueAccumulateMode();
		[ContainerField(Name: "AccumulateMode", Offset: 20, NameHash: 2760994582, Flags: 137)]
		public MixerValueAccumulateMode AccumulateMode { get { return m_AccumulateMode; } set { if (OnPropertyChanging("MixerInputEntry." + nameof(AccumulateMode), this, m_AccumulateMode, value)) m_AccumulateMode = value; } } // 0x14 (20)
		
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

				case 2760994582:
					AccumulateMode = (MixerValueAccumulateMode) Enum.ToObject(typeof(MixerValueAccumulateMode), p_Value);
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

				case 2760994582:
					return AccumulateMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(MixerInputEntry).GetProperty(nameof(Out));

				case 3339738264:
					return typeof(MixerInputEntry).GetProperty(nameof(Source));

				case 2760994582:
					return typeof(MixerInputEntry).GetProperty(nameof(AccumulateMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
