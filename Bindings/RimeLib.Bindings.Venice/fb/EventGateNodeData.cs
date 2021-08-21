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
	public class EventGateNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("EventGateNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 16, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("EventGateNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_CoolDownTime = new AudioGraphNodePort();
		[ContainerField(Name: "CoolDownTime", Offset: 24, NameHash: 282296301, Flags: 41)]
		public AudioGraphNodePort CoolDownTime { get { return m_CoolDownTime; } set { if (OnPropertyChanging("EventGateNodeData." + nameof(CoolDownTime), this, m_CoolDownTime, value)) m_CoolDownTime = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Enable = new AudioGraphNodePort();
		[ContainerField(Name: "Enable", Offset: 32, NameHash: 2342790116, Flags: 41)]
		public AudioGraphNodePort Enable { get { return m_Enable; } set { if (OnPropertyChanging("EventGateNodeData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x20 (32)
		
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

				case 282296301:
					CoolDownTime = (AudioGraphNodePort) p_Value;
					break;

				case 2342790116:
					Enable = (AudioGraphNodePort) p_Value;
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

				case 282296301:
					return CoolDownTime;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(EventGateNodeData).GetProperty(nameof(In));

				case 193453899:
					return typeof(EventGateNodeData).GetProperty(nameof(Out));

				case 282296301:
					return typeof(EventGateNodeData).GetProperty(nameof(CoolDownTime));

				case 2342790116:
					return typeof(EventGateNodeData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
