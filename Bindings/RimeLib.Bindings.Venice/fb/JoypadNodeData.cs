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
	public class JoypadNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_LeftAnalogX = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(295917164)]
		public AudioGraphNodePort LeftAnalogX { get { return m_LeftAnalogX; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(LeftAnalogX), this, m_LeftAnalogX, value)) m_LeftAnalogX = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_LeftAnalogY = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(295917165)]
		public AudioGraphNodePort LeftAnalogY { get { return m_LeftAnalogY; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(LeftAnalogY), this, m_LeftAnalogY, value)) m_LeftAnalogY = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_RightAnalogX = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(3320326391)]
		public AudioGraphNodePort RightAnalogX { get { return m_RightAnalogX; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(RightAnalogX), this, m_RightAnalogX, value)) m_RightAnalogX = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_RightAnalogY = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(3320326390)]
		public AudioGraphNodePort RightAnalogY { get { return m_RightAnalogY; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(RightAnalogY), this, m_RightAnalogY, value)) m_RightAnalogY = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_AButton = new AudioGraphNodePort();
		[ContainerField(40), ContainerFieldNameHash(1587158770)]
		public AudioGraphNodePort AButton { get { return m_AButton; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(AButton), this, m_AButton, value)) m_AButton = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_BButton = new AudioGraphNodePort();
		[ContainerField(48), ContainerFieldNameHash(1161921521)]
		public AudioGraphNodePort BButton { get { return m_BButton; } set { if (OnPropertyChanging("JoypadNodeData." + nameof(BButton), this, m_BButton, value)) m_BButton = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 295917164:
					LeftAnalogX = (AudioGraphNodePort) p_Value;
					break;

				case 295917165:
					LeftAnalogY = (AudioGraphNodePort) p_Value;
					break;

				case 3320326391:
					RightAnalogX = (AudioGraphNodePort) p_Value;
					break;

				case 3320326390:
					RightAnalogY = (AudioGraphNodePort) p_Value;
					break;

				case 1587158770:
					AButton = (AudioGraphNodePort) p_Value;
					break;

				case 1161921521:
					BButton = (AudioGraphNodePort) p_Value;
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
				case 295917164:
					return LeftAnalogX;

				case 295917165:
					return LeftAnalogY;

				case 3320326391:
					return RightAnalogX;

				case 3320326390:
					return RightAnalogY;

				case 1587158770:
					return AButton;

				case 1161921521:
					return BButton;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 295917164:
					return typeof(JoypadNodeData).GetProperty(nameof(LeftAnalogX));

				case 295917165:
					return typeof(JoypadNodeData).GetProperty(nameof(LeftAnalogY));

				case 3320326391:
					return typeof(JoypadNodeData).GetProperty(nameof(RightAnalogX));

				case 3320326390:
					return typeof(JoypadNodeData).GetProperty(nameof(RightAnalogY));

				case 1587158770:
					return typeof(JoypadNodeData).GetProperty(nameof(AButton));

				case 1161921521:
					return typeof(JoypadNodeData).GetProperty(nameof(BButton));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
