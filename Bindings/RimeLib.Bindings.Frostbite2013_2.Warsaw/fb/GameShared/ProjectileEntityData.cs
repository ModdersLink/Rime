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

using fb.Core;
using fb.Entity;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 224)]
public class ProjectileEntityData
	: fb.Physics.GamePhysicsEntityData
{
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float InitialSpeed { get; set; } = 350.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float TimeToLive { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public uint MaxCount { get; set; } = 0;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float InitMeshHideTime { get; set; } = 0.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float VisualConvergeDistance { get; set; } = 30.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float VisualConvergenceDelay { get; set; } = 0.100f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float VisualConvergenceDuration { get; set; } = 0.100f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ProxyVisualConvergenceDelay { get; set; } = -1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float ProxyVisualConvergenceDuration { get; set; } = -1.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public CtrRef<WeaponSuppressionData> SuppressionData { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public string AmmunitionType { get; set; } = string.Empty;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public MaterialDecl MaterialPair { get; set; } = new();
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public AntHitReactionWeaponType HitReactionWeaponType { get; set; } = AntHitReactionWeaponType.AntHitReactionWeaponType_AssaultRifle;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool DetonateOnTimeout { get; set; } = false;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool ServerProjectileDisabled { get; set; } = false;
	
	[ContainerField(0xda), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
	public bool HideOnDetonation { get; set; } = false;
	
	[ContainerField(0xdb), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
	public bool VehicleLightingEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InitialSpeed);
		p_Writer.Write(TimeToLive);
		p_Writer.Write(MaxCount);
		p_Writer.Write(InitMeshHideTime);
		p_Writer.Write(VisualConvergeDistance);
		p_Writer.Write(VisualConvergenceDelay);
		p_Writer.Write(VisualConvergenceDuration);
		p_Writer.Write(ProxyVisualConvergenceDelay);
		p_Writer.Write(ProxyVisualConvergenceDuration);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SuppressionData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(AmmunitionType));
		MaterialPair.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) HitReactionWeaponType);
		p_Writer.Write(DetonateOnTimeout);
		p_Writer.Write(ServerProjectileDisabled);
		p_Writer.Write(HideOnDetonation);
		p_Writer.Write(VehicleLightingEnable);
		p_Writer.WriteNullBytes(4);
	}
}

