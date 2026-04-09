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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 80)]
	public partial class SampleTextureData :
		EvaluatorData
	{
		[ObservableProperty]
		[property: ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private Vec2 _TextureDimensions = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _ColorIntensityMax = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _ColorIntensityMin = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private List<Vec4> _GradientData = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _TextureOriginU;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _TextureOriginV;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TextureDimensions.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
			ColorIntensityMax.Serialize(p_Writer, p_EbxWriter);
			ColorIntensityMin.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_GradientData = p_EbxWriter.GetArrayWriter(GradientData.GetType(), GradientData.Count);
			p_Writer.Write(s_GradientData.ArrayIndex);
			foreach (var s_Entry in GradientData)
			{
				s_Entry.Serialize(s_GradientData.Writer, p_EbxWriter);
			}
			p_Writer.Write(TextureOriginU);
			p_Writer.Write(TextureOriginV);
			p_Writer.WriteNullBytes(4);
		}
	}
}
