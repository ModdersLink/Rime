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
	public class AmmoConfigData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int MagazineCapacity { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int NumberOfMagazines { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint TraceFrequency { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint AmmoPickupMinAmount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint AmmoPickupMaxAmount { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AutoReplenishDelay { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int AmmoBagPickupAmount { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float AmmoBagPickupDelayMultiplier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool AutoReplenishMagazine { get; set; }
		
		public static void Deserialize(AmmoConfigData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MagazineCapacity = p_Reader.ReadInt32();
			p_Instance.NumberOfMagazines = p_Reader.ReadInt32();
			p_Instance.TraceFrequency = p_Reader.ReadUInt32();
			p_Instance.AmmoPickupMinAmount = p_Reader.ReadUInt32();
			p_Instance.AmmoPickupMaxAmount = p_Reader.ReadUInt32();
			p_Instance.AutoReplenishDelay = p_Reader.ReadSingle();
			p_Instance.AmmoBagPickupAmount = p_Reader.ReadInt32();
			p_Instance.AmmoBagPickupDelayMultiplier = p_Reader.ReadSingle();
			p_Instance.AutoReplenishMagazine = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
