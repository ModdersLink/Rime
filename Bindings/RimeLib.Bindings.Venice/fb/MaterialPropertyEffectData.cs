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
	[ContainerType(4, 12)]
	public class MaterialPropertyEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public List<CtrRef<EffectBlueprint>> ImpactEffects { get; set; } = new();

		public static void Deserialize(MaterialPropertyEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
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
		}

	}
}
