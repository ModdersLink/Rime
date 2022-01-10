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
	[ContainerType(16, 64)]
	public class SubScreenData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ScreenPosition { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ProjectionAngleY { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ProjectionAngleZ { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ProjectionAngleX { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ScreenSize { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float IconSize { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ScaleIconSizeByDepthStrength { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float RenderTargetApectRatio { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool UseRenderTarget { get; set; }
		
		public static void Deserialize(SubScreenData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.ScreenPosition, p_Reader, p_Parser);
			p_Instance.ProjectionAngleY = p_Reader.ReadSingle();
			p_Instance.ProjectionAngleZ = p_Reader.ReadSingle();
			p_Instance.ProjectionAngleX = p_Reader.ReadSingle();
			p_Instance.ScreenSize = p_Reader.ReadSingle();
			p_Instance.IconSize = p_Reader.ReadSingle();
			p_Instance.ScaleIconSizeByDepthStrength = p_Reader.ReadSingle();
			p_Instance.RenderTargetApectRatio = p_Reader.ReadSingle();
			p_Instance.RenderTargetIndex = p_Reader.ReadInt32();
			p_Instance.UseRenderTarget = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}
	}
}
