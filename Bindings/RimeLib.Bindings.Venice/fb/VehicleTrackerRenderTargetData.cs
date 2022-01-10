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
	[ContainerType(4, 24)]
	public class VehicleTrackerRenderTargetData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PositionOffset { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RenderTargetApectRatio { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ScaleSize { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UseRenderTarget { get; set; }
		
		public static void Deserialize(VehicleTrackerRenderTargetData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.PositionOffset, p_Reader, p_Parser);
			p_Instance.RenderTargetIndex = p_Reader.ReadInt32();
			p_Instance.RenderTargetApectRatio = p_Reader.ReadSingle();
			p_Instance.ScaleSize = p_Reader.ReadSingle();
			p_Instance.UseRenderTarget = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
