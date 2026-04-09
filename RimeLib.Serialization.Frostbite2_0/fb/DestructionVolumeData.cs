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
	[ContainerType(16, 64)]
	public partial class DestructionVolumeData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private AxisAlignedBox _BoundingBox = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<DestructionVolumeAsset> _Asset = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private List<Vec4> _Impacts = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private List<uint> _PartToImpactIndices = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
