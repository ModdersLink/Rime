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
	[ContainerType(16, 128)]
	public partial class RenderVolumeEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec4 _UserMasks = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private SurfaceShaderInstanceDataStruct _Shader = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private RenderVolumeTransformType _TransformType = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _Enabled;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UserMasks.Serialize(p_Writer, p_EbxWriter);
			Shader.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TransformType);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(7);
		}
	}
}
