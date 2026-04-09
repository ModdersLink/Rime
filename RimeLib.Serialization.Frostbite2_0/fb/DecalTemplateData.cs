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
	[ContainerType(4, 72)]
	public partial class DecalTemplateData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _Size;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _RandomSize;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Rotation;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _RandomRotation;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ClipAngle;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _ProximityRadiusFactor;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _NormalOffset;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _MeshUVIndex;

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private DecalAtlasTile _AtlasTile = new();

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private sbyte _SortingPriority;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _Projected;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _ProjectMultiple;

		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private sbyte _MaterialIndex;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Size);
			p_Writer.Write(RandomSize);
			p_Writer.Write(Rotation);
			p_Writer.Write(RandomRotation);
			p_Writer.Write(ClipAngle);
			p_Writer.Write(ProximityRadiusFactor);
			p_Writer.Write(NormalOffset);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			p_Writer.Write(MeshUVIndex);
			AtlasTile.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SortingPriority);
			p_Writer.Write(Projected);
			p_Writer.Write(ProjectMultiple);
			p_Writer.Write(MaterialIndex);
		}
	}
}
