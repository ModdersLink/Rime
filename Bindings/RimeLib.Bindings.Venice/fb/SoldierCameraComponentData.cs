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
	[ContainerType(16, 128)]
	public class SoldierCameraComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ExplosionImpulseMultiplier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float StrafeTiltStrength { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float PitchTiltStrength { get; set; }

		[ContainerField(108)]
		public List<CtrRef<TargetCameraData>> Cameras { get; set; } = new();

		[ContainerField(112)]
		public CameraBinding CameraBinding { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool AuthoritativeEyePosition { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool DisableAiming { get; set; }

		public static void Deserialize(SoldierCameraComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ExplosionImpulseMultiplier = p_Reader.ReadSingle();
			p_Instance.StrafeTiltStrength = p_Reader.ReadSingle();
			p_Instance.PitchTiltStrength = p_Reader.ReadSingle();
			p_Instance.Cameras.Clear();
			(RimeReader Reader, uint Count) s_Cameras = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Cameras.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TargetCameraData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Cameras.Reader.ReadUInt32()));
				p_Instance.Cameras.Add(s_CtrRef);
			}
			
			s_Cameras.Reader.Dispose();
			fb.CameraBinding.Deserialize(p_Instance.CameraBinding, p_Reader, p_Parser);
			p_Instance.ForceFieldOfView = p_Reader.ReadSingle();
			p_Instance.AuthoritativeEyePosition = p_Reader.ReadBool();
			p_Instance.DisableAiming = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
