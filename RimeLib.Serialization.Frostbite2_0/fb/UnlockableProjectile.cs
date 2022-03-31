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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 32)]
	public class UnlockableProjectile :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 InitialSpeed { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<ProjectileEntityData> ProjectileData { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<ProjectileBlueprint> Projectile { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UnlockAssetBase> Unlock { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			InitialSpeed.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(ProjectileData));
			p_Writer.Write(p_EbxWriter.WriteImport(Projectile));
			p_Writer.Write(p_EbxWriter.WriteImport(Unlock));
			p_Writer.WriteNullBytes(4);
		}
	}
}
