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
	[ContainerType(4, 40)]
	public class ScoringBucketUnlockData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint PointsNeeded { get; set; }
		
		[ContainerField(4)]
		public BasicUnlockInfo UnlockInfo { get; set; } = new();
		
		public static void Deserialize(ScoringBucketUnlockData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PointsNeeded = p_Reader.ReadUInt32();
			fb.BasicUnlockInfo.Deserialize(p_Instance.UnlockInfo, p_Reader, p_Parser);
		}
	}
}
