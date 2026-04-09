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
	public partial class AntAnimationSetAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SkeletonAsset> _SkeletonAsset = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private int _ActorAssetIndex;

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<int> _ClipAssetIndices = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<int> _LoopingClipAssetIndices = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private int _SceneOpMatrixAssetIndex;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _UseTraj2Ref;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _AllowAnimationCulling;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(SkeletonAsset));
			p_Writer.Write(ActorAssetIndex);
			(RimeWriter Writer, uint ArrayIndex) s_ClipAssetIndices = p_EbxWriter.GetArrayWriter(ClipAssetIndices.GetType(), ClipAssetIndices.Count);
			p_Writer.Write(s_ClipAssetIndices.ArrayIndex);
			foreach (var s_Entry in ClipAssetIndices)
			{
				s_ClipAssetIndices.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LoopingClipAssetIndices = p_EbxWriter.GetArrayWriter(LoopingClipAssetIndices.GetType(), LoopingClipAssetIndices.Count);
			p_Writer.Write(s_LoopingClipAssetIndices.ArrayIndex);
			foreach (var s_Entry in LoopingClipAssetIndices)
			{
				s_LoopingClipAssetIndices.Writer.Write(s_Entry);
			}
			p_Writer.Write(SceneOpMatrixAssetIndex);
			p_Writer.Write(UseTraj2Ref);
			p_Writer.Write(AllowAnimationCulling);
			p_Writer.WriteNullBytes(2);
		}
	}
}
