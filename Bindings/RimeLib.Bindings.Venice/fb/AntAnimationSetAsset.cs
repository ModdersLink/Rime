///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class AntAnimationSetAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int ActorAssetIndex { get; set; }

		[ContainerField(20)]
		public List<int> ClipAssetIndices { get; set; } = new();

		[ContainerField(24)]
		public List<int> LoopingClipAssetIndices { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public int SceneOpMatrixAssetIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseTraj2Ref { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool AllowAnimationCulling { get; set; }

		public static void Deserialize(AntAnimationSetAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SkeletonAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ActorAssetIndex = p_Reader.ReadInt32();
			p_Instance.ClipAssetIndices.Clear();
			(RimeReader Reader, uint Count) s_ClipAssetIndices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ClipAssetIndices.Count; ++i)
			{
				var s_Value = s_ClipAssetIndices.Reader.ReadInt32();
				p_Instance.ClipAssetIndices.Add(s_Value);
			}
			
			s_ClipAssetIndices.Reader.Dispose();
			p_Instance.LoopingClipAssetIndices.Clear();
			(RimeReader Reader, uint Count) s_LoopingClipAssetIndices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LoopingClipAssetIndices.Count; ++i)
			{
				var s_Value = s_LoopingClipAssetIndices.Reader.ReadInt32();
				p_Instance.LoopingClipAssetIndices.Add(s_Value);
			}
			
			s_LoopingClipAssetIndices.Reader.Dispose();
			p_Instance.SceneOpMatrixAssetIndex = p_Reader.ReadInt32();
			p_Instance.UseTraj2Ref = p_Reader.ReadBool();
			p_Instance.AllowAnimationCulling = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
