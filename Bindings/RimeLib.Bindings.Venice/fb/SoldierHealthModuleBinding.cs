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
	[ContainerType(4, 92)]
	public class SoldierHealthModuleBinding
	{
		[ContainerField(0)]
		public AntRef HeadShot { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef LeftArmHit { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef RightArmHit { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef LeftLegHit { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef RightLegHit { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef OnGround { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef DeathAnimationTriggered { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef RandomAnimationIndex { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef Sprinting { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef HitLeft { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef HitRight { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef HitFront { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef HitBack { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef DeathHitDirection { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef Explosion { get; set; } = new();
		
		[ContainerField(60)]
		public AntRef Dead { get; set; } = new();
		
		[ContainerField(64)]
		public AntRef Revived { get; set; } = new();
		
		[ContainerField(68)]
		public AntRef RandomValue { get; set; } = new();
		
		[ContainerField(72)]
		public AntRef Pose { get; set; } = new();
		
		[ContainerField(76)]
		public AntRef RightSpeed { get; set; } = new();
		
		[ContainerField(80)]
		public AntRef ForwardSpeed { get; set; } = new();
		
		[ContainerField(84)]
		public AntRef CriticallyHit { get; set; } = new();
		
		[ContainerField(88)]
		public AntRef InteractiveManDown { get; set; } = new();
		
		public static void Deserialize(SoldierHealthModuleBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.HeadShot, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LeftArmHit, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RightArmHit, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LeftLegHit, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RightLegHit, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.OnGround, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DeathAnimationTriggered, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RandomAnimationIndex, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Sprinting, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HitLeft, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HitRight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HitFront, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HitBack, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DeathHitDirection, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Explosion, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Dead, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Revived, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RandomValue, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Pose, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RightSpeed, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ForwardSpeed, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CriticallyHit, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InteractiveManDown, p_Reader, p_Parser);
		}
	}
}
