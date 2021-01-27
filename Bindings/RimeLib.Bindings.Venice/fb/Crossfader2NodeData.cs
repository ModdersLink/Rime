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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class Crossfader2NodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Ctrl = new AudioGraphNodePort();
		[ContainerField(Name: "Ctrl", Offset: 8, NameHash: 2088859916, Flags: 41)]
		public AudioGraphNodePort Ctrl { get { return m_Ctrl; } set { if (OnPropertyChanging("Crossfader2NodeData." + nameof(Ctrl), this, m_Ctrl, value)) m_Ctrl = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_CtrlOut1 = new AudioGraphNodePort();
		[ContainerField(Name: "CtrlOut1", Offset: 16, NameHash: 1670261395, Flags: 41)]
		public AudioGraphNodePort CtrlOut1 { get { return m_CtrlOut1; } set { if (OnPropertyChanging("Crossfader2NodeData." + nameof(CtrlOut1), this, m_CtrlOut1, value)) m_CtrlOut1 = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_CtrlOut2 = new AudioGraphNodePort();
		[ContainerField(Name: "CtrlOut2", Offset: 24, NameHash: 1670261392, Flags: 41)]
		public AudioGraphNodePort CtrlOut2 { get { return m_CtrlOut2; } set { if (OnPropertyChanging("Crossfader2NodeData." + nameof(CtrlOut2), this, m_CtrlOut2, value)) m_CtrlOut2 = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088859916:
					Ctrl = (AudioGraphNodePort) p_Value;
					break;

				case 1670261395:
					CtrlOut1 = (AudioGraphNodePort) p_Value;
					break;

				case 1670261392:
					CtrlOut2 = (AudioGraphNodePort) p_Value;
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
				case 2088859916:
					return Ctrl;

				case 1670261395:
					return CtrlOut1;

				case 1670261392:
					return CtrlOut2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088859916:
					return typeof(Crossfader2NodeData).GetProperty(nameof(Ctrl));

				case 1670261395:
					return typeof(Crossfader2NodeData).GetProperty(nameof(CtrlOut1));

				case 1670261392:
					return typeof(Crossfader2NodeData).GetProperty(nameof(CtrlOut2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
