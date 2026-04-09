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
	public partial class EnlightenPipelineTerrainMesh :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec2 _UvTranslation = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private AxisAlignedBox _BoundingBox = new();
		
		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec4 _UvTransform = new();
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _LightMapResolution;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		private string _TerrainMeshName = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UvTranslation.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			BoundingBox.Serialize(p_Writer, p_EbxWriter);
			UvTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LightMapResolution);
			p_Writer.Write(p_EbxWriter.WriteString(TerrainMeshName));
			p_Writer.WriteNullBytes(8);
		}
	}
}
