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
	[ContainerType(16, 160)]
	public partial class DestructionMaskVolumeEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec4 _DustAccumulationCurve = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _ShaderUserMasks = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _DustAccumulationLifeTime;

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private SurfaceShaderInstanceDataStruct _Shader = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _Radius;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			DustAccumulationCurve.Serialize(p_Writer, p_EbxWriter);
			ShaderUserMasks.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DustAccumulationLifeTime);
			Shader.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Radius);
			p_Writer.WriteNullBytes(4);
		}
	}
}
