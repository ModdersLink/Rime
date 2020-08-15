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
	[ContainerType(4)]
	public class SoundGraphData : 
		AudioGraphData
	{
		protected SoundGraphInfo m_Info = new SoundGraphInfo();
		[ContainerField(28), ContainerFieldNameHash(2088908747)]
		public SoundGraphInfo Info { get { return m_Info; } set { if (OnPropertyChanging("SoundGraphData." + nameof(Info), this, m_Info, value)) m_Info = value; } } // 0x1C (28)
		
		protected RefArray<AudioGraphParameter> m_InputParameters = new RefArray<AudioGraphParameter>();
		[ContainerField(52), ContainerFieldNameHash(344313993)]
		public RefArray<AudioGraphParameter> InputParameters { get { return m_InputParameters; } set { if (OnPropertyChanging("SoundGraphData." + nameof(InputParameters), this, m_InputParameters, value)) m_InputParameters = value; } } // 0x34 (52)
		
		protected RefArray<AudioGraphParameter> m_OutputParameters = new RefArray<AudioGraphParameter>();
		[ContainerField(56), ContainerFieldNameHash(1377250080)]
		public RefArray<AudioGraphParameter> OutputParameters { get { return m_OutputParameters; } set { if (OnPropertyChanging("SoundGraphData." + nameof(OutputParameters), this, m_OutputParameters, value)) m_OutputParameters = value; } } // 0x38 (56)
		
		protected RefArray<AudioGraphEvent> m_InputEvents = new RefArray<AudioGraphEvent>();
		[ContainerField(60), ContainerFieldNameHash(1542460652)]
		public RefArray<AudioGraphEvent> InputEvents { get { return m_InputEvents; } set { if (OnPropertyChanging("SoundGraphData." + nameof(InputEvents), this, m_InputEvents, value)) m_InputEvents = value; } } // 0x3C (60)
		
		protected RefArray<AudioGraphEvent> m_OutputEvents = new RefArray<AudioGraphEvent>();
		[ContainerField(64), ContainerFieldNameHash(3452448709)]
		public RefArray<AudioGraphEvent> OutputEvents { get { return m_OutputEvents; } set { if (OnPropertyChanging("SoundGraphData." + nameof(OutputEvents), this, m_OutputEvents, value)) m_OutputEvents = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088908747:
					Info = (SoundGraphInfo) p_Value;
					break;

				case 344313993:
					InputParameters = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 1377250080:
					OutputParameters = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 1542460652:
					InputEvents = (RefArray<AudioGraphEvent>) p_Value;
					break;

				case 3452448709:
					OutputEvents = (RefArray<AudioGraphEvent>) p_Value;
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
				case 2088908747:
					return Info;

				case 344313993:
					return InputParameters;

				case 1377250080:
					return OutputParameters;

				case 1542460652:
					return InputEvents;

				case 3452448709:
					return OutputEvents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088908747:
					return typeof(SoundGraphData).GetProperty(nameof(Info));

				case 344313993:
					return typeof(SoundGraphData).GetProperty(nameof(InputParameters));

				case 1377250080:
					return typeof(SoundGraphData).GetProperty(nameof(OutputParameters));

				case 1542460652:
					return typeof(SoundGraphData).GetProperty(nameof(InputEvents));

				case 3452448709:
					return typeof(SoundGraphData).GetProperty(nameof(OutputEvents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
