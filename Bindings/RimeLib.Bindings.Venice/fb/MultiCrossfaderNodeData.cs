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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class MultiCrossfaderNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<MultiCrossfaderGroup> m_CrossfaderGroups = new RefArray<MultiCrossfaderGroup>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(521495907), ContainerRefArray]
		public RefArray<MultiCrossfaderGroup> CrossfaderGroups { get { return m_CrossfaderGroups; } set { if (OnPropertyChanging("MultiCrossfaderNodeData." + nameof(CrossfaderGroups), this, m_CrossfaderGroups, value)) m_CrossfaderGroups = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(230748069)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("MultiCrossfaderNodeData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Stop = new AudioGraphNodePort();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(2089401213)]
		public AudioGraphNodePort Stop { get { return m_Stop; } set { if (OnPropertyChanging("MultiCrossfaderNodeData." + nameof(Stop), this, m_Stop, value)) m_Stop = value; } } // 0x14 (20)
		
		protected AudioGraphNodePort m_Control = new AudioGraphNodePort();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(3654305890)]
		public AudioGraphNodePort Control { get { return m_Control; } set { if (OnPropertyChanging("MultiCrossfaderNodeData." + nameof(Control), this, m_Control, value)) m_Control = value; } } // 0x1C (28)
		
		protected bool m_LockControlValue = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1905437282)]
		public bool LockControlValue { get { return m_LockControlValue; } set { if (OnPropertyChanging("MultiCrossfaderNodeData." + nameof(LockControlValue), this, m_LockControlValue, value)) m_LockControlValue = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 521495907:
					CrossfaderGroups = (RefArray<MultiCrossfaderGroup>) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 3654305890:
					Control = (AudioGraphNodePort) p_Value;
					break;

				case 1905437282:
					LockControlValue = (bool) p_Value;
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
				case 521495907:
					return CrossfaderGroups;

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 3654305890:
					return Control;

				case 1905437282:
					return LockControlValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 521495907:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(CrossfaderGroups));

				case 230748069:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Stop));

				case 3654305890:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(Control));

				case 1905437282:
					return typeof(MultiCrossfaderNodeData).GetProperty(nameof(LockControlValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
