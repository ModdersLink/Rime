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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class EntryComponentHudData : FrostbiteContainer
	{
		[ContainerField(Name: "Index", Offset: 0, NameHash: 214509467, Flags: 49405), LayoutImmutable, Blittable]
		public int Index { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SeatType", Offset: 4, NameHash: 1128962654, Flags: 137)]
		public EntrySeatType SeatType { get; set; } = new EntrySeatType(); // 0x4 (4)
		
		[ContainerField(Name: "Frustum", Offset: 8, NameHash: 2068536187, Flags: 49325), LayoutImmutable, Blittable]
		public bool Frustum { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "Visible", Offset: 9, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x9 (9)
		
		[ContainerField(Name: "MaximizeMiniMapOnEntry", Offset: 10, NameHash: 2821599657, Flags: 49325), LayoutImmutable, Blittable]
		public bool MaximizeMiniMapOnEntry { get; set; } // 0xA (10)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 214509467:
					Index = (int) p_Value;
					break;

				case 1128962654:
						SeatType = (EntrySeatType) Enum.ToObject(typeof(EntrySeatType), p_Value);
					break;

				case 2068536187:
					Frustum = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 2821599657:
					MaximizeMiniMapOnEntry = (bool) p_Value;
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
				case 214509467:
					return Index;

				case 1128962654:
					return SeatType;

				case 2068536187:
					return Frustum;

				case 901540267:
					return Visible;

				case 2821599657:
					return MaximizeMiniMapOnEntry;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 214509467:
					return typeof(EntryComponentHudData).GetProperty(nameof(Index));

				case 1128962654:
					return typeof(EntryComponentHudData).GetProperty(nameof(SeatType));

				case 2068536187:
					return typeof(EntryComponentHudData).GetProperty(nameof(Frustum));

				case 901540267:
					return typeof(EntryComponentHudData).GetProperty(nameof(Visible));

				case 2821599657:
					return typeof(EntryComponentHudData).GetProperty(nameof(MaximizeMiniMapOnEntry));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
