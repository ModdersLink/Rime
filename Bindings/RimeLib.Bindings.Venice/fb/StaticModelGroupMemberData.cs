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
	[ContainerType(4, 56)]
	public class StaticModelGroupMemberData
	{
		[ContainerField(0)]
		public List<LinearTransform> InstanceTransforms { get; set; } = new();
		
		[ContainerField(4)]
		public List<float> InstanceScale { get; set; } = new();
		
		[ContainerField(8)]
		public List<uint> InstanceObjectVariation { get; set; } = new();
		
		[ContainerField(12)]
		public List<bool> InstanceCastSunShadow { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<GamePhysicsEntityData> MemberType { get; set; } = new();
		
		[ContainerField(20)]
		public CtrRef<EntityData> MeshEntityType { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint InstanceCount { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint HealthStateEntityManagerId { get; set; }
		
		[ContainerField(32)]
		public IndexRange PhysicsPartRange { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint PhysicsPartCountPerInstance { get; set; }
		
		[ContainerField(44)]
		public IndexRange NetworkIdRange { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint NetworkIdCountPerInstance { get; set; }
		
		public static void Deserialize(StaticModelGroupMemberData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InstanceTransforms.Clear();
			(RimeReader Reader, uint Count) s_InstanceTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InstanceTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_InstanceTransforms.Reader, p_Parser);
				p_Instance.InstanceTransforms.Add(s_Value);
			}
			
			s_InstanceTransforms.Reader.Dispose();
			p_Instance.InstanceScale.Clear();
			(RimeReader Reader, uint Count) s_InstanceScale = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InstanceScale.Count; ++i)
			{
				var s_Value = s_InstanceScale.Reader.ReadSingle();
				p_Instance.InstanceScale.Add(s_Value);
			}
			
			s_InstanceScale.Reader.Dispose();
			p_Instance.InstanceObjectVariation.Clear();
			(RimeReader Reader, uint Count) s_InstanceObjectVariation = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InstanceObjectVariation.Count; ++i)
			{
				var s_Value = s_InstanceObjectVariation.Reader.ReadUInt32();
				p_Instance.InstanceObjectVariation.Add(s_Value);
			}
			
			s_InstanceObjectVariation.Reader.Dispose();
			p_Instance.InstanceCastSunShadow.Clear();
			(RimeReader Reader, uint Count) s_InstanceCastSunShadow = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InstanceCastSunShadow.Count; ++i)
			{
				var s_Value = s_InstanceCastSunShadow.Reader.ReadBool();
				p_Instance.InstanceCastSunShadow.Add(s_Value);
			}
			
			s_InstanceCastSunShadow.Reader.Dispose();
			p_Instance.MemberType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MeshEntityType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InstanceCount = p_Reader.ReadUInt32();
			p_Instance.HealthStateEntityManagerId = p_Reader.ReadUInt32();
			fb.IndexRange.Deserialize(p_Instance.PhysicsPartRange, p_Reader, p_Parser);
			p_Instance.PhysicsPartCountPerInstance = p_Reader.ReadUInt32();
			fb.IndexRange.Deserialize(p_Instance.NetworkIdRange, p_Reader, p_Parser);
			p_Instance.NetworkIdCountPerInstance = p_Reader.ReadUInt32();
		}
	}
}
