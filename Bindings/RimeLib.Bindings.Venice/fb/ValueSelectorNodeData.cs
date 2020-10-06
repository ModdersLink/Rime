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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class ValueSelectorNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<ValueSelectorEntry> m_Inputs = new RefArray<ValueSelectorEntry>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(2784267136), ContainerRefArray]
		public RefArray<ValueSelectorEntry> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(225375086)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ValueSelectorNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x14 (20)
		
		protected float m_DefaultCaseValue = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3296679953)]
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
