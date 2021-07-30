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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class GainFaderNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(Name: "Start", Offset: 16, NameHash: 230748069, Flags: 41)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_StartTime = new AudioGraphNodePort();
		[ContainerField(Name: "StartTime", Offset: 24, NameHash: 3727579056, Flags: 41)]
		public AudioGraphNodePort StartTime { get { return m_StartTime; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(StartTime), this, m_StartTime, value)) m_StartTime = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_FadeTime = new AudioGraphNodePort();
		[ContainerField(Name: "FadeTime", Offset: 32, NameHash: 4001222838, Flags: 41)]
		public AudioGraphNodePort FadeTime { get { return m_FadeTime; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(FadeTime), this, m_FadeTime, value)) m_FadeTime = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(Name: "Amplitude", Offset: 40, NameHash: 698564572, Flags: 41)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 48, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x30 (48)
		
		protected GainFaderFadeType m_FadeType = new GainFaderFadeType();
		[ContainerField(Name: "FadeType", Offset: 56, NameHash: 4001206363, Flags: 137)]
		public GainFaderFadeType FadeType { get { return m_FadeType; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(FadeType), this, m_FadeType, value)) m_FadeType = value; } } // 0x38 (56)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(Name: "Plugin", Offset: 60, NameHash: 3384353452, Flags: 41)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("GainFaderNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x3C (60)
		
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

				case 3727579056:
					StartTime = (AudioGraphNodePort) p_Value;
					break;

				case 4001222838:
					FadeTime = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 4001206363:
					FadeType = (GainFaderFadeType) Enum.ToObject(typeof(GainFaderFadeType), p_Value);
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

				case 230748069:
					return Start;

				case 3727579056:
					return StartTime;

				case 4001222838:
					return FadeTime;

				case 698564572:
					return Amplitude;

				case 193453899:
					return Out;

				case 4001206363:
					return FadeType;

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
					return typeof(GainFaderNodeData).GetProperty(nameof(In));

				case 230748069:
					return typeof(GainFaderNodeData).GetProperty(nameof(Start));

				case 3727579056:
					return typeof(GainFaderNodeData).GetProperty(nameof(StartTime));

				case 4001222838:
					return typeof(GainFaderNodeData).GetProperty(nameof(FadeTime));

				case 698564572:
					return typeof(GainFaderNodeData).GetProperty(nameof(Amplitude));

				case 193453899:
					return typeof(GainFaderNodeData).GetProperty(nameof(Out));

				case 4001206363:
					return typeof(GainFaderNodeData).GetProperty(nameof(FadeType));

				case 3384353452:
					return typeof(GainFaderNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
