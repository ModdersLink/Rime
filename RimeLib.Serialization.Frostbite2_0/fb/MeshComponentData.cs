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
	[ContainerType(16, 112)]
	public partial class MeshComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private RefArray<BoneFakePhysicsData> _BoneFakePhysics = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<SkeletonAsset> _Skeleton = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BoneFakePhysics = p_EbxWriter.GetArrayWriter(BoneFakePhysics.GetType(), BoneFakePhysics.Count);
			p_Writer.Write(s_BoneFakePhysics.ArrayIndex);
			foreach (var s_Entry in BoneFakePhysics)
			{
				s_BoneFakePhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(Skeleton));
			p_Writer.WriteNullBytes(4);
		}
	}
}
