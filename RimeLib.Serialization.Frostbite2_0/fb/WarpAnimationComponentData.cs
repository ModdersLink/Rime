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
	[ContainerType(16, 240)]
	public partial class WarpAnimationComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private LinearTransform _ConnectTransform = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private CannedAnimationBinding _CannedAnimBinding = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private int _AnimationEntitySpacePriority;

		[ObservableProperty]
		[property: ContainerField(204), JsonProperty(Order = 204)]
		private WarpAnimationBinding _WarpBinding = new();

		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private GameplayBones _BoneToAlign = new();

		[ObservableProperty]
		[property: ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		private bool _RequireAnimationWeight;

		[ObservableProperty]
		[property: ContainerField(229), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
		private bool _ForceAnimationTransform;

		[ObservableProperty]
		[property: ContainerField(230), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
		private bool _ExternalConnectTransform;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ConnectTransform.Serialize(p_Writer, p_EbxWriter);
			CannedAnimBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AnimationEntitySpacePriority);
			WarpBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) BoneToAlign);
			p_Writer.Write(RequireAnimationWeight);
			p_Writer.Write(ForceAnimationTransform);
			p_Writer.Write(ExternalConnectTransform);
			p_Writer.WriteNullBytes(9);
		}
	}
}
