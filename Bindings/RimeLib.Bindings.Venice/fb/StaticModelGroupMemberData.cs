///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class StaticModelGroupMemberData : FrostbiteContainer
	{
		[ContainerField(0)]
		public List<LinearTransform> InstanceTransforms { get; set; } = new List<LinearTransform>(); // 0x0 (0)
		
		[ContainerField(4)]
		public List<float> InstanceScale { get; set; } = new List<float>(); // 0x4 (4)
		
		[ContainerField(8)]
		public List<uint> InstanceObjectVariation { get; set; } = new List<uint>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<bool> InstanceCastSunShadow { get; set; } = new List<bool>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<GamePhysicsEntityData> MemberType { get; set; } = new CtrRef<GamePhysicsEntityData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<EntityData> MeshEntityType { get; set; } = new CtrRef<EntityData>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint InstanceCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint HealthStateEntityManagerId { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public IndexRange PhysicsPartRange { get; set; } = new IndexRange(); // 0x20 (32)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint PhysicsPartCountPerInstance { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public IndexRange NetworkIdRange { get; set; } = new IndexRange(); // 0x2C (44)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint NetworkIdCountPerInstance { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3878849363:
					InstanceTransforms = (List<LinearTransform>) p_Value;
					break;

				case 555924372:
					InstanceScale = (List<float>) p_Value;
					break;

				case 2895987976:
					InstanceObjectVariation = (List<uint>) p_Value;
					break;

				case 621670215:
					InstanceCastSunShadow = (List<bool>) p_Value;
					break;

				case 2244878317:
					MemberType = (CtrRef<GamePhysicsEntityData>) p_Value;
					break;

				case 2796412757:
					MeshEntityType = (CtrRef<EntityData>) p_Value;
					break;

				case 536540879:
					InstanceCount = (uint) p_Value;
					break;

				case 4181756587:
					HealthStateEntityManagerId = (uint) p_Value;
					break;

				case 357063654:
					PhysicsPartRange = (IndexRange) p_Value;
					break;

				case 2036496020:
					PhysicsPartCountPerInstance = (uint) p_Value;
					break;

				case 1216708329:
					NetworkIdRange = (IndexRange) p_Value;
					break;

				case 3896998395:
					NetworkIdCountPerInstance = (uint) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3878849363:
					return InstanceTransforms;

				case 555924372:
					return InstanceScale;

				case 2895987976:
					return InstanceObjectVariation;

				case 621670215:
					return InstanceCastSunShadow;

				case 2244878317:
					return MemberType;

				case 2796412757:
					return MeshEntityType;

				case 536540879:
					return InstanceCount;

				case 4181756587:
					return HealthStateEntityManagerId;

				case 357063654:
					return PhysicsPartRange;

				case 2036496020:
					return PhysicsPartCountPerInstance;

				case 1216708329:
					return NetworkIdRange;

				case 3896998395:
					return NetworkIdCountPerInstance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3878849363:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(InstanceTransforms));

				case 555924372:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(InstanceScale));

				case 2895987976:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(InstanceObjectVariation));

				case 621670215:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(InstanceCastSunShadow));

				case 2244878317:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(MemberType));

				case 2796412757:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(MeshEntityType));

				case 536540879:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(InstanceCount));

				case 4181756587:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(HealthStateEntityManagerId));

				case 357063654:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(PhysicsPartRange));

				case 2036496020:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(PhysicsPartCountPerInstance));

				case 1216708329:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(NetworkIdRange));

				case 3896998395:
					return typeof(StaticModelGroupMemberData).GetProperty(nameof(NetworkIdCountPerInstance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
