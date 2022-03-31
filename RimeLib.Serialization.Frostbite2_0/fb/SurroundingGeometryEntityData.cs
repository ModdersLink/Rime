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
	[ContainerType(16, 112)]
	public class SurroundingGeometryEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<AllowedVehiclesData> AllowedVehicleList { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<CombatAreaTriggerEntityData> CombatArea { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public uint CombatAreaIndex { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AllowedVehicleList));
			p_Writer.Write(p_EbxWriter.WriteImport(CombatArea));
			p_Writer.Write(CombatAreaIndex);
			p_Writer.WriteNullBytes(4);
		}
	}
}
