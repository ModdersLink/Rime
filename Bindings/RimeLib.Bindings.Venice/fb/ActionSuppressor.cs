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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class ActionSuppressor : FrostbiteContainer
	{
		[ContainerField(Name: "ActionToSuppress", Offset: 0, NameHash: 3644641713, Flags: 137)]
		public EntryInputActionEnum ActionToSuppress { get; set; } = new EntryInputActionEnum(); // 0x0 (0)
		
		[ContainerField(Name: "SuppressingValue", Offset: 4, NameHash: 390019807, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressingValue { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3644641713:
						ActionToSuppress = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 390019807:
					SuppressingValue = (float) p_Value;
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
				case 3644641713:
					return ActionToSuppress;

				case 390019807:
					return SuppressingValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3644641713:
					return typeof(ActionSuppressor).GetProperty(nameof(ActionToSuppress));

				case 390019807:
					return typeof(ActionSuppressor).GetProperty(nameof(SuppressingValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
