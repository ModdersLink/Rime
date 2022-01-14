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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 48)]
	public class AILocoVaultTaskData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 StartPoint { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float DistanceBeforeVault { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float HeightBeforeVault { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float HeightAfterVault { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float LengthOfVaultableObject { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float WorldAngle { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float DistanceAfterVault { get; set; }
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public WaypointVaultType VaultType { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool UseClientPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			StartPoint.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DistanceBeforeVault);
			p_Writer.Write(HeightBeforeVault);
			p_Writer.Write(HeightAfterVault);
			p_Writer.Write(LengthOfVaultableObject);
			p_Writer.Write(WorldAngle);
			p_Writer.Write(DistanceAfterVault);
			p_Writer.Write((int) VaultType);
			p_Writer.Write(UseClientPosition);
			p_Writer.WriteNullBytes(3);
		}
	}
}
