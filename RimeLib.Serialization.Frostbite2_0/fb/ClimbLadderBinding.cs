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
	[ContainerType(4, 24)]
	public partial class ClimbLadderBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _ClimbLadderPhase = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _ClimbLadderConnectPhase = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _ClimbLadderTransitionPhase = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _OnLadder = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _LadderTopTransition = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _FallHigh = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ClimbLadderPhase.Serialize(p_Writer, p_EbxWriter);
			ClimbLadderConnectPhase.Serialize(p_Writer, p_EbxWriter);
			ClimbLadderTransitionPhase.Serialize(p_Writer, p_EbxWriter);
			OnLadder.Serialize(p_Writer, p_EbxWriter);
			LadderTopTransition.Serialize(p_Writer, p_EbxWriter);
			FallHigh.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
