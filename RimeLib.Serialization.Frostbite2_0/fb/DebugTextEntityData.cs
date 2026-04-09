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
	[ContainerType(16, 112)]
	public partial class DebugTextEntityData :
		SpatialEntityData
	{
		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private Vec3 _TextColor = new();

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		private string _DebugText = string.Empty;

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _Scale;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _Visible;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _Centered;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _DepthTest;

		[ObservableProperty]
		[property: ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		private bool _ScaleWithDistance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(DebugText));
			p_Writer.Write((int) Realm);
			p_Writer.Write(Scale);
			p_Writer.Write(Visible);
			p_Writer.Write(Centered);
			p_Writer.Write(DepthTest);
			p_Writer.Write(ScaleWithDistance);
		}
	}
}
