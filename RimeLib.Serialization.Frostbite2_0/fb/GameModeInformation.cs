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
	[ContainerType(4, 40)]
	public partial class GameModeInformation :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private GamePlatform _Platform = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<GameModeSize> _Sizes = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private GameModeSize _DefaultSize = new();
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _AllowFallbackToDefault;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Platform);
			(RimeWriter Writer, uint ArrayIndex) s_Sizes = p_EbxWriter.GetArrayWriter(Sizes.GetType(), Sizes.Count);
			p_Writer.Write(s_Sizes.ArrayIndex);
			foreach (var s_Entry in Sizes)
			{
				s_Entry.Serialize(s_Sizes.Writer, p_EbxWriter);
			}
			DefaultSize.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AllowFallbackToDefault);
			p_Writer.WriteNullBytes(3);
		}
	}
}
