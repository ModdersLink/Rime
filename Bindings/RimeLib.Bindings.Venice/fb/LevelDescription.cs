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
	public class LevelDescription : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Description", Offset: 4, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Components", Offset: 8, NameHash: 3391050425, Flags: 65)]
		public RefArray<LevelDescriptionComponent> Components { get; set; } = new RefArray<LevelDescriptionComponent>(); // 0x8 (8)
		
		[ContainerField(Name: "IsCoop", Offset: 12, NameHash: 2816971820, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsCoop { get; set; } // 0xC (12)
		
		[ContainerField(Name: "IsMenu", Offset: 13, NameHash: 2816483916, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsMenu { get; set; } // 0xD (13)
		
		[ContainerField(Name: "IsMultiplayer", Offset: 14, NameHash: 3764930757, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsMultiplayer { get; set; } // 0xE (14)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1636673251:
					Description = (string) p_Value;
					break;

				case 3391050425:
					Components = (RefArray<LevelDescriptionComponent>) p_Value;
					break;

				case 2816971820:
					IsCoop = (bool) p_Value;
					break;

				case 2816483916:
					IsMenu = (bool) p_Value;
					break;

				case 3764930757:
					IsMultiplayer = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 1636673251:
					return Description;

				case 3391050425:
					return Components;

				case 2816971820:
					return IsCoop;

				case 2816483916:
					return IsMenu;

				case 3764930757:
					return IsMultiplayer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(LevelDescription).GetProperty(nameof(Name));

				case 1636673251:
					return typeof(LevelDescription).GetProperty(nameof(Description));

				case 3391050425:
					return typeof(LevelDescription).GetProperty(nameof(Components));

				case 2816971820:
					return typeof(LevelDescription).GetProperty(nameof(IsCoop));

				case 2816483916:
					return typeof(LevelDescription).GetProperty(nameof(IsMenu));

				case 3764930757:
					return typeof(LevelDescription).GetProperty(nameof(IsMultiplayer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
