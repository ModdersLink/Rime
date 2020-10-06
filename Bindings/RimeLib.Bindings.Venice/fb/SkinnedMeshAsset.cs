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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(80), ContainerClass]
	public class SkinnedMeshAsset : 
		MeshAsset
	{
		protected Vec3 m_BoundingBoxPositionOffset = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2563040854)]
		public Vec3 BoundingBoxPositionOffset { get { return m_BoundingBoxPositionOffset; } set { if (OnPropertyChanging("SkinnedMeshAsset." + nameof(BoundingBoxPositionOffset), this, m_BoundingBoxPositionOffset, value)) m_BoundingBoxPositionOffset = value; } } // 0x30 (48)
		
		protected Vec3 m_BoundingBoxSizeOffset = new Vec3();
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2946347242)]
		public Vec3 BoundingBoxSizeOffset { get { return m_BoundingBoxSizeOffset; } set { if (OnPropertyChanging("SkinnedMeshAsset." + nameof(BoundingBoxSizeOffset), this, m_BoundingBoxSizeOffset, value)) m_BoundingBoxSizeOffset = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2563040854:
					BoundingBoxPositionOffset = (Vec3) p_Value;
					break;

				case 2946347242:
					BoundingBoxSizeOffset = (Vec3) p_Value;
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
				case 2563040854:
					return BoundingBoxPositionOffset;

				case 2946347242:
					return BoundingBoxSizeOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2563040854:
					return typeof(SkinnedMeshAsset).GetProperty(nameof(BoundingBoxPositionOffset));

				case 2946347242:
					return typeof(SkinnedMeshAsset).GetProperty(nameof(BoundingBoxSizeOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
