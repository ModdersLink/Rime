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
	[ContainerType(4, 64)]
	public partial class SoldierEmoteBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _Speak = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _IsSquadLeader = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _EmoteSpot = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _EmoteOk = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _EmoteNeedARide = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _EmoteGoGoGo = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _EmoteNeedBackup = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _EmoteThanks = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _EmoteNeedMedic = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _EmoteFollowMe = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _EmoteNeedAmmo = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _EmoteSorry = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _EmoteNo = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _EmoteDefendCapturePoint = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _EmoteAttackCapturePoint = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AntRef _EmoteMoveToPosition = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Speak.Serialize(p_Writer, p_EbxWriter);
			IsSquadLeader.Serialize(p_Writer, p_EbxWriter);
			EmoteSpot.Serialize(p_Writer, p_EbxWriter);
			EmoteOk.Serialize(p_Writer, p_EbxWriter);
			EmoteNeedARide.Serialize(p_Writer, p_EbxWriter);
			EmoteGoGoGo.Serialize(p_Writer, p_EbxWriter);
			EmoteNeedBackup.Serialize(p_Writer, p_EbxWriter);
			EmoteThanks.Serialize(p_Writer, p_EbxWriter);
			EmoteNeedMedic.Serialize(p_Writer, p_EbxWriter);
			EmoteFollowMe.Serialize(p_Writer, p_EbxWriter);
			EmoteNeedAmmo.Serialize(p_Writer, p_EbxWriter);
			EmoteSorry.Serialize(p_Writer, p_EbxWriter);
			EmoteNo.Serialize(p_Writer, p_EbxWriter);
			EmoteDefendCapturePoint.Serialize(p_Writer, p_EbxWriter);
			EmoteAttackCapturePoint.Serialize(p_Writer, p_EbxWriter);
			EmoteMoveToPosition.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
