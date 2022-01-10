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
	public class UIMinimapDistanceFieldParams
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ColorTint { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 OutlineColor { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DistanceScale { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float AlphaThreshold { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float OutlineInner { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float OutlineOuter { get; set; }
		
		[ContainerField(48)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new();
		
		public static void Deserialize(UIMinimapDistanceFieldParams p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.ColorTint, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.OutlineColor, p_Reader, p_Parser);
			p_Instance.DistanceScale = p_Reader.ReadSingle();
			p_Instance.AlphaThreshold = p_Reader.ReadSingle();
			p_Instance.OutlineInner = p_Reader.ReadSingle();
			p_Instance.OutlineOuter = p_Reader.ReadSingle();
			p_Instance.DistanceField.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
		}
	}
}
