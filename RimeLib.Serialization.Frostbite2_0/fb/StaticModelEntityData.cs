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
	[ContainerType(16, 160)]
	public class StaticModelEntityData :
		GamePhysicsEntityData
	{
		[ContainerField(112), JsonProperty(Order = 112)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint BoneCount { get; set; }

		[ContainerField(124), JsonProperty(Order = 124)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public StaticModelNetworkInfo NetworkInfo { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public List<PhysicsPartInfo> PhysicsPartInfos { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool ExcludeFromNearbyObjectDestruction { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool AnimatePhysics { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool Visible { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PartLinks = p_EbxWriter.GetArrayWriter(PartLinks.GetType(), PartLinks.Count);
			p_Writer.Write(s_PartLinks.ArrayIndex);
			foreach (var s_Entry in PartLinks)
			{
				s_PartLinks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(BoneCount);
			(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
			p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
			foreach (var s_Entry in BasePoseTransforms)
			{
				s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
			}
			NetworkInfo.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PhysicsPartInfos = p_EbxWriter.GetArrayWriter(PhysicsPartInfos.GetType(), PhysicsPartInfos.Count);
			p_Writer.Write(s_PhysicsPartInfos.ArrayIndex);
			foreach (var s_Entry in PhysicsPartInfos)
			{
				s_Entry.Serialize(s_PhysicsPartInfos.Writer, p_EbxWriter);
			}
			p_Writer.Write(ExcludeFromNearbyObjectDestruction);
			p_Writer.Write(AnimatePhysics);
			p_Writer.Write(Visible);
			p_Writer.WriteNullBytes(9);
		}
	}
}
