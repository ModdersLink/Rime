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
	[ContainerType(4, 28)]
	public class LevelAudioObstructionAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<AudioObstructionMaterialInfo> MaterialMap { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float FrequencySlewRate { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float GainSlewRate { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxRaycastDistanceSquared { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_MaterialMap = p_EbxWriter.GetArrayWriter(MaterialMap.GetType(), MaterialMap.Count);
			p_Writer.Write(s_MaterialMap.ArrayIndex);
			foreach (var s_Entry in MaterialMap)
			{
				s_Entry.Serialize(s_MaterialMap.Writer, p_EbxWriter);
			}
			p_Writer.Write(FrequencySlewRate);
			p_Writer.Write(GainSlewRate);
			p_Writer.Write(MaxRaycastDistanceSquared);
		}
	}
}
