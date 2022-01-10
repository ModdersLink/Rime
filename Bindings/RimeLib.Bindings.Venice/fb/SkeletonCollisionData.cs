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
	[ContainerType(4, 16)]
	public class SkeletonCollisionData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(12)]
		public List<BoneCollisionData> BoneCollisionData { get; set; } = new();

		public static void Deserialize(SkeletonCollisionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SkeletonAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneCollisionData.Clear();
			(RimeReader Reader, uint Count) s_BoneCollisionData = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneCollisionData.Count; ++i)
			{
				var s_Value = new BoneCollisionData();
				fb.BoneCollisionData.Deserialize(s_Value, s_BoneCollisionData.Reader, p_Parser);
				p_Instance.BoneCollisionData.Add(s_Value);
			}
			
			s_BoneCollisionData.Reader.Dispose();
		}

	}
}
