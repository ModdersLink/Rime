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
	[ContainerType(4, 36)]
	public partial class MaterialGridData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<MaterialContainerPair> _DefaultMaterial = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<MaterialContainerPair> _MaterialPairs = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<uint> _MaterialIndexMap = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _DefaultMaterialIndex;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<MaterialRelationPropertyPair> _MaterialProperties = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<MaterialInteractionGridRow> _InteractionGrid = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultMaterial));
			(RimeWriter Writer, uint ArrayIndex) s_MaterialPairs = p_EbxWriter.GetArrayWriter(MaterialPairs.GetType(), MaterialPairs.Count);
			p_Writer.Write(s_MaterialPairs.ArrayIndex);
			foreach (var s_Entry in MaterialPairs)
			{
				s_MaterialPairs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_MaterialIndexMap = p_EbxWriter.GetArrayWriter(MaterialIndexMap.GetType(), MaterialIndexMap.Count);
			p_Writer.Write(s_MaterialIndexMap.ArrayIndex);
			foreach (var s_Entry in MaterialIndexMap)
			{
				s_MaterialIndexMap.Writer.Write(s_Entry);
			}
			p_Writer.Write(DefaultMaterialIndex);
			(RimeWriter Writer, uint ArrayIndex) s_MaterialProperties = p_EbxWriter.GetArrayWriter(MaterialProperties.GetType(), MaterialProperties.Count);
			p_Writer.Write(s_MaterialProperties.ArrayIndex);
			foreach (var s_Entry in MaterialProperties)
			{
				s_Entry.Serialize(s_MaterialProperties.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InteractionGrid = p_EbxWriter.GetArrayWriter(InteractionGrid.GetType(), InteractionGrid.Count);
			p_Writer.Write(s_InteractionGrid.ArrayIndex);
			foreach (var s_Entry in InteractionGrid)
			{
				s_Entry.Serialize(s_InteractionGrid.Writer, p_EbxWriter);
			}
		}
	}
}
