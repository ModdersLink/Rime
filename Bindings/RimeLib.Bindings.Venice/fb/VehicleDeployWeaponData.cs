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
	public class VehicleDeployWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DeployAreaRadius { get; set; }

		[ContainerField(20)]
		public CtrRef<ObjectBlueprint> PreviewObject { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float DeployAreaGroundRayLength { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float DeployAreaGroundFlatness { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UsePreview { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool CheckClearSky { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool CanRemoteEnterVehicle { get; set; }

		public static void Deserialize(VehicleDeployWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DeployAreaRadius = p_Reader.ReadSingle();
			p_Instance.PreviewObject.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DeployAreaGroundRayLength = p_Reader.ReadSingle();
			p_Instance.DeployAreaGroundFlatness = p_Reader.ReadSingle();
			p_Instance.UsePreview = p_Reader.ReadBool();
			p_Instance.CheckClearSky = p_Reader.ReadBool();
			p_Instance.CanRemoteEnterVehicle = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
