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
	public class GameSplineEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public GameSplineType SplineType { get; set; } = new();

		[ContainerField(100)]
		public List<Vec3> LocalPoints { get; set; } = new();

		[ContainerField(104)]
		public List<Vec3> Normals { get; set; } = new();

		public static void Deserialize(GameSplineEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SplineType = (GameSplineType) p_Reader.ReadInt32();
			p_Instance.LocalPoints.Clear();
			(RimeReader Reader, uint Count) s_LocalPoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LocalPoints.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_LocalPoints.Reader, p_Parser);
				p_Instance.LocalPoints.Add(s_Value);
			}
			
			s_LocalPoints.Reader.Dispose();
			p_Instance.Normals.Clear();
			(RimeReader Reader, uint Count) s_Normals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Normals.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_Normals.Reader, p_Parser);
				p_Instance.Normals.Add(s_Value);
			}
			
			s_Normals.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
