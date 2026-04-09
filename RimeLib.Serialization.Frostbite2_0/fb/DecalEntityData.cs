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
	public partial class DecalEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private DecalAtlasTile _AtlasTile = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private sbyte _MaterialIndex;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private sbyte _SortingPriority;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _Projected;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader));
			AtlasTile.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaterialIndex);
			p_Writer.Write(SortingPriority);
			p_Writer.Write(Projected);
			p_Writer.WriteNullBytes(5);
		}
	}
}
