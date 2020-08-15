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
	public class ConditionNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<ConditionGroup> m_Conditions = new RefArray<ConditionGroup>();
		[ContainerField(8), ContainerFieldNameHash(3586042181)]
		public RefArray<ConditionGroup> Conditions { get { return m_Conditions; } set { if (OnPropertyChanging("ConditionNodeData." + nameof(Conditions), this, m_Conditions, value)) m_Conditions = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3586042181:
					Conditions = (RefArray<ConditionGroup>) p_Value;
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
				case 3586042181:
					return Conditions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3586042181:
					return typeof(ConditionNodeData).GetProperty(nameof(Conditions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
