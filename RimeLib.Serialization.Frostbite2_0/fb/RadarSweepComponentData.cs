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
	public class RadarSweepComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float ControllableSpeedThreshold { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float ControllableSweepRadius { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ControllableSweepInterval { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float MineSweepInterval { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float MineSweepRadius { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool SweepForMines { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool SweepForControllables { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ControllableSpeedThreshold);
			p_Writer.Write(ControllableSweepRadius);
			p_Writer.Write(ControllableSweepInterval);
			p_Writer.Write(MineSweepInterval);
			p_Writer.Write(MineSweepRadius);
			p_Writer.Write(SweepForMines);
			p_Writer.Write(SweepForControllables);
			p_Writer.WriteNullBytes(10);
		}
	}
}
