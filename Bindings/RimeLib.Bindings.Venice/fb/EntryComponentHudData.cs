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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class EntryComponentHudData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int Index { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public EntrySeatType SeatType { get; set; } = new EntrySeatType(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool Frustum { get; set; } // 0x8 (8)
		
		[ContainerField(9), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool Visible { get; set; } // 0x9 (9)
		
		[ContainerField(10), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
