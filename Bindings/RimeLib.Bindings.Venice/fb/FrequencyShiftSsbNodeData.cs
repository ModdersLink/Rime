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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class FrequencyShiftSsbNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("FrequencyShiftSsbNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Frequency = new AudioGraphNodePort();
		[ContainerField(Name: "Frequency", Offset: 16, NameHash: 4112821953, Flags: 41)]
		public AudioGraphNodePort Frequency { get { return m_Frequency; } set { if (OnPropertyChanging("FrequencyShiftSsbNodeData." + nameof(Frequency), this, m_Frequency, value)) m_Frequency = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 24, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("FrequencyShiftSsbNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected FrequencyShiftSsbFilter m_Filter = new FrequencyShiftSsbFilter();
		[ContainerField(Name: "Filter", Offset: 32, NameHash: 2525184005, Flags: 137)]
		public FrequencyShiftSsbFilter Filter { get { return m_Filter; } set { if (OnPropertyChanging("FrequencyShiftSsbNodeData." + nameof(Filter), this, m_Filter, value)) m_Filter = value; } } // 0x20 (32)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(Name: "Plugin", Offset: 36, NameHash: 3384353452, Flags: 41)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("FrequencyShiftSsbNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 4112821953:
					Frequency = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2525184005:
					Filter = (FrequencyShiftSsbFilter) Enum.ToObject(typeof(FrequencyShiftSsbFilter), p_Value);
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

				case 4112821953:
					return Frequency;

				case 193453899:
					return Out;

				case 2525184005:
					return Filter;

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
					return typeof(FrequencyShiftSsbNodeData).GetProperty(nameof(In));

				case 4112821953:
					return typeof(FrequencyShiftSsbNodeData).GetProperty(nameof(Frequency));

				case 193453899:
					return typeof(FrequencyShiftSsbNodeData).GetProperty(nameof(Out));

				case 2525184005:
					return typeof(FrequencyShiftSsbNodeData).GetProperty(nameof(Filter));

				case 3384353452:
					return typeof(FrequencyShiftSsbNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
