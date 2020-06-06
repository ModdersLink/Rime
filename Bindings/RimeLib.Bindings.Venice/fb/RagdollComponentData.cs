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
	public class RagdollComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new CtrRef<SkeletonAsset>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<RagdollAsset> RagdollAsset { get; set; } = new CtrRef<RagdollAsset>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get; set; } = new CtrRef<SkeletonCollisionData>(); // 0x68 (104)
		
		[ContainerField(108)]
		public RagdollBinding Binding { get; set; } = new RagdollBinding(); // 0x6C (108)
		
		[ContainerField(128), LayoutImmutable]
		public string LeftLegBoneName { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable]
		public string RightLegBoneName { get; set; } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2375870068:
					SkeletonAsset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 4111789834:
					RagdollAsset = (CtrRef<RagdollAsset>) p_Value;
					break;

				case 2418871594:
					SkeletonCollisionData = (CtrRef<SkeletonCollisionData>) p_Value;
					break;

				case 2590060228:
					Binding = (RagdollBinding) p_Value;
					break;

				case 718235633:
					LeftLegBoneName = (string) p_Value;
					break;

				case 3038502186:
					RightLegBoneName = (string) p_Value;
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
				case 2375870068:
					return SkeletonAsset;

				case 4111789834:
					return RagdollAsset;

				case 2418871594:
					return SkeletonCollisionData;

				case 2590060228:
					return Binding;

				case 718235633:
					return LeftLegBoneName;

				case 3038502186:
					return RightLegBoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return typeof(RagdollComponentData).GetProperty(nameof(SkeletonAsset));

				case 4111789834:
					return typeof(RagdollComponentData).GetProperty(nameof(RagdollAsset));

				case 2418871594:
					return typeof(RagdollComponentData).GetProperty(nameof(SkeletonCollisionData));

				case 2590060228:
					return typeof(RagdollComponentData).GetProperty(nameof(Binding));

				case 718235633:
					return typeof(RagdollComponentData).GetProperty(nameof(LeftLegBoneName));

				case 3038502186:
					return typeof(RagdollComponentData).GetProperty(nameof(RightLegBoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
