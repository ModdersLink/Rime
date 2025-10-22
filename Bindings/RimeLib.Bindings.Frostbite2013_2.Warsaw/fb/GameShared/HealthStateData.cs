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

namespace fb.GameShared;

[ContainerType(8, 64)]
public class HealthStateData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<GameObjectData> Objects { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<NetworkableLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float Health { get; set; } = 100.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint PartIndex { get; set; } = 4294967295;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool CopyDamageToBanger { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool PhysicsEnabled { get; set; } = true;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool Indestructable { get; set; } = false;
	
	[ContainerField(0x3b), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
	public bool CanSupportOtherParts { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
		p_Writer.Write(s_Objects.ArrayIndex);
		foreach (var s_Entry in Objects)
		{
			s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LoosePartPhysics = p_EbxWriter.GetArrayWriter(LoosePartPhysics.GetType(), LoosePartPhysics.Count);
		p_Writer.Write(s_LoosePartPhysics.ArrayIndex);
		foreach (var s_Entry in LoosePartPhysics)
		{
			s_LoosePartPhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpawnedBangerBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpawnedBangerImpulseParams));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Health);
		p_Writer.Write(PartIndex);
		p_Writer.Write(CopyDamageToBanger);
		p_Writer.Write(PhysicsEnabled);
		p_Writer.Write(Indestructable);
		p_Writer.Write(CanSupportOtherParts);
		p_Writer.WriteNullBytes(4);
	}
}

