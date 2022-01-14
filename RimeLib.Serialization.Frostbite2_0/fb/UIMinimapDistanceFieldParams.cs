///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 64)]
	public class UIMinimapDistanceFieldParams :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec4 ColorTint { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 OutlineColor { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DistanceScale { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float AlphaThreshold { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float OutlineInner { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float OutlineOuter { get; set; }
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ColorTint.Serialize(p_Writer, p_EbxWriter);
			OutlineColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DistanceScale);
			p_Writer.Write(AlphaThreshold);
			p_Writer.Write(OutlineInner);
			p_Writer.Write(OutlineOuter);
			p_Writer.Write(p_EbxWriter.WriteImport(DistanceField));
			p_Writer.WriteNullBytes(12);
		}
	}
}
