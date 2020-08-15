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
	public class IrReverbControllerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Reverb0 = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(1309052001)]
		public AudioGraphNodePort Reverb0 { get { return m_Reverb0; } set { if (OnPropertyChanging("IrReverbControllerNodeData." + nameof(Reverb0), this, m_Reverb0, value)) m_Reverb0 = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Amplitude0 = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(1577794412)]
		public AudioGraphNodePort Amplitude0 { get { return m_Amplitude0; } set { if (OnPropertyChanging("IrReverbControllerNodeData." + nameof(Amplitude0), this, m_Amplitude0, value)) m_Amplitude0 = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Reverb1 = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(1309052000)]
		public AudioGraphNodePort Reverb1 { get { return m_Reverb1; } set { if (OnPropertyChanging("IrReverbControllerNodeData." + nameof(Reverb1), this, m_Reverb1, value)) m_Reverb1 = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Amplitude1 = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(1577794413)]
		public AudioGraphNodePort Amplitude1 { get { return m_Amplitude1; } set { if (OnPropertyChanging("IrReverbControllerNodeData." + nameof(Amplitude1), this, m_Amplitude1, value)) m_Amplitude1 = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
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

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1309052001:
					return Reverb0;

				case 1577794412:
					return Amplitude0;

				case 1309052000:
					return Reverb1;

				case 1577794413:
					return Amplitude1;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1309052001:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Reverb0));

				case 1577794412:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Amplitude0));

				case 1309052000:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Reverb1));

				case 1577794413:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Amplitude1));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
