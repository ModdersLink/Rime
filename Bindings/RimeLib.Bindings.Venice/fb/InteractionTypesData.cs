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
	[ContainerType(1, 6)]
	public class InteractionTypesData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool InteractionEntity { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool PickupEntity { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool AmmoCrateEntity { get; set; }
		
		[ContainerField(3), LayoutImmutable, Blittable]
		public bool VehicleEntity { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool ExplosionPackEntity { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable]
		public bool SoldierEntity { get; set; }
		
		public static void Deserialize(InteractionTypesData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InteractionEntity = p_Reader.ReadBool();
			p_Instance.PickupEntity = p_Reader.ReadBool();
			p_Instance.AmmoCrateEntity = p_Reader.ReadBool();
			p_Instance.VehicleEntity = p_Reader.ReadBool();
			p_Instance.ExplosionPackEntity = p_Reader.ReadBool();
			p_Instance.SoldierEntity = p_Reader.ReadBool();
		}
	}
}
