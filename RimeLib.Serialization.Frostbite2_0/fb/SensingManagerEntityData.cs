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
	[ContainerType(4, 16)]
	public class SensingManagerEntityData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<SensingSphere> SenseTerrainAreas { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_SenseTerrainAreas = p_EbxWriter.GetArrayWriter(SenseTerrainAreas.GetType(), SenseTerrainAreas.Count);
			p_Writer.Write(s_SenseTerrainAreas.ArrayIndex);
			foreach (var s_Entry in SenseTerrainAreas)
			{
				s_Entry.Serialize(s_SenseTerrainAreas.Writer, p_EbxWriter);
			}
		}
	}
}
