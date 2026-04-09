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
	[ContainerType(4, 116)]
	public partial class PhysicsDrivenAnimationEntityBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _AimLeftRight = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _AimUpDown = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _Crouch = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _ForceSetTrajectory = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _InAir = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _Skydive = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _Parachute = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _Swim = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _InputBackward = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _InputForward = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _InputLeft = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _InputRight = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _IsEnemy = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _Jump = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _LeanLeftRight = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AntRef _Prone = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AntRef _Sprint = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AntRef _GroundSupported = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AntRef _GroundNormal = new();
		
		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private AntRef _GroundDistance = new();
		
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AntRef _GroundAngleZ = new();
		
		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private AntRef _GroundAngleX = new();
		
		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private AntRef _GroundAngleFromNormal = new();
		
		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private AntRef _IsClientAnimatable = new();
		
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AntRef _CustomizationScreen = new();
		
		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private AntRef _Minimal3pServer = new();
		
		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AntRef _VerticalImpact = new();
		
		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private AntRef _FalseSignal = new();
		
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AntRef _LockArmsToCameraWeight = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimLeftRight.Serialize(p_Writer, p_EbxWriter);
			AimUpDown.Serialize(p_Writer, p_EbxWriter);
			Crouch.Serialize(p_Writer, p_EbxWriter);
			ForceSetTrajectory.Serialize(p_Writer, p_EbxWriter);
			InAir.Serialize(p_Writer, p_EbxWriter);
			Skydive.Serialize(p_Writer, p_EbxWriter);
			Parachute.Serialize(p_Writer, p_EbxWriter);
			Swim.Serialize(p_Writer, p_EbxWriter);
			InputBackward.Serialize(p_Writer, p_EbxWriter);
			InputForward.Serialize(p_Writer, p_EbxWriter);
			InputLeft.Serialize(p_Writer, p_EbxWriter);
			InputRight.Serialize(p_Writer, p_EbxWriter);
			IsEnemy.Serialize(p_Writer, p_EbxWriter);
			Jump.Serialize(p_Writer, p_EbxWriter);
			LeanLeftRight.Serialize(p_Writer, p_EbxWriter);
			Prone.Serialize(p_Writer, p_EbxWriter);
			Sprint.Serialize(p_Writer, p_EbxWriter);
			GroundSupported.Serialize(p_Writer, p_EbxWriter);
			GroundNormal.Serialize(p_Writer, p_EbxWriter);
			GroundDistance.Serialize(p_Writer, p_EbxWriter);
			GroundAngleZ.Serialize(p_Writer, p_EbxWriter);
			GroundAngleX.Serialize(p_Writer, p_EbxWriter);
			GroundAngleFromNormal.Serialize(p_Writer, p_EbxWriter);
			IsClientAnimatable.Serialize(p_Writer, p_EbxWriter);
			CustomizationScreen.Serialize(p_Writer, p_EbxWriter);
			Minimal3pServer.Serialize(p_Writer, p_EbxWriter);
			VerticalImpact.Serialize(p_Writer, p_EbxWriter);
			FalseSignal.Serialize(p_Writer, p_EbxWriter);
			LockArmsToCameraWeight.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
