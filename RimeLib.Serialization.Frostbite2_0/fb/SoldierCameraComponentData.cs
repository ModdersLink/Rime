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
	[ContainerType(16, 128)]
	public partial class SoldierCameraComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _ExplosionImpulseMultiplier;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _StrafeTiltStrength;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _PitchTiltStrength;

		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private RefArray<TargetCameraData> _Cameras = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CameraBinding _CameraBinding = new();

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _ForceFieldOfView;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _AuthoritativeEyePosition;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _DisableAiming;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ExplosionImpulseMultiplier);
			p_Writer.Write(StrafeTiltStrength);
			p_Writer.Write(PitchTiltStrength);
			(RimeWriter Writer, uint ArrayIndex) s_Cameras = p_EbxWriter.GetArrayWriter(Cameras.GetType(), Cameras.Count);
			p_Writer.Write(s_Cameras.ArrayIndex);
			foreach (var s_Entry in Cameras)
			{
				s_Cameras.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			CameraBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceFieldOfView);
			p_Writer.Write(AuthoritativeEyePosition);
			p_Writer.Write(DisableAiming);
			p_Writer.WriteNullBytes(2);
		}
	}
}
