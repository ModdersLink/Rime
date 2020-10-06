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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class SimpleValueSelectorNodeData : 
		AudioGraphNodeData
	{
		protected List<float> m_OutValues = new List<float>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(2730967827), ContainerArray]
		public List<float> OutValues { get { return m_OutValues; } set { if (OnPropertyChanging("SimpleValueSelectorNodeData." + nameof(OutValues), this, m_OutValues, value)) m_OutValues = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Index = new AudioGraphNodePort();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(214509467)]
		public AudioGraphNodePort Index { get { return m_Index; } set { if (OnPropertyChanging("SimpleValueSelectorNodeData." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("SimpleValueSelectorNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2730967827:
					OutValues = (List<float>) p_Value;
					break;

				case 214509467:
					Index = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 2730967827:
					return OutValues;

				case 214509467:
					return Index;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2730967827:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(OutValues));

				case 214509467:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(Index));

				case 193453899:
					return typeof(SimpleValueSelectorNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
