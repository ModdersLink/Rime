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
	public class GunnerSpottingTrackerData : 
		HudTrackerData
	{
		[ContainerField(44)]
		public UIHudIcon SpottedInfantryIcon { get; set; } = new UIHudIcon(); // 0x2C (44)
		
		[ContainerField(48)]
		public UIHudIcon SpottedVehicleIcon { get; set; } = new UIHudIcon(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1477348402:
					SpottedInfantryIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1255017979:
					SpottedVehicleIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
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
				case 1477348402:
					return SpottedInfantryIcon;

				case 1255017979:
					return SpottedVehicleIcon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1477348402:
					return typeof(GunnerSpottingTrackerData).GetProperty(nameof(SpottedInfantryIcon));

				case 1255017979:
					return typeof(GunnerSpottingTrackerData).GetProperty(nameof(SpottedVehicleIcon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
