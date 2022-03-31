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

namespace fb
{
	[ContainerType(4, 36)]
	public class UIMinimapConfig :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float CombatAreaCameraDelay { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float CameraInterpolationTime { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float CombatAreaFadeSpeed { get; set; }
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<UIMinimapZoomConfig> ZoomStates { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float CameraPanSensitivity { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MinVelocity { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxVelocity { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float VelocityModifier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool DisableDefaultState { get; set; }
		
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
