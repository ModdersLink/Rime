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
	[ContainerType(16, 48)]
	public partial class DebrisClusterPartInfoData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private Vec3 _AngularVelocity = new();
		
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _LinearVelocity = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _NumberOfChildren;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private int _PartIndex;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _SplitSpeedThreshold;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _InEffectWorldOnly;
		
		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _SyncRestPosition;
		
		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _SyncContinous;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AngularVelocity.Serialize(p_Writer, p_EbxWriter);
			LinearVelocity.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NumberOfChildren);
			p_Writer.Write(PartIndex);
			p_Writer.Write(SplitSpeedThreshold);
			p_Writer.Write(InEffectWorldOnly);
			p_Writer.Write(SyncRestPosition);
			p_Writer.Write(SyncContinous);
			p_Writer.WriteNullBytes(1);
		}
	}
}
