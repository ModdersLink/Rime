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
	[ContainerType(4, 8)]
	public class MaterialRelationPropertyPair
	{
		[ContainerField(0)]
		public List<CtrRef<PhysicsMaterialRelationPropertyData>> PhysicsMaterialProperties { get; set; } = new();
		
		[ContainerField(4)]
		public List<CtrRef<PhysicsPropertyRelationPropertyData>> PhysicsPropertyProperties { get; set; } = new();
		
		public static void Deserialize(MaterialRelationPropertyPair p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PhysicsMaterialProperties.Clear();
			(RimeReader Reader, uint Count) s_PhysicsMaterialProperties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PhysicsMaterialProperties.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PhysicsMaterialRelationPropertyData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PhysicsMaterialProperties.Reader.ReadUInt32()));
				p_Instance.PhysicsMaterialProperties.Add(s_CtrRef);
			}
			
			s_PhysicsMaterialProperties.Reader.Dispose();
			p_Instance.PhysicsPropertyProperties.Clear();
			(RimeReader Reader, uint Count) s_PhysicsPropertyProperties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PhysicsPropertyProperties.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PhysicsPropertyRelationPropertyData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PhysicsPropertyProperties.Reader.ReadUInt32()));
				p_Instance.PhysicsPropertyProperties.Add(s_CtrRef);
			}
			
			s_PhysicsPropertyProperties.Reader.Dispose();
		}
	}
}
