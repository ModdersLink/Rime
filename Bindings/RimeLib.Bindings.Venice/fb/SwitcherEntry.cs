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
	public class SwitcherEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_CaseTrigger = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(394100425)]
		public AudioGraphNodePort CaseTrigger { get { return m_CaseTrigger; } set { if (OnPropertyChanging("SwitcherEntry." + nameof(CaseTrigger), this, m_CaseTrigger, value)) m_CaseTrigger = value; } } // 0x8 (8)
		
		protected float m_CaseValue = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(723060122)]
		public float CaseValue { get { return m_CaseValue; } set { if (OnPropertyChanging("SwitcherEntry." + nameof(CaseValue), this, m_CaseValue, value)) m_CaseValue = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 394100425:
					CaseTrigger = (AudioGraphNodePort) p_Value;
					break;

				case 723060122:
					CaseValue = (float) p_Value;
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

				case 723060122:
					return CaseValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 394100425:
					return typeof(SwitcherEntry).GetProperty(nameof(CaseTrigger));

				case 723060122:
					return typeof(SwitcherEntry).GetProperty(nameof(CaseValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
