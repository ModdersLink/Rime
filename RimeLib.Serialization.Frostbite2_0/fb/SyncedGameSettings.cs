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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class SyncedGameSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MaxAllowedLatency { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float ManDownTimeModifier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float BulletDamageModifier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint DifficultyIndex { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool DisableRegenerateHealth { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool EnableFriendlyFire { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool AllowClientSideDamageArbitration { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool DisableToggleEntryCamera { get; set; }

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
