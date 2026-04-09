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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 72)]
	public partial class SocketObjectData :
		SocketObjectDataBase
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private GUID _Asset1pGuid = GUID.Empty;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<GUID> _Variation1pGuids = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private GUID _Asset1pZoomGuid = GUID.Empty;

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private List<GUID> _Variation1pZoomGuids = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private GUID _Asset3pGuid = GUID.Empty;

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private List<GUID> _Variation3pGuids = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private RefArray<CustomizedMaterialData> _CustomizedMaterials = new();

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
