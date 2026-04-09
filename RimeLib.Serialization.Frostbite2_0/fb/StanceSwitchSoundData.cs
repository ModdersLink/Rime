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
	[ContainerType(4, 8)]
	public partial class StanceSwitchSoundData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private CtrRef<SoundAsset> _StanceSwitchSound = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<int> _ValidStances = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(StanceSwitchSound));
			(RimeWriter Writer, uint ArrayIndex) s_ValidStances = p_EbxWriter.GetArrayWriter(ValidStances.GetType(), ValidStances.Count);
			p_Writer.Write(s_ValidStances.ArrayIndex);
			foreach (var s_Entry in ValidStances)
			{
				s_ValidStances.Writer.Write(s_Entry);
			}
		}
	}
}
