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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class MinMaxValueSelectorNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<MinMaxValueSelectorEntry> m_Inputs = new RefArray<MinMaxValueSelectorEntry>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(2784267136), ContainerRefArray]
		public RefArray<MinMaxValueSelectorEntry> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("MinMaxValueSelectorNodeData." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_MaxValue = new AudioGraphNodePort();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(408516922)]
		public AudioGraphNodePort MaxValue { get { return m_MaxValue; } set { if (OnPropertyChanging("MinMaxValueSelectorNodeData." + nameof(MaxValue), this, m_MaxValue, value)) m_MaxValue = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_MaxIndex = new AudioGraphNodePort();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(426400079)]
		public AudioGraphNodePort MaxIndex { get { return m_MaxIndex; } set { if (OnPropertyChanging("MinMaxValueSelectorNodeData." + nameof(MaxIndex), this, m_MaxIndex, value)) m_MaxIndex = value; } } // 0x14 (20)
		
		protected AudioGraphNodePort m_MinValue = new AudioGraphNodePort();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(3371854436)]
		public AudioGraphNodePort MinValue { get { return m_MinValue; } set { if (OnPropertyChanging("MinMaxValueSelectorNodeData." + nameof(MinValue), this, m_MinValue, value)) m_MinValue = value; } } // 0x1C (28)
		
		protected AudioGraphNodePort m_MinIndex = new AudioGraphNodePort();
		[ContainerField(36), MemberInfoFlag(41), ContainerFieldNameHash(3347206417)]
		public AudioGraphNodePort MinIndex { get { return m_MinIndex; } set { if (OnPropertyChanging("MinMaxValueSelectorNodeData." + nameof(MinIndex), this, m_MinIndex, value)) m_MinIndex = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<MinMaxValueSelectorEntry>) p_Value;
					break;

				case 408516922:
					MaxValue = (AudioGraphNodePort) p_Value;
					break;

				case 426400079:
					MaxIndex = (AudioGraphNodePort) p_Value;
					break;

				case 3371854436:
					MinValue = (AudioGraphNodePort) p_Value;
					break;

				case 3347206417:
					MinIndex = (AudioGraphNodePort) p_Value;
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

				case 408516922:
					return MaxValue;

				case 426400079:
					return MaxIndex;

				case 3371854436:
					return MinValue;

				case 3347206417:
					return MinIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(Inputs));

				case 408516922:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MaxValue));

				case 426400079:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MaxIndex));

				case 3371854436:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MinValue));

				case 3347206417:
					return typeof(MinMaxValueSelectorNodeData).GetProperty(nameof(MinIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
