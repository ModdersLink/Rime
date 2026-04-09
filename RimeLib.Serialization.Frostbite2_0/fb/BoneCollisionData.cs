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
	[ContainerType(16, 144)]
	public partial class BoneCollisionData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec4 _DebugDrawColor = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _CapsuleOffset = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _BoneName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private HitReactionType _AnimationHitReactionType = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<MaterialContainerPair> _MaterialPair = new();
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _BoneAxis;
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _CapsuleLength;
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _CapsuleRadius;
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private PitchModifier _MinPitch = new();
		
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private PitchModifier _MaxPitch = new();
		
		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _ValidInHiLod;
		
		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _ValidInLowLod;
		
		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _UsePhysicsRotation;
		
		[ObservableProperty]
		[property: ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		private bool _DeactivateIfBehindWall;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			DebugDrawColor.Serialize(p_Writer, p_EbxWriter);
			CapsuleOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(BoneName));
			p_Writer.Write((int) AnimationHitReactionType);
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialPair));
			p_Writer.Write(BoneAxis);
			p_Writer.Write(CapsuleLength);
			p_Writer.Write(CapsuleRadius);
			p_Writer.WriteNullBytes(8);
			MinPitch.Serialize(p_Writer, p_EbxWriter);
			MaxPitch.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ValidInHiLod);
			p_Writer.Write(ValidInLowLod);
			p_Writer.Write(UsePhysicsRotation);
			p_Writer.Write(DeactivateIfBehindWall);
			p_Writer.WriteNullBytes(12);
		}
	}
}
