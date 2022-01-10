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
	[ContainerType(1, 5)]
	public class WeaponMiscModifierSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; }
		
		public static void Deserialize(WeaponMiscModifierSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EnableBreathControl = p_Reader.ReadBool();
			p_Instance.CanBeInSupportedShooting = p_Reader.ReadBool();
			p_Instance.UnZoomOnBoltAction = p_Reader.ReadBool();
			p_Instance.HoldBoltActionUntilZoomRelease = p_Reader.ReadBool();
			p_Instance.IsSilenced = p_Reader.ReadBool();
		}
	}
}
