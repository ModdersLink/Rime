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
		
	}
}
