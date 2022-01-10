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
	[ContainerType(4, 20)]
	public class MasterSkeletonAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SkeletonAsset> MasterSkeleton { get; set; } = new();

		[ContainerField(16)]
		public List<SubSkeleton> SubSkeletons { get; set; } = new();

		public static void Deserialize(MasterSkeletonAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MasterSkeleton.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SubSkeletons.Clear();
			(RimeReader Reader, uint Count) s_SubSkeletons = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SubSkeletons.Count; ++i)
			{
				var s_Value = new SubSkeleton();
				fb.SubSkeleton.Deserialize(s_Value, s_SubSkeletons.Reader, p_Parser);
				p_Instance.SubSkeletons.Add(s_Value);
			}
			
			s_SubSkeletons.Reader.Dispose();
		}

	}
}
