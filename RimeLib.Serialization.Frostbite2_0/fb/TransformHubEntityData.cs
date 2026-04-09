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
	[ContainerType(16, 544)]
	public partial class TransformHubEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _In4 = new();

		[ObservableProperty]
		[property: ContainerField(80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private LinearTransform _In1 = new();

		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private LinearTransform _In2 = new();

		[ObservableProperty]
		[property: ContainerField(208), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private LinearTransform _In3 = new();

		[ObservableProperty]
		[property: ContainerField(272), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
		private LinearTransform _In8 = new();

		[ObservableProperty]
		[property: ContainerField(336), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private LinearTransform _In5 = new();

		[ObservableProperty]
		[property: ContainerField(400), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 400)]
		private LinearTransform _In6 = new();

		[ObservableProperty]
		[property: ContainerField(464), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private LinearTransform _In7 = new();

		[ObservableProperty]
		[property: ContainerField(528), JsonProperty(Order = 528)]
		private Realm _Realm = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			In4.Serialize(p_Writer, p_EbxWriter);
			In1.Serialize(p_Writer, p_EbxWriter);
			In2.Serialize(p_Writer, p_EbxWriter);
			In3.Serialize(p_Writer, p_EbxWriter);
			In8.Serialize(p_Writer, p_EbxWriter);
			In5.Serialize(p_Writer, p_EbxWriter);
			In6.Serialize(p_Writer, p_EbxWriter);
			In7.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.WriteNullBytes(12);
		}
	}
}
