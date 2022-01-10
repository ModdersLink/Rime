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
	[ContainerType(4, 36)]
	public class UIMinimapConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CombatAreaCameraDelay { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CameraInterpolationTime { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CombatAreaFadeSpeed { get; set; }
		
		[ContainerField(12)]
		public List<UIMinimapZoomConfig> ZoomStates { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CameraPanSensitivity { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinVelocity { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float VelocityModifier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DisableDefaultState { get; set; }
		
		public static void Deserialize(UIMinimapConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CombatAreaCameraDelay = p_Reader.ReadSingle();
			p_Instance.CameraInterpolationTime = p_Reader.ReadSingle();
			p_Instance.CombatAreaFadeSpeed = p_Reader.ReadSingle();
			p_Instance.ZoomStates.Clear();
			(RimeReader Reader, uint Count) s_ZoomStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ZoomStates.Count; ++i)
			{
				var s_Value = new UIMinimapZoomConfig();
				fb.UIMinimapZoomConfig.Deserialize(s_Value, s_ZoomStates.Reader, p_Parser);
				p_Instance.ZoomStates.Add(s_Value);
			}
			
			s_ZoomStates.Reader.Dispose();
			p_Instance.CameraPanSensitivity = p_Reader.ReadSingle();
			p_Instance.MinVelocity = p_Reader.ReadSingle();
			p_Instance.MaxVelocity = p_Reader.ReadSingle();
			p_Instance.VelocityModifier = p_Reader.ReadSingle();
			p_Instance.DisableDefaultState = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
