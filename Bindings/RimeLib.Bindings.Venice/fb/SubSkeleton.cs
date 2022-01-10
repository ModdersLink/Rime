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
	[ContainerType(4, 12)]
	public class SubSkeleton
	{
		[ContainerField(0)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();
		
		[ContainerField(4)]
		public List<int> BoneMap { get; set; } = new();
		
		[ContainerField(8)]
		public List<LinearTransform> TransformMap { get; set; } = new();
		
		public static void Deserialize(SubSkeleton p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Skeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneMap.Clear();
			(RimeReader Reader, uint Count) s_BoneMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneMap.Count; ++i)
			{
				var s_Value = s_BoneMap.Reader.ReadInt32();
				p_Instance.BoneMap.Add(s_Value);
			}
			
			s_BoneMap.Reader.Dispose();
			p_Instance.TransformMap.Clear();
			(RimeReader Reader, uint Count) s_TransformMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TransformMap.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_TransformMap.Reader, p_Parser);
				p_Instance.TransformMap.Add(s_Value);
			}
			
			s_TransformMap.Reader.Dispose();
		}
	}
}
