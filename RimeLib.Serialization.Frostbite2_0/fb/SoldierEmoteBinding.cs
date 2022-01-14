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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class SoldierEmoteBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Speak { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef IsSquadLeader { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef EmoteSpot { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef EmoteOk { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef EmoteNeedARide { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef EmoteGoGoGo { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef EmoteNeedBackup { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef EmoteThanks { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef EmoteNeedMedic { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef EmoteFollowMe { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef EmoteNeedAmmo { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef EmoteSorry { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef EmoteNo { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef EmoteDefendCapturePoint { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public AntRef EmoteAttackCapturePoint { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AntRef EmoteMoveToPosition { get; set; } = new();
		
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
