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

namespace fb
{
	[ContainerType(16, 128)]
	public class SoldierFootplantEffectComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float HeightOverGroundThreshold { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float FootVelocityThreshold { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float LodDistance { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool FullFootplantingEnabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(FootMaterialPair));
			p_Writer.Write(HeightOverGroundThreshold);
			p_Writer.Write(FootVelocityThreshold);
			p_Writer.Write(LodDistance);
			p_Writer.Write(FullFootplantingEnabled);
			p_Writer.WriteNullBytes(15);
		}
	}
}
