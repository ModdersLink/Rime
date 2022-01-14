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
	[ContainerType(4, 92)]
	public class SoldierHealthModuleBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef HeadShot { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef LeftArmHit { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef RightArmHit { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef LeftLegHit { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef RightLegHit { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef OnGround { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef DeathAnimationTriggered { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef RandomAnimationIndex { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef Sprinting { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef HitLeft { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef HitRight { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef HitFront { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef HitBack { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef DeathHitDirection { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public AntRef Explosion { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AntRef Dead { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntRef Revived { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public AntRef RandomValue { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public AntRef Pose { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public AntRef RightSpeed { get; set; } = new();
		
		[ContainerField(80), JsonProperty(Order = 80)]
		public AntRef ForwardSpeed { get; set; } = new();
		
		[ContainerField(84), JsonProperty(Order = 84)]
		public AntRef CriticallyHit { get; set; } = new();
		
		[ContainerField(88), JsonProperty(Order = 88)]
		public AntRef InteractiveManDown { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HeadShot.Serialize(p_Writer, p_EbxWriter);
			LeftArmHit.Serialize(p_Writer, p_EbxWriter);
			RightArmHit.Serialize(p_Writer, p_EbxWriter);
			LeftLegHit.Serialize(p_Writer, p_EbxWriter);
			RightLegHit.Serialize(p_Writer, p_EbxWriter);
			OnGround.Serialize(p_Writer, p_EbxWriter);
			DeathAnimationTriggered.Serialize(p_Writer, p_EbxWriter);
			RandomAnimationIndex.Serialize(p_Writer, p_EbxWriter);
			Sprinting.Serialize(p_Writer, p_EbxWriter);
			HitLeft.Serialize(p_Writer, p_EbxWriter);
			HitRight.Serialize(p_Writer, p_EbxWriter);
			HitFront.Serialize(p_Writer, p_EbxWriter);
			HitBack.Serialize(p_Writer, p_EbxWriter);
			DeathHitDirection.Serialize(p_Writer, p_EbxWriter);
			Explosion.Serialize(p_Writer, p_EbxWriter);
			Dead.Serialize(p_Writer, p_EbxWriter);
			Revived.Serialize(p_Writer, p_EbxWriter);
			RandomValue.Serialize(p_Writer, p_EbxWriter);
			Pose.Serialize(p_Writer, p_EbxWriter);
			RightSpeed.Serialize(p_Writer, p_EbxWriter);
			ForwardSpeed.Serialize(p_Writer, p_EbxWriter);
			CriticallyHit.Serialize(p_Writer, p_EbxWriter);
			InteractiveManDown.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
