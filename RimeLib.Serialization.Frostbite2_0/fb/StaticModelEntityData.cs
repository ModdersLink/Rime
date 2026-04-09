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
	[ContainerType(16, 160)]
	public partial class StaticModelEntityData :
		GamePhysicsEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private RefArray<PartLinkData> _PartLinks = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _BoneCount;

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private List<LinearTransform> _BasePoseTransforms = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private StaticModelNetworkInfo _NetworkInfo = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private List<PhysicsPartInfo> _PhysicsPartInfos = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _ExcludeFromNearbyObjectDestruction;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _AnimatePhysics;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _Visible;

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
