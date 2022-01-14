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
	[ContainerType(16, 64)]
	public class DestructionVolumeData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public AxisAlignedBox BoundingBox { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<DestructionVolumeAsset> Asset { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public List<Vec4> Impacts { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<uint> PartToImpactIndices { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			BoundingBox.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Asset));
			(RimeWriter Writer, uint ArrayIndex) s_Impacts = p_EbxWriter.GetArrayWriter(Impacts.GetType(), Impacts.Count);
			p_Writer.Write(s_Impacts.ArrayIndex);
			foreach (var s_Entry in Impacts)
			{
				s_Entry.Serialize(s_Impacts.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_PartToImpactIndices = p_EbxWriter.GetArrayWriter(PartToImpactIndices.GetType(), PartToImpactIndices.Count);
			p_Writer.Write(s_PartToImpactIndices.ArrayIndex);
			foreach (var s_Entry in PartToImpactIndices)
			{
				s_PartToImpactIndices.Writer.Write(s_Entry);
			}
			p_Writer.WriteNullBytes(4);
		}
	}
}
