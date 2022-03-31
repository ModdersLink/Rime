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
	[ContainerType(16, 208)]
	public class AreaTriggerEntityData :
		TriggerEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public LinearTransform GeometryTransform { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public AreaTriggerInclude Include { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float InsideAreaEventRepeatTime { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float Radius { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool UseCharacterEntity { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		public bool OneInsideAreaEventPerSoldier { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		public bool TriggerOnlyOnLeave { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		public bool ResetOnEnable { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public bool TriggerOnLeaveOnDeath { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		public bool TriggerOnLeaveOnDisable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			GeometryTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Include);
			p_Writer.Write(InsideAreaEventRepeatTime);
			p_Writer.Write(Radius);
			p_Writer.Write(UseCharacterEntity);
			p_Writer.Write(OneInsideAreaEventPerSoldier);
			p_Writer.Write(TriggerOnlyOnLeave);
			p_Writer.Write(ResetOnEnable);
			p_Writer.Write(TriggerOnLeaveOnDeath);
			p_Writer.Write(TriggerOnLeaveOnDisable);
			p_Writer.WriteNullBytes(14);
		}
	}
}
