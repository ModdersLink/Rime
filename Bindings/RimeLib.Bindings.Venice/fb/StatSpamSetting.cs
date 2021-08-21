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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class StatSpamSetting : FrostbiteContainer
	{
		[ContainerField(Name: "Event", Offset: 0, NameHash: 201427689, Flags: 137)]
		public StatEvent Event { get; set; } = new StatEvent(); // 0x0 (0)
		
		[ContainerField(Name: "AmountLimit", Offset: 4, NameHash: 4229032540, Flags: 49421), LayoutImmutable, Blittable]
		public uint AmountLimit { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "TimeLimit", Offset: 8, NameHash: 205910853, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeLimit { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "PlayerToPlayer", Offset: 12, NameHash: 2558647998, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlayerToPlayer { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 201427689:
						Event = (StatEvent) Enum.ToObject(typeof(StatEvent), p_Value);
					break;

				case 4229032540:
					AmountLimit = (uint) p_Value;
					break;

				case 205910853:
					TimeLimit = (float) p_Value;
					break;

				case 2558647998:
					PlayerToPlayer = (bool) p_Value;
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
				case 201427689:
					return Event;

				case 4229032540:
					return AmountLimit;

				case 205910853:
					return TimeLimit;

				case 2558647998:
					return PlayerToPlayer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 201427689:
					return typeof(StatSpamSetting).GetProperty(nameof(Event));

				case 4229032540:
					return typeof(StatSpamSetting).GetProperty(nameof(AmountLimit));

				case 205910853:
					return typeof(StatSpamSetting).GetProperty(nameof(TimeLimit));

				case 2558647998:
					return typeof(StatSpamSetting).GetProperty(nameof(PlayerToPlayer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
