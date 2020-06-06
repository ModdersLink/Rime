///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SkinnedMeshAsset : 
		MeshAsset
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxPositionOffset { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoundingBoxSizeOffset { get; set; } = new Vec3(); // 0x40 (64)
		
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
