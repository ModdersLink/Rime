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
	public partial class TransformSnapToGroundEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _In = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _DistanceToGround;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _RayCastLength;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _RayCastUpOffset;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _AlignWithGroundNormal;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			In.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(DistanceToGround);
			p_Writer.Write(RayCastLength);
			p_Writer.Write(RayCastUpOffset);
			p_Writer.Write(AlignWithGroundNormal);
			p_Writer.WriteNullBytes(15);
		}
	}
}
