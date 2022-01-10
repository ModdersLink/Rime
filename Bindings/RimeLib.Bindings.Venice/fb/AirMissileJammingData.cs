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
	[ContainerType(4, 48)]
	public class AirMissileJammingData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinTurnSpeed { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxRadius { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MinRadius { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Theta { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Phi { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float UpdateJammingPositionTime { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxTurnSpeed { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float QuietModeProbability { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float QuietModeTime { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float JammingTime { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float TurnCalculationTime { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool EnableAirMissileJamming { get; set; }
		
		public static void Deserialize(AirMissileJammingData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinTurnSpeed = p_Reader.ReadSingle();
			p_Instance.MaxRadius = p_Reader.ReadSingle();
			p_Instance.MinRadius = p_Reader.ReadSingle();
			p_Instance.Theta = p_Reader.ReadSingle();
			p_Instance.Phi = p_Reader.ReadSingle();
			p_Instance.UpdateJammingPositionTime = p_Reader.ReadSingle();
			p_Instance.MaxTurnSpeed = p_Reader.ReadSingle();
			p_Instance.QuietModeProbability = p_Reader.ReadSingle();
			p_Instance.QuietModeTime = p_Reader.ReadSingle();
			p_Instance.JammingTime = p_Reader.ReadSingle();
			p_Instance.TurnCalculationTime = p_Reader.ReadSingle();
			p_Instance.EnableAirMissileJamming = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
