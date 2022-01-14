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
	[ContainerType(16, 112)]
	public class PartComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public RefArray<HealthStateData> HealthStates { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool IsSupported { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool IsFragile { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool IsNetworkable { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		public bool IsWindow { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool AnimatePhysics { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_HealthStates = p_EbxWriter.GetArrayWriter(HealthStates.GetType(), HealthStates.Count);
			p_Writer.Write(s_HealthStates.ArrayIndex);
			foreach (var s_Entry in HealthStates)
			{
				s_HealthStates.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_PartLinks = p_EbxWriter.GetArrayWriter(PartLinks.GetType(), PartLinks.Count);
			p_Writer.Write(s_PartLinks.ArrayIndex);
			foreach (var s_Entry in PartLinks)
			{
				s_PartLinks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(IsSupported);
			p_Writer.Write(IsFragile);
			p_Writer.Write(IsNetworkable);
			p_Writer.Write(IsWindow);
			p_Writer.Write(AnimatePhysics);
			p_Writer.WriteNullBytes(3);
		}
	}
}
