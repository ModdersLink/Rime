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
	[ContainerType(4, 8)]
	public class MaterialRelationPropertyPair :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public RefArray<PhysicsMaterialRelationPropertyData> PhysicsMaterialProperties { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public RefArray<PhysicsPropertyRelationPropertyData> PhysicsPropertyProperties { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PhysicsMaterialProperties = p_EbxWriter.GetArrayWriter(PhysicsMaterialProperties.GetType(), PhysicsMaterialProperties.Count);
			p_Writer.Write(s_PhysicsMaterialProperties.ArrayIndex);
			foreach (var s_Entry in PhysicsMaterialProperties)
			{
				s_PhysicsMaterialProperties.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_PhysicsPropertyProperties = p_EbxWriter.GetArrayWriter(PhysicsPropertyProperties.GetType(), PhysicsPropertyProperties.Count);
			p_Writer.Write(s_PhysicsPropertyProperties.ArrayIndex);
			foreach (var s_Entry in PhysicsPropertyProperties)
			{
				s_PhysicsPropertyProperties.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
