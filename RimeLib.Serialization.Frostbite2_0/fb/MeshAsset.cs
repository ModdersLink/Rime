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
	[ContainerType(4, 40)]
	public partial class MeshAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<MeshLodGroup> _LodGroup = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _LodScale;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _CullScale;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _NameHash;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private EnlightenType _EnlightenType = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<MeshMaterial> _Materials = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _OccluderHighPriority;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _StreamingEnable;

		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _DestructionMaterialEnable;

		[ObservableProperty]
		[property: ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		private bool _OccluderMeshEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(LodGroup));
			p_Writer.Write(LodScale);
			p_Writer.Write(CullScale);
			p_Writer.Write(NameHash);
			p_Writer.Write((int) EnlightenType);
			(RimeWriter Writer, uint ArrayIndex) s_Materials = p_EbxWriter.GetArrayWriter(Materials.GetType(), Materials.Count);
			p_Writer.Write(s_Materials.ArrayIndex);
			foreach (var s_Entry in Materials)
			{
				s_Materials.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(OccluderHighPriority);
			p_Writer.Write(StreamingEnable);
			p_Writer.Write(DestructionMaterialEnable);
			p_Writer.Write(OccluderMeshEnable);
		}
	}
}
