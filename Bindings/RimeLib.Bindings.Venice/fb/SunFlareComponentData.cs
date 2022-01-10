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
	[ContainerType(16, 544)]
	public class SunFlareComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5AlphaOccluderCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5SizeScreenPosCurve { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2SizeOccluderCurve { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5SizeOccluderCurve { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2AlphaOccluderCurve { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element1Size { get; set; } = new();

		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1SizeOccluderCurve { get; set; } = new();

		[ContainerField(240), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1SizeScreenPosCurve { get; set; } = new();

		[ContainerField(256), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1AlphaOccluderCurve { get; set; } = new();

		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(288), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element5Size { get; set; } = new();

		[ContainerField(304), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4SizeOccluderCurve { get; set; } = new();

		[ContainerField(320), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element3Size { get; set; } = new();

		[ContainerField(328), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element2Size { get; set; } = new();

		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(352), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2SizeScreenPosCurve { get; set; } = new();

		[ContainerField(368), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4SizeScreenPosCurve { get; set; } = new();

		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element4Size { get; set; } = new();

		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3AlphaScreenPosCurve { get; set; } = new();

		[ContainerField(416), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4AlphaOccluderCurve { get; set; } = new();

		[ContainerField(432), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3SizeOccluderCurve { get; set; } = new();

		[ContainerField(448), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3SizeScreenPosCurve { get; set; } = new();

		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3AlphaOccluderCurve { get; set; } = new();

		[ContainerField(480)]
		public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new();

		[ContainerField(484), LayoutImmutable, Blittable]
		public float OccluderSize { get; set; }

		[ContainerField(488)]
		public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new();

		[ContainerField(492), LayoutImmutable, Blittable]
		public float Element3RayDistance { get; set; }

		[ContainerField(496)]
		public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new();

		[ContainerField(500), LayoutImmutable, Blittable]
		public float Element4RayDistance { get; set; }

		[ContainerField(504), LayoutImmutable, Blittable]
		public float Element2RayDistance { get; set; }

		[ContainerField(508), LayoutImmutable, Blittable]
		public float Element1RayDistance { get; set; }

		[ContainerField(512), LayoutImmutable, Blittable]
		public float Element5RayDistance { get; set; }

		[ContainerField(516)]
		public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new();

		[ContainerField(520)]
		public Realm Realm { get; set; } = new();

		[ContainerField(524)]
		public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new();

		[ContainerField(528), LayoutImmutable, Blittable]
		public bool Element5Enable { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable]
		public bool Element3Enable { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable]
		public bool Element2Enable { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable]
		public bool Element1Enable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable]
		public bool Element4Enable { get; set; }

		public static void Deserialize(SunFlareComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.Element5AlphaScreenPosCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element5AlphaOccluderCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element5SizeScreenPosCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element2SizeOccluderCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element5SizeOccluderCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element2AlphaOccluderCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.Element2AlphaScreenPosCurve, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.Element1Size, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element1SizeOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element1SizeScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element1AlphaOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element1AlphaScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.Element5Size, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element4SizeOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.Element3Size, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.Element2Size, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element4AlphaScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element2SizeScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element4SizeScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(16, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.Element4Size, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element3AlphaScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element4AlphaOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element3SizeOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element3SizeScreenPosCurve, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Element3AlphaOccluderCurve, p_Reader, p_Parser);
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element1Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.OccluderSize = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element2Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element3RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element4Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element4RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element2RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element1RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element5RayDistance = p_Reader.ReadSingle();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element3Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element5Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element5Enable = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element3Enable = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element2Enable = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element1Enable = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.DebugDrawOccluder = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(24, SeekOrigin.Current);
			p_Instance.Element4Enable = p_Reader.ReadBool();
			p_Reader.Seek(33, SeekOrigin.Current);
		}

	}
}
