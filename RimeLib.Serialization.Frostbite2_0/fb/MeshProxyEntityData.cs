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
	[ContainerType(16, 96)]
	public partial class MeshProxyEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private List<LinearTransform> _BasePoseTransforms = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
			p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
			foreach (var s_Entry in BasePoseTransforms)
			{
				s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
			}
			p_Writer.WriteNullBytes(8);
		}
	}
}
