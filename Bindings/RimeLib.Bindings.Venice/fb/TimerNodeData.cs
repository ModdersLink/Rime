///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TimerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Stop { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Period { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Tick { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort Progress { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public TimerMode Mode { get; set; } = new TimerMode(); // 0x30 (48)
		
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
