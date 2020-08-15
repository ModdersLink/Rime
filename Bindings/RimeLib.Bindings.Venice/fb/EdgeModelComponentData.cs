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
	[ContainerType(16)]
	public class EdgeModelComponentData : 
		DestructionEdgeModelComponentData
	{
		protected RefArray<RigidMeshAsset> m_RigidMeshes = new RefArray<RigidMeshAsset>();
		[ContainerField(96), ContainerFieldNameHash(3208409265)]
		public RefArray<RigidMeshAsset> RigidMeshes { get { return m_RigidMeshes; } set { if (OnPropertyChanging("EdgeModelComponentData." + nameof(RigidMeshes), this, m_RigidMeshes, value)) m_RigidMeshes = value; } } // 0x60 (96)
		
		protected uint m_MaxInstanceCount = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3587631771)]
		public uint MaxInstanceCount { get { return m_MaxInstanceCount; } set { if (OnPropertyChanging("EdgeModelComponentData." + nameof(MaxInstanceCount), this, m_MaxInstanceCount, value)) m_MaxInstanceCount = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3208409265:
					RigidMeshes = (RefArray<RigidMeshAsset>) p_Value;
					break;

				case 3587631771:
					MaxInstanceCount = (uint) p_Value;
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
				case 3208409265:
					return RigidMeshes;

				case 3587631771:
					return MaxInstanceCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208409265:
					return typeof(EdgeModelComponentData).GetProperty(nameof(RigidMeshes));

				case 3587631771:
					return typeof(EdgeModelComponentData).GetProperty(nameof(MaxInstanceCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
