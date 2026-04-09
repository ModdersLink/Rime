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
	[ContainerType(16, 144)]
	public partial class FilmGrainComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _ColorScale = new();

		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private Vec2 _TextureScale = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<TextureAsset> _Texture = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _LinearFilteringEnable;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _RandomEnable;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ColorScale.Serialize(p_Writer, p_EbxWriter);
			TextureScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(p_EbxWriter.WriteImport(Texture));
			p_Writer.Write(LinearFilteringEnable);
			p_Writer.Write(RandomEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(13);
		}
	}
}
