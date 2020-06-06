///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ConsumableTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112)]
		public ConsumableGroup ConsumableGroup { get; set; } = new ConsumableGroup(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool Persistent { get; set; } // 0x74 (116)
		
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
