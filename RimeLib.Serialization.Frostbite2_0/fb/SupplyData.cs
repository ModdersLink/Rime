///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 44)]
	public partial class SupplyData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private SupplyUnitSphereData _Healing = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private SupplyUnitSphereData _Ammo = new();
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _SupplyVehicles;
		
		[ObservableProperty]
		[property: ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		private bool _SupplySoldiers;
		
		[ObservableProperty]
		[property: ContainerField(42), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
		private bool _TeamSpecific;
		
		[ObservableProperty]
		[property: ContainerField(43), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
		private bool _ExcludeSelf;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Healing.Serialize(p_Writer, p_EbxWriter);
			Ammo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SupplyVehicles);
			p_Writer.Write(SupplySoldiers);
			p_Writer.Write(TeamSpecific);
			p_Writer.Write(ExcludeSelf);
		}
	}
}
