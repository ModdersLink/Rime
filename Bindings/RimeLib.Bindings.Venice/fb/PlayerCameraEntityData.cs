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
	public class PlayerCameraEntityData : 
		CameraEntityBaseData
	{
		[ContainerField(96)]
		public TargetMode SoldierTargetMode { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint SoldierCameraIndex { get; set; }

		[ContainerField(104)]
		public TargetMode VehicleTargetMode { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint VehicleCameraIndex { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ReleaseControlIfTargetLost { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable]
		public bool ShouldTargetControllable { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable]
		public bool ShouldTargetVehicleDriverEntry { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable]
		public bool ShouldTargetExtraPlayerInDoublePlayerEvent { get; set; }

		public static void Deserialize(PlayerCameraEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SoldierTargetMode = (TargetMode) p_Reader.ReadInt32();
			p_Instance.SoldierCameraIndex = p_Reader.ReadUInt32();
			p_Instance.VehicleTargetMode = (TargetMode) p_Reader.ReadInt32();
			p_Instance.VehicleCameraIndex = p_Reader.ReadUInt32();
			p_Instance.ReleaseControlIfTargetLost = p_Reader.ReadBool();
			p_Instance.ShouldTargetControllable = p_Reader.ReadBool();
			p_Instance.ShouldTargetVehicleDriverEntry = p_Reader.ReadBool();
			p_Instance.ShouldTargetExtraPlayerInDoublePlayerEvent = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
