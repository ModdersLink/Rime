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
	[ContainerType(4, 36)]
	public class HealthStateData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<GameObjectData> Objects { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<NetworkableLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float Health { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint PartIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool PhysicsEnabled { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool CopyDamageToBanger { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool CanSupportOtherParts { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
			p_Writer.Write(s_Objects.ArrayIndex);
			foreach (var s_Entry in Objects)
			{
				s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_LoosePartPhysics = p_EbxWriter.GetArrayWriter(LoosePartPhysics.GetType(), LoosePartPhysics.Count);
			p_Writer.Write(s_LoosePartPhysics.ArrayIndex);
			foreach (var s_Entry in LoosePartPhysics)
			{
				s_LoosePartPhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(SpawnedBangerBlueprint));
			p_Writer.Write(p_EbxWriter.WriteImport(SpawnedBangerImpulseParams));
			p_Writer.Write(Health);
			p_Writer.Write(PartIndex);
			p_Writer.Write(PhysicsEnabled);
			p_Writer.Write(CopyDamageToBanger);
			p_Writer.Write(CanSupportOtherParts);
			p_Writer.WriteNullBytes(1);
		}
	}
}
