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
	[ContainerType(16, 192)]
	public partial class EnlightenDbInstance :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private AxisAlignedBox _WorldBoundingbox = new();
		
		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private LinearTransform _WorldTransform = new();
		
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec2 _UvTranslation = new();
		
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec4 _UvTransform = new();
		
		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private uint _GeometryId;
		
		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		private string _ObjectVariation = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		private string _GuidString = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private uint _UvSizeX;
		
		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private uint _UvSizeY;
		
		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _PixelSize;
		
		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, JsonProperty(Order = 152)]
		private string _EnlightenMeshName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		private string _MeshAsset = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private List<ulong> _InstanceAlbedos = new();
		
		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private GUID _CacheKey = GUID.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			WorldBoundingbox.Serialize(p_Writer, p_EbxWriter);
			WorldTransform.Serialize(p_Writer, p_EbxWriter);
			UvTranslation.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			UvTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(GeometryId);
			p_Writer.Write(p_EbxWriter.WriteString(ObjectVariation));
			p_Writer.Write(p_EbxWriter.WriteString(GuidString));
			p_Writer.Write(UvSizeX);
			p_Writer.Write(UvSizeY);
			p_Writer.Write(PixelSize);
			p_Writer.Write(p_EbxWriter.WriteString(EnlightenMeshName));
			p_Writer.Write(p_EbxWriter.WriteString(MeshAsset));
			(RimeWriter Writer, uint ArrayIndex) s_InstanceAlbedos = p_EbxWriter.GetArrayWriter(InstanceAlbedos.GetType(), InstanceAlbedos.Count);
			p_Writer.Write(s_InstanceAlbedos.ArrayIndex);
			foreach (var s_Entry in InstanceAlbedos)
			{
				s_InstanceAlbedos.Writer.Write(s_Entry);
			}
			CacheKey.Serialize(p_Writer);
			p_Writer.WriteNullBytes(12);
		}
	}
}
