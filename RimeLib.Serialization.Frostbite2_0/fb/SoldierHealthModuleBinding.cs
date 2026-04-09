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
	[ContainerType(4, 92)]
	public partial class SoldierHealthModuleBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _HeadShot = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _LeftArmHit = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _RightArmHit = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _LeftLegHit = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _RightLegHit = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _OnGround = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _DeathAnimationTriggered = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _RandomAnimationIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _Sprinting = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _HitLeft = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _HitRight = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _HitFront = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _HitBack = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _DeathHitDirection = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _Explosion = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AntRef _Dead = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AntRef _Revived = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AntRef _RandomValue = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AntRef _Pose = new();
		
		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private AntRef _RightSpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AntRef _ForwardSpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private AntRef _CriticallyHit = new();
		
		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private AntRef _InteractiveManDown = new();
		
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
