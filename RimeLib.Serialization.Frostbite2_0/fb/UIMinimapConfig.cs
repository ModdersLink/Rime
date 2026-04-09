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
	[ContainerType(4, 36)]
	public partial class UIMinimapConfig :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _CombatAreaCameraDelay;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _CameraInterpolationTime;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _CombatAreaFadeSpeed;
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<UIMinimapZoomConfig> _ZoomStates = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _CameraPanSensitivity;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _MinVelocity;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MaxVelocity;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _VelocityModifier;
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _DisableDefaultState;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CombatAreaCameraDelay);
			p_Writer.Write(CameraInterpolationTime);
			p_Writer.Write(CombatAreaFadeSpeed);
			(RimeWriter Writer, uint ArrayIndex) s_ZoomStates = p_EbxWriter.GetArrayWriter(ZoomStates.GetType(), ZoomStates.Count);
			p_Writer.Write(s_ZoomStates.ArrayIndex);
			foreach (var s_Entry in ZoomStates)
			{
				s_Entry.Serialize(s_ZoomStates.Writer, p_EbxWriter);
			}
			p_Writer.Write(CameraPanSensitivity);
			p_Writer.Write(MinVelocity);
			p_Writer.Write(MaxVelocity);
			p_Writer.Write(VelocityModifier);
			p_Writer.Write(DisableDefaultState);
			p_Writer.WriteNullBytes(3);
		}
	}
}
