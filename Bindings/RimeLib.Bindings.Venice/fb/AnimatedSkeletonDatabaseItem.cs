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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class AnimatedSkeletonDatabaseItem : FrostbiteContainer
	{
		[ContainerField(Name: "Asset", Offset: 0, NameHash: 205976053, Flags: 53)]
		public CtrRef<SkeletonAsset> Asset { get; set; } = new CtrRef<SkeletonAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "Names", Offset: 4, NameHash: 215869617, Flags: 65)]
		public List<int> Names { get; set; } = new List<int>(); // 0x4 (4)
		
		[ContainerField(Name: "SoldierCollision", Offset: 8, NameHash: 3880482801, Flags: 53)]
		public CtrRef<SkeletonCollisionData> SoldierCollision { get; set; } = new CtrRef<SkeletonCollisionData>(); // 0x8 (8)
		
		[ContainerField(Name: "RagdollCollision", Offset: 12, NameHash: 1384663972, Flags: 53)]
		public CtrRef<SkeletonCollisionData> RagdollCollision { get; set; } = new CtrRef<SkeletonCollisionData>(); // 0xC (12)
		
		[ContainerField(Name: "Ragdoll", Offset: 16, NameHash: 1473995034, Flags: 53)]
		public CtrRef<RagdollAsset> Ragdoll { get; set; } = new CtrRef<RagdollAsset>(); // 0x10 (16)
		
		[ContainerField(Name: "SpecialBones", Offset: 20, NameHash: 872557553, Flags: 65)]
		public List<string> SpecialBones { get; set; } = new List<string>(); // 0x14 (20)
		
		[ContainerField(Name: "HipBone", Offset: 24, NameHash: 1871690802, Flags: 16509), LayoutImmutable]
		public string HipBone { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "HeadBone", Offset: 28, NameHash: 1878748843, Flags: 16509), LayoutImmutable]
		public string HeadBone { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205976053:
					Asset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 215869617:
					Names = (List<int>) p_Value;
					break;

				case 3880482801:
					SoldierCollision = (CtrRef<SkeletonCollisionData>) p_Value;
					break;

				case 1384663972:
					RagdollCollision = (CtrRef<SkeletonCollisionData>) p_Value;
					break;

				case 1473995034:
					Ragdoll = (CtrRef<RagdollAsset>) p_Value;
					break;

				case 872557553:
					SpecialBones = (List<string>) p_Value;
					break;

				case 1871690802:
					HipBone = (string) p_Value;
					break;

				case 1878748843:
					HeadBone = (string) p_Value;
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
				case 205976053:
					return Asset;

				case 215869617:
					return Names;

				case 3880482801:
					return SoldierCollision;

				case 1384663972:
					return RagdollCollision;

				case 1473995034:
					return Ragdoll;

				case 872557553:
					return SpecialBones;

				case 1871690802:
					return HipBone;

				case 1878748843:
					return HeadBone;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205976053:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(Asset));

				case 215869617:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(Names));

				case 3880482801:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(SoldierCollision));

				case 1384663972:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(RagdollCollision));

				case 1473995034:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(Ragdoll));

				case 872557553:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(SpecialBones));

				case 1871690802:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(HipBone));

				case 1878748843:
					return typeof(AnimatedSkeletonDatabaseItem).GetProperty(nameof(HeadBone));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
