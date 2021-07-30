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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class Consumable : FrostbiteContainer
	{
		[ContainerField(Name: "Instance", Offset: 0, NameHash: 4152547692, Flags: 49501), LayoutImmutable, Blittable]
		public GUID Instance { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Group", Offset: 16, NameHash: 208130522, Flags: 137)]
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
