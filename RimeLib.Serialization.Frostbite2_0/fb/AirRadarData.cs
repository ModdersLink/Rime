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
	[ContainerType(16, 128)]
	public partial class AirRadarData :
		UIPartData
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _RadarRange;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _RadarSensitivity;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _HeatSensitivity;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private UIHudIcon _MissileIcon = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIHudIcon _CenterIcon = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private UIHudIcon _FriendlyIcon = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private UIHudIcon _EnemyIcon = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private UIHudIcon _LaserPaintedIcon = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIHudIcon _NorthIcon = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private SubScreenData _SubScreen = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private UIHudIcon _WestIcon = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private UIHudIcon _SouthIcon = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private UIHudIcon _EastIcon = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _TrackLaserPaintedObjects;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _TrackOnlyUsedVehicles;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _UseCameraComponentTransform;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RadarRange);
			p_Writer.Write(RadarSensitivity);
			p_Writer.Write(HeatSensitivity);
			p_Writer.Write((int) MissileIcon);
			p_Writer.Write((int) CenterIcon);
			p_Writer.Write((int) FriendlyIcon);
			p_Writer.Write((int) EnemyIcon);
			p_Writer.Write((int) LaserPaintedIcon);
			p_Writer.Write((int) NorthIcon);
			p_Writer.WriteNullBytes(4);
			SubScreen.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) WestIcon);
			p_Writer.Write((int) SouthIcon);
			p_Writer.Write((int) EastIcon);
			p_Writer.Write(TrackLaserPaintedObjects);
			p_Writer.Write(TrackOnlyUsedVehicles);
			p_Writer.Write(UseCameraComponentTransform);
			p_Writer.WriteNullBytes(1);
		}
	}
}
