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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 4)]
	public class PersistenceConsumableMapping : FrostbiteContainer
	{
		[ContainerField(Name: "Group", Offset: 0, NameHash: 208130522, Flags: 137)]
		public ConsumableGroup Group { get; set; } = new ConsumableGroup(); // 0x0 (0)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
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
				case 208130522:
					return typeof(PersistenceConsumableMapping).GetProperty(nameof(Group));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
