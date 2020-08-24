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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class DelayTriggerEntityData : 
		TriggerEventEntityData
	{
		protected bool m_AutoTriggerEvent = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2983396190)]
		public bool AutoTriggerEvent { get { return m_AutoTriggerEvent; } set { if (OnPropertyChanging("DelayTriggerEntityData." + nameof(AutoTriggerEvent), this, m_AutoTriggerEvent, value)) m_AutoTriggerEvent = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2983396190:
					AutoTriggerEvent = (bool) p_Value;
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
				case 2983396190:
					return AutoTriggerEvent;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2983396190:
					return typeof(DelayTriggerEntityData).GetProperty(nameof(AutoTriggerEvent));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
