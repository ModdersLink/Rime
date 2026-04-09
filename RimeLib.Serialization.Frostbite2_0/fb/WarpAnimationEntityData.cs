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
	public partial class WarpAnimationEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private LinearTransform _ConnectTransform = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private int _AnimationEntitySpacePriority;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private WarpAnimationBinding _WarpBinding = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private GameplayBones _BoneToAlign = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _ForceAnimationTransform;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _RequireAnimationWeight;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _ExternalConnectTransform;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			ConnectTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AnimationEntitySpacePriority);
			WarpBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) BoneToAlign);
			p_Writer.Write(ForceAnimationTransform);
			p_Writer.Write(RequireAnimationWeight);
			p_Writer.Write(ExternalConnectTransform);
			p_Writer.WriteNullBytes(1);
		}
	}
}
