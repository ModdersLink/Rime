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
	[ContainerType(4, 28)]
	public partial class GameModeSize :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Name = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _ShortName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _MetaIdentifier = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _PlayerCount;
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<GameModeTeamSize> _Teams = new();
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _RoundsPerMap;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _ForceSquad;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(ShortName));
			p_Writer.Write(p_EbxWriter.WriteString(MetaIdentifier));
			p_Writer.Write(PlayerCount);
			(RimeWriter Writer, uint ArrayIndex) s_Teams = p_EbxWriter.GetArrayWriter(Teams.GetType(), Teams.Count);
			p_Writer.Write(s_Teams.ArrayIndex);
			foreach (var s_Entry in Teams)
			{
				s_Entry.Serialize(s_Teams.Writer, p_EbxWriter);
			}
			p_Writer.Write(RoundsPerMap);
			p_Writer.Write(ForceSquad);
			p_Writer.WriteNullBytes(3);
		}
	}
}
