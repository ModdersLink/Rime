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
	[ContainerType(16, 256)]
	public partial class ExplosionPackEntityData :
		MeshProjectileEntityData
	{
		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _TimeToLiveOnPlayerDeath;

		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private SoldierDetonationData _SoldierDetonationData = new();

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _VehicleDetonationActivationDelay;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _VehicleDetonationRadius;

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private UIHudIcon _Icon = new();

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private float _SpottedTime;

		[ObservableProperty]
		[property: ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		private float _DefuseRadius;

		[ObservableProperty]
		[property: ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		private float _Health;

		[ObservableProperty]
		[property: ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		private bool _HasRemoteDetonator;

		[ObservableProperty]
		[property: ContainerField(241), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
		private bool _IsDestructible;

		[ObservableProperty]
		[property: ContainerField(242), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
		private bool _HasVehicleDetonation;

		[ObservableProperty]
		[property: ContainerField(243), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
		private bool _ReceivesExplosionDamage;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TimeToLiveOnPlayerDeath);
			SoldierDetonationData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(VehicleDetonationActivationDelay);
			p_Writer.Write(VehicleDetonationRadius);
			p_Writer.Write((int) Icon);
			p_Writer.Write(SpottedTime);
			p_Writer.Write(DefuseRadius);
			p_Writer.Write(Health);
			p_Writer.Write(HasRemoteDetonator);
			p_Writer.Write(IsDestructible);
			p_Writer.Write(HasVehicleDetonation);
			p_Writer.Write(ReceivesExplosionDamage);
			p_Writer.WriteNullBytes(12);
		}
	}
}
