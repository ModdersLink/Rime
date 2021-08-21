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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 116)]
	public class FlatOutputNodeData : 
		OutputNodeData
	{
		protected float m_Angle = new float();
		[ContainerField(Name: "Angle", Offset: 80, NameHash: 205597860, Flags: 49469), LayoutImmutable, Blittable]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0x50 (80)
		
		protected float m_ReverbGain = new float();
		[ContainerField(Name: "ReverbGain", Offset: 84, NameHash: 622241232, Flags: 49469), LayoutImmutable, Blittable]
		public float ReverbGain { get { return m_ReverbGain; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(ReverbGain), this, m_ReverbGain, value)) m_ReverbGain = value; } } // 0x54 (84)
		
		protected CtrRef<SoundBusData> m_ReverbSend = new CtrRef<SoundBusData>();
		[ContainerField(Name: "ReverbSend", Offset: 88, NameHash: 621526765, Flags: 53)]
		public CtrRef<SoundBusData> ReverbSend { get { return m_ReverbSend; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(ReverbSend), this, m_ReverbSend, value)) m_ReverbSend = value; } } // 0x58 (88)
		
		protected AudioGraphNodePort m_CenterLevel = new AudioGraphNodePort();
		[ContainerField(Name: "CenterLevel", Offset: 92, NameHash: 3914160568, Flags: 41)]
		public AudioGraphNodePort CenterLevel { get { return m_CenterLevel; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(CenterLevel), this, m_CenterLevel, value)) m_CenterLevel = value; } } // 0x5C (92)
		
		protected AudioGraphNodePort m_LfeLevel = new AudioGraphNodePort();
		[ContainerField(Name: "LfeLevel", Offset: 100, NameHash: 2374965052, Flags: 41)]
		public AudioGraphNodePort LfeLevel { get { return m_LfeLevel; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(LfeLevel), this, m_LfeLevel, value)) m_LfeLevel = value; } } // 0x64 (100)
		
		protected SoundGraphPluginRef m_PanPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "PanPlugin", Offset: 108, NameHash: 941445235, Flags: 41)]
		public SoundGraphPluginRef PanPlugin { get { return m_PanPlugin; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(PanPlugin), this, m_PanPlugin, value)) m_PanPlugin = value; } } // 0x6C (108)
		
		protected SoundGraphPluginRef m_ReverbSendPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "ReverbSendPlugin", Offset: 111, NameHash: 823182532, Flags: 41)]
		public SoundGraphPluginRef ReverbSendPlugin { get { return m_ReverbSendPlugin; } set { if (OnPropertyChanging("FlatOutputNodeData." + nameof(ReverbSendPlugin), this, m_ReverbSendPlugin, value)) m_ReverbSendPlugin = value; } } // 0x6F (111)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205597860:
					Angle = (float) p_Value;
					break;

				case 622241232:
					ReverbGain = (float) p_Value;
					break;

				case 621526765:
					ReverbSend = (CtrRef<SoundBusData>) p_Value;
					break;

				case 3914160568:
					CenterLevel = (AudioGraphNodePort) p_Value;
					break;

				case 2374965052:
					LfeLevel = (AudioGraphNodePort) p_Value;
					break;

				case 941445235:
					PanPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 823182532:
					ReverbSendPlugin = (SoundGraphPluginRef) p_Value;
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
				case 205597860:
					return Angle;

				case 622241232:
					return ReverbGain;

				case 621526765:
					return ReverbSend;

				case 3914160568:
					return CenterLevel;

				case 2374965052:
					return LfeLevel;

				case 941445235:
					return PanPlugin;

				case 823182532:
					return ReverbSendPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205597860:
					return typeof(FlatOutputNodeData).GetProperty(nameof(Angle));

				case 622241232:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbGain));

				case 621526765:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbSend));

				case 3914160568:
					return typeof(FlatOutputNodeData).GetProperty(nameof(CenterLevel));

				case 2374965052:
					return typeof(FlatOutputNodeData).GetProperty(nameof(LfeLevel));

				case 941445235:
					return typeof(FlatOutputNodeData).GetProperty(nameof(PanPlugin));

				case 823182532:
					return typeof(FlatOutputNodeData).GetProperty(nameof(ReverbSendPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
