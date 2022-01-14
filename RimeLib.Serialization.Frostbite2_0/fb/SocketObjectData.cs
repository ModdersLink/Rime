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
	[ContainerType(4, 72)]
	public class SocketObjectData :
		SocketObjectDataBase
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public GUID Asset1pGuid { get; set; }

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<GUID> Variation1pGuids { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public GUID Asset1pZoomGuid { get; set; }

		[ContainerField(44), JsonProperty(Order = 44)]
		public List<GUID> Variation1pZoomGuids { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public GUID Asset3pGuid { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public List<GUID> Variation3pGuids { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public RefArray<CustomizedMaterialData> CustomizedMaterials { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Asset1pGuid.Serialize(p_Writer);
			(RimeWriter Writer, uint ArrayIndex) s_Variation1pGuids = p_EbxWriter.GetArrayWriter(Variation1pGuids.GetType(), Variation1pGuids.Count);
			p_Writer.Write(s_Variation1pGuids.ArrayIndex);
			foreach (var s_Entry in Variation1pGuids)
			{
				s_Entry.Serialize(s_Variation1pGuids.Writer);
			}
			Asset1pZoomGuid.Serialize(p_Writer);
			(RimeWriter Writer, uint ArrayIndex) s_Variation1pZoomGuids = p_EbxWriter.GetArrayWriter(Variation1pZoomGuids.GetType(), Variation1pZoomGuids.Count);
			p_Writer.Write(s_Variation1pZoomGuids.ArrayIndex);
			foreach (var s_Entry in Variation1pZoomGuids)
			{
				s_Entry.Serialize(s_Variation1pZoomGuids.Writer);
			}
			Asset3pGuid.Serialize(p_Writer);
			(RimeWriter Writer, uint ArrayIndex) s_Variation3pGuids = p_EbxWriter.GetArrayWriter(Variation3pGuids.GetType(), Variation3pGuids.Count);
			p_Writer.Write(s_Variation3pGuids.ArrayIndex);
			foreach (var s_Entry in Variation3pGuids)
			{
				s_Entry.Serialize(s_Variation3pGuids.Writer);
			}
			(RimeWriter Writer, uint ArrayIndex) s_CustomizedMaterials = p_EbxWriter.GetArrayWriter(CustomizedMaterials.GetType(), CustomizedMaterials.Count);
			p_Writer.Write(s_CustomizedMaterials.ArrayIndex);
			foreach (var s_Entry in CustomizedMaterials)
			{
				s_CustomizedMaterials.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
