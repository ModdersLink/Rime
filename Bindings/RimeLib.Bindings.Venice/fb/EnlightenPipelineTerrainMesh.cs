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
	[ContainerType(16, 80)]
	public class EnlightenPipelineTerrainMesh
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 UvTranslation { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UvTransform { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint LightMapResolution { get; set; }
		
		[ContainerField(68), LayoutImmutable]
		public string TerrainMeshName { get; set; } = string.Empty;
		
		public static void Deserialize(EnlightenPipelineTerrainMesh p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.UvTranslation, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.AxisAlignedBox.Deserialize(p_Instance.BoundingBox, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.UvTransform, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.LightMapResolution = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TerrainMeshName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(16, SeekOrigin.Current);
		}
	}
}
