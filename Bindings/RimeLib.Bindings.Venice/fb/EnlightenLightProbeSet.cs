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
	[ContainerType(16, 160)]
	public class EnlightenLightProbeSet
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint SizeX { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint SizeZ { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public uint SizeY { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public int SystemId { get; set; }
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float BlendDistance { get; set; }
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public int Priority { get; set; }
		
		[ContainerField(120)]
		public List<Vec3> Positions { get; set; } = new();
		
		[ContainerField(124)]
		public List<uint> ValidIndices { get; set; } = new();
		
		[ContainerField(128)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(132)]
		public PrecomputeCache Cache { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool StaticProbeSet { get; set; }
		
		public static void Deserialize(EnlightenLightProbeSet p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			fb.AxisAlignedBox.Deserialize(p_Instance.BoundingBox, p_Reader, p_Parser);
			p_Instance.SizeX = p_Reader.ReadUInt32();
			p_Instance.SizeZ = p_Reader.ReadUInt32();
			p_Instance.SizeY = p_Reader.ReadUInt32();
			p_Instance.SystemId = p_Reader.ReadInt32();
			p_Instance.BlendDistance = p_Reader.ReadSingle();
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Instance.Positions.Clear();
			(RimeReader Reader, uint Count) s_Positions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Positions.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_Positions.Reader, p_Parser);
				p_Instance.Positions.Add(s_Value);
			}
			
			s_Positions.Reader.Dispose();
			p_Instance.ValidIndices.Clear();
			(RimeReader Reader, uint Count) s_ValidIndices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ValidIndices.Count; ++i)
			{
				var s_Value = s_ValidIndices.Reader.ReadUInt32();
				p_Instance.ValidIndices.Add(s_Value);
			}
			
			s_ValidIndices.Reader.Dispose();
			p_Instance.InputSystems.Clear();
			(RimeReader Reader, uint Count) s_InputSystems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputSystems.Count; ++i)
			{
				var s_Value = s_InputSystems.Reader.ReadInt32();
				p_Instance.InputSystems.Add(s_Value);
			}
			
			s_InputSystems.Reader.Dispose();
			fb.PrecomputeCache.Deserialize(p_Instance.Cache, p_Reader, p_Parser);
			p_Instance.StaticProbeSet = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
