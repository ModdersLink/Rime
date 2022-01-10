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
	public class FireEffectData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Rotation { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomRotation { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ZoomOffset { get; set; } = new();
		
		[ContainerField(64)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseZoomOffset { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseZoomRotation { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DisableDuringZoom { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool UpdateTransform { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool StopLoopingEffects { get; set; }
		
		public static void Deserialize(FireEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Rotation, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.Offset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.ZoomRotation, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.ZoomOffset, p_Reader, p_Parser);
			p_Instance.Effect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UseZoomOffset = p_Reader.ReadBool();
			p_Instance.UseZoomRotation = p_Reader.ReadBool();
			p_Instance.DisableDuringZoom = p_Reader.ReadBool();
			p_Instance.UpdateTransform = p_Reader.ReadBool();
			p_Instance.StopLoopingEffects = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}
	}
}
