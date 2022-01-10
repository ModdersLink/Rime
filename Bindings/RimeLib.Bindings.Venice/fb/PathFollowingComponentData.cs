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
	[ContainerType(16, 112)]
	public class PathFollowingComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float UpdatePathAtDistancePercent { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint PreferredPathfindingIndex { get; set; }

		[ContainerField(104)]
		public List<uint> AlternatePathfindingIndices { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MovementCorridorRadius { get; set; }

		public static void Deserialize(PathFollowingComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UpdatePathAtDistancePercent = p_Reader.ReadSingle();
			p_Instance.PreferredPathfindingIndex = p_Reader.ReadUInt32();
			p_Instance.AlternatePathfindingIndices.Clear();
			(RimeReader Reader, uint Count) s_AlternatePathfindingIndices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AlternatePathfindingIndices.Count; ++i)
			{
				var s_Value = s_AlternatePathfindingIndices.Reader.ReadUInt32();
				p_Instance.AlternatePathfindingIndices.Add(s_Value);
			}
			
			s_AlternatePathfindingIndices.Reader.Dispose();
			p_Instance.MovementCorridorRadius = p_Reader.ReadSingle();
		}

	}
}
