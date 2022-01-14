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
	public class SoundAreaEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundAsset> Sound { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<BigWorldSettingsAsset> BigWorld { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FadeWidth { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ProximityMultiplier { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public FadeCurveType FadeCurve { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			p_Writer.Write(p_EbxWriter.WriteImport(BigWorld));
			p_Writer.Write(FadeWidth);
			p_Writer.Write(ProximityMultiplier);
			p_Writer.Write((int) FadeCurve);
		}
	}
}
