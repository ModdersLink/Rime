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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class ConsumableTriggerEntityData : 
		TriggerEntityData
	{
		protected ConsumableGroup m_ConsumableGroup = new ConsumableGroup();
		[ContainerField(Name: "ConsumableGroup", Offset: 112, NameHash: 869617913, Flags: 137)]
		public ConsumableGroup ConsumableGroup { get { return m_ConsumableGroup; } set { if (OnPropertyChanging("ConsumableTriggerEntityData." + nameof(ConsumableGroup), this, m_ConsumableGroup, value)) m_ConsumableGroup = value; } } // 0x70 (112)
		
		protected bool m_Persistent = new bool();
		[ContainerField(Name: "Persistent", Offset: 116, NameHash: 125026048, Flags: 49325), LayoutImmutable, Blittable]
		public bool Persistent { get { return m_Persistent; } set { if (OnPropertyChanging("ConsumableTriggerEntityData." + nameof(Persistent), this, m_Persistent, value)) m_Persistent = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 869617913:
					ConsumableGroup = (ConsumableGroup) Enum.ToObject(typeof(ConsumableGroup), p_Value);
					break;

				case 125026048:
					Persistent = (bool) p_Value;
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
				case 869617913:
					return ConsumableGroup;

				case 125026048:
					return Persistent;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 869617913:
					return typeof(ConsumableTriggerEntityData).GetProperty(nameof(ConsumableGroup));

				case 125026048:
					return typeof(ConsumableTriggerEntityData).GetProperty(nameof(Persistent));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
