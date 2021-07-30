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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class MeshComponentData : 
		ComponentData
	{
		protected RefArray<BoneFakePhysicsData> m_BoneFakePhysics = new RefArray<BoneFakePhysicsData>();
		[ContainerField(Name: "BoneFakePhysics", Offset: 96, NameHash: 2227758113, Flags: 65)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get { return m_BoneFakePhysics; } set { if (OnPropertyChanging("MeshComponentData." + nameof(BoneFakePhysics), this, m_BoneFakePhysics, value)) m_BoneFakePhysics = value; } } // 0x60 (96)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 100, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("MeshComponentData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x64 (100)
		
		protected CtrRef<SkeletonAsset> m_Skeleton = new CtrRef<SkeletonAsset>();
		[ContainerField(Name: "Skeleton", Offset: 104, NameHash: 291024164, Flags: 53)]
		public CtrRef<SkeletonAsset> Skeleton { get { return m_Skeleton; } set { if (OnPropertyChanging("MeshComponentData." + nameof(Skeleton), this, m_Skeleton, value)) m_Skeleton = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2227758113:
					BoneFakePhysics = (RefArray<BoneFakePhysicsData>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 291024164:
					Skeleton = (CtrRef<SkeletonAsset>) p_Value;
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
				case 2227758113:
					return BoneFakePhysics;

				case 2088783990:
					return Mesh;

				case 291024164:
					return Skeleton;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2227758113:
					return typeof(MeshComponentData).GetProperty(nameof(BoneFakePhysics));

				case 2088783990:
					return typeof(MeshComponentData).GetProperty(nameof(Mesh));

				case 291024164:
					return typeof(MeshComponentData).GetProperty(nameof(Skeleton));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
