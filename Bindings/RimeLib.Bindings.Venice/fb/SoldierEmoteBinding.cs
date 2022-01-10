///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class SoldierEmoteBinding
	{
		[ContainerField(0)]
		public AntRef Speak { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef IsSquadLeader { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef EmoteSpot { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef EmoteOk { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef EmoteNeedARide { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef EmoteGoGoGo { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef EmoteNeedBackup { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef EmoteThanks { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef EmoteNeedMedic { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef EmoteFollowMe { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef EmoteNeedAmmo { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef EmoteSorry { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef EmoteNo { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef EmoteDefendCapturePoint { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef EmoteAttackCapturePoint { get; set; } = new();
		
		[ContainerField(60)]
		public AntRef EmoteMoveToPosition { get; set; } = new();
		
		public static void Deserialize(SoldierEmoteBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Speak, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IsSquadLeader, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteSpot, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteOk, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteNeedARide, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteGoGoGo, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteNeedBackup, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteThanks, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteNeedMedic, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteFollowMe, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteNeedAmmo, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteSorry, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteNo, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteDefendCapturePoint, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteAttackCapturePoint, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EmoteMoveToPosition, p_Reader, p_Parser);
		}
	}
}
