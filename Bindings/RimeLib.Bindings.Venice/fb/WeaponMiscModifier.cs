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
	[ContainerType(4, 16)]
	public class WeaponMiscModifier : 
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; }

		[ContainerField(9), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; }

		[ContainerField(11), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; }

		public static void Deserialize(WeaponMiscModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EnableBreathControl = p_Reader.ReadBool();
			p_Instance.CanBeInSupportedShooting = p_Reader.ReadBool();
			p_Instance.UnZoomOnBoltAction = p_Reader.ReadBool();
			p_Instance.HoldBoltActionUntilZoomRelease = p_Reader.ReadBool();
			p_Instance.IsSilenced = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
