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
	public class TimerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(230748069)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Stop = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(2089401213)]
		public AudioGraphNodePort Stop { get { return m_Stop; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Stop), this, m_Stop, value)) m_Stop = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Period = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(3366831232)]
		public AudioGraphNodePort Period { get { return m_Period; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Period), this, m_Period, value)) m_Period = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Tick = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(2089313808)]
		public AudioGraphNodePort Tick { get { return m_Tick; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Tick), this, m_Tick, value)) m_Tick = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Progress = new AudioGraphNodePort();
		[ContainerField(40), ContainerFieldNameHash(3002510520)]
		public AudioGraphNodePort Progress { get { return m_Progress; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Progress), this, m_Progress, value)) m_Progress = value; } } // 0x28 (40)
		
		protected TimerMode m_Mode = new TimerMode();
		[ContainerField(48), ContainerFieldNameHash(2088772358)]
		public TimerMode Mode { get { return m_Mode; } set { if (OnPropertyChanging("TimerNodeData." + nameof(Mode), this, m_Mode, value)) m_Mode = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 3366831232:
					Period = (AudioGraphNodePort) p_Value;
					break;

				case 2089313808:
					Tick = (AudioGraphNodePort) p_Value;
					break;

				case 3002510520:
					Progress = (AudioGraphNodePort) p_Value;
					break;

				case 2088772358:
					Mode = (TimerMode) Enum.ToObject(typeof(TimerMode), p_Value);
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
				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 3366831232:
					return Period;

				case 2089313808:
					return Tick;

				case 3002510520:
					return Progress;

				case 2088772358:
					return Mode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230748069:
					return typeof(TimerNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(TimerNodeData).GetProperty(nameof(Stop));

				case 3366831232:
					return typeof(TimerNodeData).GetProperty(nameof(Period));

				case 2089313808:
					return typeof(TimerNodeData).GetProperty(nameof(Tick));

				case 3002510520:
					return typeof(TimerNodeData).GetProperty(nameof(Progress));

				case 2088772358:
					return typeof(TimerNodeData).GetProperty(nameof(Mode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
