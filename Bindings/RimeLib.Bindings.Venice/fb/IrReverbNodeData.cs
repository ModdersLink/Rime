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
	public class IrReverbNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Reverb0 = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(1309052001)]
		public AudioGraphNodePort Reverb0 { get { return m_Reverb0; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(Reverb0), this, m_Reverb0, value)) m_Reverb0 = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Amplitude0 = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(1577794412)]
		public AudioGraphNodePort Amplitude0 { get { return m_Amplitude0; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(Amplitude0), this, m_Amplitude0, value)) m_Amplitude0 = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Reverb1 = new AudioGraphNodePort();
		[ContainerField(40), ContainerFieldNameHash(1309052000)]
		public AudioGraphNodePort Reverb1 { get { return m_Reverb1; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(Reverb1), this, m_Reverb1, value)) m_Reverb1 = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Amplitude1 = new AudioGraphNodePort();
		[ContainerField(48), ContainerFieldNameHash(1577794413)]
		public AudioGraphNodePort Amplitude1 { get { return m_Amplitude1; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(Amplitude1), this, m_Amplitude1, value)) m_Amplitude1 = value; } } // 0x30 (48)
		
		protected float m_MaxReverbLength = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(812921689)]
		public float MaxReverbLength { get { return m_MaxReverbLength; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(MaxReverbLength), this, m_MaxReverbLength, value)) m_MaxReverbLength = value; } } // 0x38 (56)
		
		protected SoundGraphPluginRef m_ReverbPlugin = new SoundGraphPluginRef();
		[ContainerField(60), ContainerFieldNameHash(2571271960)]
		public SoundGraphPluginRef ReverbPlugin { get { return m_ReverbPlugin; } set { if (OnPropertyChanging("IrReverbNodeData." + nameof(ReverbPlugin), this, m_ReverbPlugin, value)) m_ReverbPlugin = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 1309052001:
					Reverb0 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794412:
					Amplitude0 = (AudioGraphNodePort) p_Value;
					break;

				case 1309052000:
					Reverb1 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794413:
					Amplitude1 = (AudioGraphNodePort) p_Value;
					break;

				case 812921689:
					MaxReverbLength = (float) p_Value;
					break;

				case 2571271960:
					ReverbPlugin = (SoundGraphPluginRef) p_Value;
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

				case 193453899:
					return Out;

				case 1309052001:
					return Reverb0;

				case 1577794412:
					return Amplitude0;

				case 1309052000:
					return Reverb1;

				case 1577794413:
					return Amplitude1;

				case 812921689:
					return MaxReverbLength;

				case 2571271960:
					return ReverbPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(IrReverbNodeData).GetProperty(nameof(In));

				case 193453899:
					return typeof(IrReverbNodeData).GetProperty(nameof(Out));

				case 1309052001:
					return typeof(IrReverbNodeData).GetProperty(nameof(Reverb0));

				case 1577794412:
					return typeof(IrReverbNodeData).GetProperty(nameof(Amplitude0));

				case 1309052000:
					return typeof(IrReverbNodeData).GetProperty(nameof(Reverb1));

				case 1577794413:
					return typeof(IrReverbNodeData).GetProperty(nameof(Amplitude1));

				case 812921689:
					return typeof(IrReverbNodeData).GetProperty(nameof(MaxReverbLength));

				case 2571271960:
					return typeof(IrReverbNodeData).GetProperty(nameof(ReverbPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
