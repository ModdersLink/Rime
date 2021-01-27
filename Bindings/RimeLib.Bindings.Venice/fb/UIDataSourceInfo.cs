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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class UIDataSourceInfo : FrostbiteContainer
	{
		[ContainerField(Name: "DataName", Offset: 0, NameHash: 3250054578, Flags: 16509), LayoutImmutable]
		public string DataName { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "DataCategory", Offset: 4, NameHash: 4099955781, Flags: 53)]
		public CtrRef<UIComponentData> DataCategory { get; set; } = new CtrRef<UIComponentData>(); // 0x4 (4)
		
		[ContainerField(Name: "DataKey", Offset: 8, NameHash: 3872856866, Flags: 49405), LayoutImmutable, Blittable]
		public int DataKey { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "UseDirectAccess", Offset: 12, NameHash: 3627000399, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseDirectAccess { get; set; } // 0xC (12)
		
		[ContainerField(Name: "UpdateOnInitialize", Offset: 13, NameHash: 455979421, Flags: 49325), LayoutImmutable, Blittable]
		public bool UpdateOnInitialize { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3250054578:
					DataName = (string) p_Value;
					break;

				case 4099955781:
					DataCategory = (CtrRef<UIComponentData>) p_Value;
					break;

				case 3872856866:
					DataKey = (int) p_Value;
					break;

				case 3627000399:
					UseDirectAccess = (bool) p_Value;
					break;

				case 455979421:
					UpdateOnInitialize = (bool) p_Value;
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
				case 3250054578:
					return DataName;

				case 4099955781:
					return DataCategory;

				case 3872856866:
					return DataKey;

				case 3627000399:
					return UseDirectAccess;

				case 455979421:
					return UpdateOnInitialize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3250054578:
					return typeof(UIDataSourceInfo).GetProperty(nameof(DataName));

				case 4099955781:
					return typeof(UIDataSourceInfo).GetProperty(nameof(DataCategory));

				case 3872856866:
					return typeof(UIDataSourceInfo).GetProperty(nameof(DataKey));

				case 3627000399:
					return typeof(UIDataSourceInfo).GetProperty(nameof(UseDirectAccess));

				case 455979421:
					return typeof(UIDataSourceInfo).GetProperty(nameof(UpdateOnInitialize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
