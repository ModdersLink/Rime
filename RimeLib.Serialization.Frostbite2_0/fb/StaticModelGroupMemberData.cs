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

namespace fb
{
	[ContainerType(4, 56)]
	public class StaticModelGroupMemberData
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<LinearTransform> InstanceTransforms { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<float> InstanceScale { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<uint> InstanceObjectVariation { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<bool> InstanceCastSunShadow { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<GamePhysicsEntityData> MemberType { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<EntityData> MeshEntityType { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint InstanceCount { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint HealthStateEntityManagerId { get; set; }
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public IndexRange PhysicsPartRange { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint PhysicsPartCountPerInstance { get; set; }
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public IndexRange NetworkIdRange { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public uint NetworkIdCountPerInstance { get; set; }
		
	}
}
