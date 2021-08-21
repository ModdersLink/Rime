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
	public class AiffWriterNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("AiffWriterNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(Name: "Start", Offset: 16, NameHash: 230748069, Flags: 41)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("AiffWriterNodeData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Stop = new AudioGraphNodePort();
		[ContainerField(Name: "Stop", Offset: 24, NameHash: 2089401213, Flags: 41)]
		public AudioGraphNodePort Stop { get { return m_Stop; } set { if (OnPropertyChanging("AiffWriterNodeData." + nameof(Stop), this, m_Stop, value)) m_Stop = value; } } // 0x18 (24)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(Name: "Plugin", Offset: 32, NameHash: 3384353452, Flags: 41)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("AiffWriterNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x20 (32)
		
		protected string m_FileName = string.Empty;
		[ContainerField(Name: "FileName", Offset: 36, NameHash: 1134474212, Flags: 16509), LayoutImmutable]
		public string FileName { get { return m_FileName; } set { if (OnPropertyChanging("AiffWriterNodeData." + nameof(FileName), this, m_FileName, value)) m_FileName = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 3384353452:
					Plugin = (SoundGraphPluginRef) p_Value;
					break;

				case 1134474212:
					FileName = (string) p_Value;
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

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 3384353452:
					return Plugin;

				case 1134474212:
					return FileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(AiffWriterNodeData).GetProperty(nameof(In));

				case 230748069:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Stop));

				case 3384353452:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Plugin));

				case 1134474212:
					return typeof(AiffWriterNodeData).GetProperty(nameof(FileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
