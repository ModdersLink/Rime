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
	public class ValueSelectorNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<ValueSelectorEntry> m_Inputs = new RefArray<ValueSelectorEntry>();
		[ContainerField(Name: "Inputs", Offset: 8, NameHash: 2784267136, Flags: 65)]
		public RefArray<ValueSelectorEntry> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(Name: "Value", Offset: 12, NameHash: 225375086, Flags: 41)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 20, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x14 (20)
		
		protected float m_DefaultCaseValue = new float();
		[ContainerField(Name: "DefaultCaseValue", Offset: 28, NameHash: 3296679953, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultCaseValue { get { return m_DefaultCaseValue; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(DefaultCaseValue), this, m_DefaultCaseValue, value)) m_DefaultCaseValue = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<ValueSelectorEntry>) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 2784267136:
					return Inputs;

				case 225375086:
					return Value;

				case 193453899:
					return Out;

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
				case 2784267136:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Inputs));

				case 225375086:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Value));

				case 193453899:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(Out));

				case 3296679953:
					return typeof(ValueSelectorNodeData).GetProperty(nameof(DefaultCaseValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
