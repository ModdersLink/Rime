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
    [ContainerType(4)]
	public class Consumable : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public GUID Instance { get; set; } // 0x0 (0)
		
		[ContainerField(16)]
		public ConsumableGroup Group { get; set; } = new ConsumableGroup(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4152547692:
					Instance = (GUID) p_Value;
					break;

				case 208130522:
						Group = (ConsumableGroup) Enum.ToObject(typeof(ConsumableGroup), p_Value);
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
				case 4152547692:
					return Instance;

				case 208130522:
					return Group;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4152547692:
					return typeof(Consumable).GetProperty(nameof(Instance));

				case 208130522:
					return typeof(Consumable).GetProperty(nameof(Group));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
