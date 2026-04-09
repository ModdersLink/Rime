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
	public partial class EntryComponentHudData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private int _Index;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private EntrySeatType _SeatType = new();
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _Frustum;
		
		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _Visible;
		
		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _MaximizeMiniMapOnEntry;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Index);
			p_Writer.Write((int) SeatType);
			p_Writer.Write(Frustum);
			p_Writer.Write(Visible);
			p_Writer.Write(MaximizeMiniMapOnEntry);
			p_Writer.WriteNullBytes(1);
		}
	}
}
