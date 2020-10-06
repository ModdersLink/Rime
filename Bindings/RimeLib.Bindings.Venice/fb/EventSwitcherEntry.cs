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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class EventSwitcherEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_CaseTrigger = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(394100425)]
		public AudioGraphNodePort CaseTrigger { get { return m_CaseTrigger; } set { if (OnPropertyChanging("EventSwitcherEntry." + nameof(CaseTrigger), this, m_CaseTrigger, value)) m_CaseTrigger = value; } } // 0x8 (8)
		
		protected float m_Value = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(225375086)]
		public float Value { get { return m_Value; } set { if (OnPropertyChanging("EventSwitcherEntry." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 394100425:
					CaseTrigger = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
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
				case 394100425:
					return CaseTrigger;

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
				case 394100425:
					return typeof(EventSwitcherEntry).GetProperty(nameof(CaseTrigger));

				case 225375086:
					return typeof(EventSwitcherEntry).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
