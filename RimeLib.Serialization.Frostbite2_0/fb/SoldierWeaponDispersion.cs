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
	[ContainerType(4, 68)]
	public partial class SoldierWeaponDispersion :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private FiringDispersionData _StandDispersion = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private FiringDispersionData _CrouchDispersion = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private FiringDispersionData _ProneDispersion = new();
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _JumpDispersionAngle;
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _ProneTransitionDispersionAngle;
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _MoveDispersionAngle;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _MoveZoomedDispersionAngle;
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _DecreasePerSecond;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			StandDispersion.Serialize(p_Writer, p_EbxWriter);
			CrouchDispersion.Serialize(p_Writer, p_EbxWriter);
			ProneDispersion.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(JumpDispersionAngle);
			p_Writer.Write(ProneTransitionDispersionAngle);
			p_Writer.Write(MoveDispersionAngle);
			p_Writer.Write(MoveZoomedDispersionAngle);
			p_Writer.Write(DecreasePerSecond);
		}
	}
}
