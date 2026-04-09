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
	[ContainerType(4, 24)]
	public partial class RegistryContainer :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<DataContainer> _EntityRegistry = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<DataContainer> _AssetRegistry = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<DataContainer> _BlueprintRegistry = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<DataContainer> _ReferenceObjectRegistry = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_EntityRegistry = p_EbxWriter.GetArrayWriter(EntityRegistry.GetType(), EntityRegistry.Count);
			p_Writer.Write(s_EntityRegistry.ArrayIndex);
			foreach (var s_Entry in EntityRegistry)
			{
				s_EntityRegistry.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_AssetRegistry = p_EbxWriter.GetArrayWriter(AssetRegistry.GetType(), AssetRegistry.Count);
			p_Writer.Write(s_AssetRegistry.ArrayIndex);
			foreach (var s_Entry in AssetRegistry)
			{
				s_AssetRegistry.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_BlueprintRegistry = p_EbxWriter.GetArrayWriter(BlueprintRegistry.GetType(), BlueprintRegistry.Count);
			p_Writer.Write(s_BlueprintRegistry.ArrayIndex);
			foreach (var s_Entry in BlueprintRegistry)
			{
				s_BlueprintRegistry.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_ReferenceObjectRegistry = p_EbxWriter.GetArrayWriter(ReferenceObjectRegistry.GetType(), ReferenceObjectRegistry.Count);
			p_Writer.Write(s_ReferenceObjectRegistry.ArrayIndex);
			foreach (var s_Entry in ReferenceObjectRegistry)
			{
				s_ReferenceObjectRegistry.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
