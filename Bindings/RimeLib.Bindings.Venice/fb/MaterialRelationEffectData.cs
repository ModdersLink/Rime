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
	[ContainerType(4, 24)]
	public class MaterialRelationEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public List<CtrRef<EffectBlueprint>> ImpactEffects { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<ObjectBlueprint>> ImpactDebris { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ImpactEffectMaxSpreadAngle { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool MirrorImpactDirection { get; set; }

		public static void Deserialize(MaterialRelationEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ImpactEffects.Clear();
			(RimeReader Reader, uint Count) s_ImpactEffects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ImpactEffects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EffectBlueprint>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ImpactEffects.Reader.ReadUInt32()));
				p_Instance.ImpactEffects.Add(s_CtrRef);
			}
			
			s_ImpactEffects.Reader.Dispose();
			p_Instance.ImpactDebris.Clear();
			(RimeReader Reader, uint Count) s_ImpactDebris = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ImpactDebris.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ObjectBlueprint>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ImpactDebris.Reader.ReadUInt32()));
				p_Instance.ImpactDebris.Add(s_CtrRef);
			}
			
			s_ImpactDebris.Reader.Dispose();
			p_Instance.ImpactEffectMaxSpreadAngle = p_Reader.ReadSingle();
			p_Instance.MirrorImpactDirection = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
