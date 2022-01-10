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
	public class SoldierHeadCollisionData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HeadRadius { get; set; }

		[ContainerField(12)]
		public List<SoldierHeadCollisionPoseData> PoseStates { get; set; } = new();

		public static void Deserialize(SoldierHeadCollisionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HeadRadius = p_Reader.ReadSingle();
			p_Instance.PoseStates.Clear();
			(RimeReader Reader, uint Count) s_PoseStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PoseStates.Count; ++i)
			{
				var s_Value = new SoldierHeadCollisionPoseData();
				fb.SoldierHeadCollisionPoseData.Deserialize(s_Value, s_PoseStates.Reader, p_Parser);
				p_Instance.PoseStates.Add(s_Value);
			}
			
			s_PoseStates.Reader.Dispose();
		}

	}
}
