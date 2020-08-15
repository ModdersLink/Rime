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
	public class SwitcherNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<SwitcherEntry> m_Outputs = new RefArray<SwitcherEntry>();
		[ContainerField(8), ContainerFieldNameHash(1070022089)]
		public RefArray<SwitcherEntry> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("SwitcherNodeData." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(12), ContainerFieldNameHash(2606354109)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("SwitcherNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(20), ContainerFieldNameHash(225375086)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("SwitcherNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x14 (20)
		
		protected float m_DefaultCaseValue = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3296679953)]
		public float DefaultCaseValue { get { return m_DefaultCaseValue; } set { if (OnPropertyChanging("SwitcherNodeData." + nameof(DefaultCaseValue), this, m_DefaultCaseValue, value)) m_DefaultCaseValue = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1070022089:
					Outputs = (RefArray<SwitcherEntry>) p_Value;
					break;

				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
					break;

				case 3296679953:
					DefaultCaseValue = (float) p_Value;
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
				case 1070022089:
					return Outputs;

				case 2606354109:
					return Trigger;

				case 225375086:
					return Value;

				case 3296679953:
					return DefaultCaseValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1070022089:
					return typeof(SwitcherNodeData).GetProperty(nameof(Outputs));

				case 2606354109:
					return typeof(SwitcherNodeData).GetProperty(nameof(Trigger));

				case 225375086:
					return typeof(SwitcherNodeData).GetProperty(nameof(Value));

				case 3296679953:
					return typeof(SwitcherNodeData).GetProperty(nameof(DefaultCaseValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
