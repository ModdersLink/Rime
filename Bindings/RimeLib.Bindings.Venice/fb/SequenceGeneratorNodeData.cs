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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 56)]
	public class SequenceGeneratorNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(Name: "Trigger", Offset: 8, NameHash: 2606354109, Flags: 41)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Reset = new AudioGraphNodePort();
		[ContainerField(Name: "Reset", Offset: 16, NameHash: 229946160, Flags: 41)]
		public AudioGraphNodePort Reset { get { return m_Reset; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Reset), this, m_Reset, value)) m_Reset = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Min = new AudioGraphNodePort();
		[ContainerField(Name: "Min", Offset: 24, NameHash: 193446607, Flags: 41)]
		public AudioGraphNodePort Min { get { return m_Min; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Max = new AudioGraphNodePort();
		[ContainerField(Name: "Max", Offset: 32, NameHash: 193446865, Flags: 41)]
		public AudioGraphNodePort Max { get { return m_Max; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Step = new AudioGraphNodePort();
		[ContainerField(Name: "Step", Offset: 40, NameHash: 2089400887, Flags: 41)]
		public AudioGraphNodePort Step { get { return m_Step; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Step), this, m_Step, value)) m_Step = value; } } // 0x28 (40)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(Name: "Value", Offset: 48, NameHash: 225375086, Flags: 41)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("SequenceGeneratorNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 229946160:
					Reset = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (AudioGraphNodePort) p_Value;
					break;

				case 193446865:
					Max = (AudioGraphNodePort) p_Value;
					break;

				case 2089400887:
					Step = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
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
				case 2606354109:
					return Trigger;

				case 229946160:
					return Reset;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2089400887:
					return Step;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2606354109:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Trigger));

				case 229946160:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Reset));

				case 193446607:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Max));

				case 2089400887:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Step));

				case 225375086:
					return typeof(SequenceGeneratorNodeData).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
