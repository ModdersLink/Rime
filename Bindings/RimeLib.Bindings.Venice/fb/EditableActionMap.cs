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
	public class EditableActionMap : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Id { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string NameId { get; set; } // 0x4 (4)
		
		[ContainerField(8)]
		public CtrRef<EntryInputActionMapsData> ActionMap { get; set; } = new CtrRef<EntryInputActionMapsData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public EditableActions ConfigurationLayout { get; set; } = new EditableActions(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862152:
					Id = (string) p_Value;
					break;

				case 2828728719:
					NameId = (string) p_Value;
					break;

				case 3027251111:
					ActionMap = (CtrRef<EntryInputActionMapsData>) p_Value;
					break;

				case 3332287471:
					ConfigurationLayout = (EditableActions) p_Value;
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
				case 5862152:
					return Id;

				case 2828728719:
					return NameId;

				case 3027251111:
					return ActionMap;

				case 3332287471:
					return ConfigurationLayout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862152:
					return typeof(EditableActionMap).GetProperty(nameof(Id));

				case 2828728719:
					return typeof(EditableActionMap).GetProperty(nameof(NameId));

				case 3027251111:
					return typeof(EditableActionMap).GetProperty(nameof(ActionMap));

				case 3332287471:
					return typeof(EditableActionMap).GetProperty(nameof(ConfigurationLayout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
