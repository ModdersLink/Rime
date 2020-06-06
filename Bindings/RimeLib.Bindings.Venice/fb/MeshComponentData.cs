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
	public class MeshComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RefArray<BoneFakePhysicsData> BoneFakePhysics { get; set; } = new RefArray<BoneFakePhysicsData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0x68 (104)
		
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
