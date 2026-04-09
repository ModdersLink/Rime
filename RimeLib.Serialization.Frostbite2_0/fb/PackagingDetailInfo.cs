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
	[ContainerType(4, 12)]
	public partial class PackagingDetailInfo :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private int _MipsToSkip;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private int _LodsToSkip;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _IncludeAnimation;
		
		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _IncludeMeshes;
		
		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _IncludeSounds;
		
		[ObservableProperty]
		[property: ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		private bool _IncludeTextures;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MipsToSkip);
			p_Writer.Write(LodsToSkip);
			p_Writer.Write(IncludeAnimation);
			p_Writer.Write(IncludeMeshes);
			p_Writer.Write(IncludeSounds);
			p_Writer.Write(IncludeTextures);
		}
	}
}
