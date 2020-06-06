///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AntAnimationSetAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new CtrRef<SkeletonAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int ActorAssetIndex { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public List<int> ClipAssetIndices { get; set; } = new List<int>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<int> LoopingClipAssetIndices { get; set; } = new List<int>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int SceneOpMatrixAssetIndex { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseTraj2Ref { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool AllowAnimationCulling { get; set; } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2375870068:
					SkeletonAsset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 1719210944:
					ActorAssetIndex = (int) p_Value;
					break;

				case 3918246524:
					ClipAssetIndices = (List<int>) p_Value;
					break;

				case 346444768:
					LoopingClipAssetIndices = (List<int>) p_Value;
					break;

				case 1085428945:
					SceneOpMatrixAssetIndex = (int) p_Value;
					break;

				case 880398792:
					UseTraj2Ref = (bool) p_Value;
					break;

				case 524938044:
					AllowAnimationCulling = (bool) p_Value;
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

				case 1719210944:
					return ActorAssetIndex;

				case 3918246524:
					return ClipAssetIndices;

				case 346444768:
					return LoopingClipAssetIndices;

				case 1085428945:
					return SceneOpMatrixAssetIndex;

				case 880398792:
					return UseTraj2Ref;

				case 524938044:
					return AllowAnimationCulling;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(SkeletonAsset));

				case 1719210944:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(ActorAssetIndex));

				case 3918246524:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(ClipAssetIndices));

				case 346444768:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(LoopingClipAssetIndices));

				case 1085428945:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(SceneOpMatrixAssetIndex));

				case 880398792:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(UseTraj2Ref));

				case 524938044:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(AllowAnimationCulling));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
