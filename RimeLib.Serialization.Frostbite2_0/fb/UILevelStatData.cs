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
	[ContainerType(4, 16)]
	public partial class UILevelStatData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _StatEasy = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _StatMedium = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _StatHard = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _StatHardcore = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StatEasy));
			p_Writer.Write(p_EbxWriter.WriteString(StatMedium));
			p_Writer.Write(p_EbxWriter.WriteString(StatHard));
			p_Writer.Write(p_EbxWriter.WriteString(StatHardcore));
		}
	}
}
