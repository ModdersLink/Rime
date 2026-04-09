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
	[ContainerType(1, 6)]
	public partial class InteractionTypesData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private bool _InteractionEntity;
		
		[ObservableProperty]
		[property: ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		private bool _PickupEntity;
		
		[ObservableProperty]
		[property: ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		private bool _AmmoCrateEntity;
		
		[ObservableProperty]
		[property: ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		private bool _VehicleEntity;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private bool _ExplosionPackEntity;
		
		[ObservableProperty]
		[property: ContainerField(5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
		private bool _SoldierEntity;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InteractionEntity);
			p_Writer.Write(PickupEntity);
			p_Writer.Write(AmmoCrateEntity);
			p_Writer.Write(VehicleEntity);
			p_Writer.Write(ExplosionPackEntity);
			p_Writer.Write(SoldierEntity);
		}
	}
}
