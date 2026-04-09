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
	[ContainerType(4, 32)]
	public partial class HitReactionComponentBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _Hit = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _AllowKillFromAnimation = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _Direction = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _FiringDistance = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _BoneType = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _ImpactType = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _Immortal = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _RandomAnimationIndex = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Hit.Serialize(p_Writer, p_EbxWriter);
			AllowKillFromAnimation.Serialize(p_Writer, p_EbxWriter);
			Direction.Serialize(p_Writer, p_EbxWriter);
			FiringDistance.Serialize(p_Writer, p_EbxWriter);
			BoneType.Serialize(p_Writer, p_EbxWriter);
			ImpactType.Serialize(p_Writer, p_EbxWriter);
			Immortal.Serialize(p_Writer, p_EbxWriter);
			RandomAnimationIndex.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
