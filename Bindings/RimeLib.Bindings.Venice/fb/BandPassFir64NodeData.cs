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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class BandPassFir64NodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("BandPassFir64NodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Frequency = new AudioGraphNodePort();
		[ContainerField(Name: "Frequency", Offset: 16, NameHash: 4112821953, Flags: 41)]
		public AudioGraphNodePort Frequency { get { return m_Frequency; } set { if (OnPropertyChanging("BandPassFir64NodeData." + nameof(Frequency), this, m_Frequency, value)) m_Frequency = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Bandwidth = new AudioGraphNodePort();
		[ContainerField(Name: "Bandwidth", Offset: 24, NameHash: 623046954, Flags: 41)]
		public AudioGraphNodePort Bandwidth { get { return m_Bandwidth; } set { if (OnPropertyChanging("BandPassFir64NodeData." + nameof(Bandwidth), this, m_Bandwidth, value)) m_Bandwidth = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 32, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("BandPassFir64NodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x20 (32)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(Name: "Plugin", Offset: 40, NameHash: 3384353452, Flags: 41)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("BandPassFir64NodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x28 (40)
		
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

				case 623046954:
					Bandwidth = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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

				case 623046954:
					return Bandwidth;

				case 193453899:
					return Out;

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
					return typeof(BandPassFir64NodeData).GetProperty(nameof(In));

				case 4112821953:
					return typeof(BandPassFir64NodeData).GetProperty(nameof(Frequency));

				case 623046954:
					return typeof(BandPassFir64NodeData).GetProperty(nameof(Bandwidth));

				case 193453899:
					return typeof(BandPassFir64NodeData).GetProperty(nameof(Out));

				case 3384353452:
					return typeof(BandPassFir64NodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
