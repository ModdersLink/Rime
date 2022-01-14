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
	[ContainerType(16, 128)]
	public class EffectComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float EmitterParameter1 { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float EmitterParameter3 { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float EmitterParameter2 { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool AutoStart { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool SnapToWaterSurface { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Effect));
			p_Writer.Write(EmitterParameter1);
			p_Writer.Write(EmitterParameter3);
			p_Writer.Write(EmitterParameter2);
			p_Writer.Write(AutoStart);
			p_Writer.Write(SnapToWaterSurface);
			p_Writer.WriteNullBytes(14);
		}
	}
}
