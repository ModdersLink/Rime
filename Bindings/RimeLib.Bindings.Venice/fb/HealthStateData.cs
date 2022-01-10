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
	public class HealthStateData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<GameObjectData>> Objects { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<NetworkableLoosePartPhysicsData>> LoosePartPhysics { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Health { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint PartIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool PhysicsEnabled { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool CopyDamageToBanger { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool CanSupportOtherParts { get; set; }

		public static void Deserialize(HealthStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Objects.Clear();
			(RimeReader Reader, uint Count) s_Objects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Objects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GameObjectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Objects.Reader.ReadUInt32()));
				p_Instance.Objects.Add(s_CtrRef);
			}
			
			s_Objects.Reader.Dispose();
			p_Instance.LoosePartPhysics.Clear();
			(RimeReader Reader, uint Count) s_LoosePartPhysics = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LoosePartPhysics.Count; ++i)
			{
				var s_CtrRef = new CtrRef<NetworkableLoosePartPhysicsData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_LoosePartPhysics.Reader.ReadUInt32()));
				p_Instance.LoosePartPhysics.Add(s_CtrRef);
			}
			
			s_LoosePartPhysics.Reader.Dispose();
			p_Instance.SpawnedBangerBlueprint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SpawnedBangerImpulseParams.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Health = p_Reader.ReadSingle();
			p_Instance.PartIndex = p_Reader.ReadUInt32();
			p_Instance.PhysicsEnabled = p_Reader.ReadBool();
			p_Instance.CopyDamageToBanger = p_Reader.ReadBool();
			p_Instance.CanSupportOtherParts = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
