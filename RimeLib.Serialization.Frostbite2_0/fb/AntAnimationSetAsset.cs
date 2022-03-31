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
	[ContainerType(4, 36)]
	public class AntAnimationSetAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int ActorAssetIndex { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<int> ClipAssetIndices { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<int> LoopingClipAssetIndices { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int SceneOpMatrixAssetIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool UseTraj2Ref { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool AllowAnimationCulling { get; set; }

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
