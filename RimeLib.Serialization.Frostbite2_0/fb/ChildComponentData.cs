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
	[ContainerType(16, 224)]
	public partial class ChildComponentData :
		PartComponentData
	{
		[ObservableProperty]
		[property: ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private LinearTransform _AlignTransform = new();

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private CtrRef<MovingBodyData> _MovingBody = new();

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private VehicleHealthZoneData _HealthZone = new();

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _SoundEffectStartRpm;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private float _SoundEffectStopRpm;

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private CtrRef<AlignmentData> _AlignmentSettings = new();

		[ObservableProperty]
		[property: ContainerField(212), JsonProperty(Order = 212)]
		private CtrRef<SoundAsset> _SoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private bool _EnableAlignToCamera;

		[ObservableProperty]
		[property: ContainerField(217), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
		private bool _WorldSpacePositionLock;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AlignTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MovingBody));
			HealthZone.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SoundEffectStartRpm);
			p_Writer.Write(SoundEffectStopRpm);
			p_Writer.Write(p_EbxWriter.WriteImport(AlignmentSettings));
			p_Writer.Write(p_EbxWriter.WriteImport(SoundEffect));
			p_Writer.Write(EnableAlignToCamera);
			p_Writer.Write(WorldSpacePositionLock);
			p_Writer.WriteNullBytes(6);
		}
	}
}
