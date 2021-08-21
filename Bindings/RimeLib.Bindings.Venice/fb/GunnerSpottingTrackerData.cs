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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class GunnerSpottingTrackerData : 
		HudTrackerData
	{
		protected UIHudIcon m_SpottedInfantryIcon = new UIHudIcon();
		[ContainerField(Name: "SpottedInfantryIcon", Offset: 44, NameHash: 1477348402, Flags: 137)]
		public UIHudIcon SpottedInfantryIcon { get { return m_SpottedInfantryIcon; } set { if (OnPropertyChanging("GunnerSpottingTrackerData." + nameof(SpottedInfantryIcon), this, m_SpottedInfantryIcon, value)) m_SpottedInfantryIcon = value; } } // 0x2C (44)
		
		protected UIHudIcon m_SpottedVehicleIcon = new UIHudIcon();
		[ContainerField(Name: "SpottedVehicleIcon", Offset: 48, NameHash: 1255017979, Flags: 137)]
		public UIHudIcon SpottedVehicleIcon { get { return m_SpottedVehicleIcon; } set { if (OnPropertyChanging("GunnerSpottingTrackerData." + nameof(SpottedVehicleIcon), this, m_SpottedVehicleIcon, value)) m_SpottedVehicleIcon = value; } } // 0x30 (48)
		
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
