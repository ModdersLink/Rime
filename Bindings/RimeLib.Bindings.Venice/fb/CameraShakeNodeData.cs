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
	public class CameraShakeNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Pitch = new AudioGraphNodePort();
		[ContainerField(Name: "Pitch", Offset: 8, NameHash: 232604323, Flags: 41)]
		public AudioGraphNodePort Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("CameraShakeNodeData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Yaw = new AudioGraphNodePort();
		[ContainerField(Name: "Yaw", Offset: 16, NameHash: 193468618, Flags: 41)]
		public AudioGraphNodePort Yaw { get { return m_Yaw; } set { if (OnPropertyChanging("CameraShakeNodeData." + nameof(Yaw), this, m_Yaw, value)) m_Yaw = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Roll = new AudioGraphNodePort();
		[ContainerField(Name: "Roll", Offset: 24, NameHash: 2089387576, Flags: 41)]
		public AudioGraphNodePort Roll { get { return m_Roll; } set { if (OnPropertyChanging("CameraShakeNodeData." + nameof(Roll), this, m_Roll, value)) m_Roll = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232604323:
					Pitch = (AudioGraphNodePort) p_Value;
					break;

				case 193468618:
					Yaw = (AudioGraphNodePort) p_Value;
					break;

				case 2089387576:
					Roll = (AudioGraphNodePort) p_Value;
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
				case 232604323:
					return Pitch;

				case 193468618:
					return Yaw;

				case 2089387576:
					return Roll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232604323:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Pitch));

				case 193468618:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Yaw));

				case 2089387576:
					return typeof(CameraShakeNodeData).GetProperty(nameof(Roll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
