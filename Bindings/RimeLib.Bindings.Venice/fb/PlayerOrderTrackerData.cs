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
	public class PlayerOrderTrackerData : 
		HudTrackerData
	{
		[ContainerField(44)]
		public UIHudIcon AttackIcon { get; set; } = new UIHudIcon(); // 0x2C (44)
		
		[ContainerField(48)]
		public UIHudIcon DefendIcon { get; set; } = new UIHudIcon(); // 0x30 (48)
		
		[ContainerField(52)]
		public UIHudIcon MoveToIcon { get; set; } = new UIHudIcon(); // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1150263942:
					AttackIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2423818630:
					DefendIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2367850372:
					MoveToIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
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
				case 1150263942:
					return AttackIcon;

				case 2423818630:
					return DefendIcon;

				case 2367850372:
					return MoveToIcon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1150263942:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(AttackIcon));

				case 2423818630:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(DefendIcon));

				case 2367850372:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(MoveToIcon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
