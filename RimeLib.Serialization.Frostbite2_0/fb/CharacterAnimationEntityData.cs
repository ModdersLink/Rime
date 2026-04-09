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
	public partial class CharacterAnimationEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _EntitySpaceTransform = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AntRef _Controller = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _TrackLength;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _ExternalTime;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _WarpAnimationBlendTime;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _RestoreControllerOnFinish;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			EntitySpaceTransform.Serialize(p_Writer, p_EbxWriter);
			Controller.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TrackLength);
			p_Writer.Write(ExternalTime);
			p_Writer.Write(WarpAnimationBlendTime);
			p_Writer.Write(RestoreControllerOnFinish);
			p_Writer.WriteNullBytes(15);
		}
	}
}
