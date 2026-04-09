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
	[ContainerType(4, 32)]
	public partial class SyncedGameSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _MaxAllowedLatency;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _ManDownTimeModifier;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _BulletDamageModifier;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _DifficultyIndex;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _DisableRegenerateHealth;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _EnableFriendlyFire;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _AllowClientSideDamageArbitration;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _DisableToggleEntryCamera;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxAllowedLatency);
			p_Writer.Write(ManDownTimeModifier);
			p_Writer.Write(BulletDamageModifier);
			p_Writer.Write(DifficultyIndex);
			p_Writer.Write(DisableRegenerateHealth);
			p_Writer.Write(EnableFriendlyFire);
			p_Writer.Write(AllowClientSideDamageArbitration);
			p_Writer.Write(DisableToggleEntryCamera);
		}
	}
}
