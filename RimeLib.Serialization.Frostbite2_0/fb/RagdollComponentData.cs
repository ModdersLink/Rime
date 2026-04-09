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
	[ContainerType(16, 144)]
	public partial class RagdollComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<SkeletonAsset> _SkeletonAsset = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<RagdollAsset> _RagdollAsset = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<SkeletonCollisionData> _SkeletonCollisionData = new();

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private RagdollBinding _Binding = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		private string _LeftLegBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		private string _RightLegBoneName = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SkeletonAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(RagdollAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(SkeletonCollisionData));
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(LeftLegBoneName));
			p_Writer.Write(p_EbxWriter.WriteString(RightLegBoneName));
			p_Writer.WriteNullBytes(8);
		}
	}
}
