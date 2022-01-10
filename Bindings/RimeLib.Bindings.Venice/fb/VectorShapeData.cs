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
	[ContainerType(4, 28)]
	public class VectorShapeData : 
		BaseShapeData
	{
		[ContainerField(12)]
		public List<Vec3> Points { get; set; } = new();

		[ContainerField(16)]
		public List<Vec3> Normals { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Tension { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsClosed { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool AllowRoll { get; set; }

		public static void Deserialize(VectorShapeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Points.Clear();
			(RimeReader Reader, uint Count) s_Points = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Points.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_Points.Reader, p_Parser);
				p_Instance.Points.Add(s_Value);
			}
			
			s_Points.Reader.Dispose();
			p_Instance.Normals.Clear();
			(RimeReader Reader, uint Count) s_Normals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Normals.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_Normals.Reader, p_Parser);
				p_Instance.Normals.Add(s_Value);
			}
			
			s_Normals.Reader.Dispose();
			p_Instance.Tension = p_Reader.ReadSingle();
			p_Instance.IsClosed = p_Reader.ReadBool();
			p_Instance.AllowRoll = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
