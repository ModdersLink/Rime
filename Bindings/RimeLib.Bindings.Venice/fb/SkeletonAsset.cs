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
	public class SkeletonAsset : 
		BaseSkeletonAsset
	{
		[ContainerField(12)]
		public List<string> BoneNames { get; set; } = new List<string>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<int> Hierarchy { get; set; } = new List<int>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<LinearTransform> LocalPose { get; set; } = new List<LinearTransform>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<LinearTransform> ModelPose { get; set; } = new List<LinearTransform>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string WeaponBoneName { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string HeadBoneName { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string HipBoneName { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string CameraBoneName { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 951771351:
					BoneNames = (List<string>) p_Value;
					break;

				case 2981249554:
					Hierarchy = (List<int>) p_Value;
					break;

				case 773169313:
					LocalPose = (List<LinearTransform>) p_Value;
					break;

				case 4243999587:
					ModelPose = (List<LinearTransform>) p_Value;
					break;

				case 4180015014:
					WeaponBoneName = (string) p_Value;
					break;

				case 3359050476:
					HeadBoneName = (string) p_Value;
					break;

				case 3967379317:
					HipBoneName = (string) p_Value;
					break;

				case 771838749:
					CameraBoneName = (string) p_Value;
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
				case 951771351:
					return BoneNames;

				case 2981249554:
					return Hierarchy;

				case 773169313:
					return LocalPose;

				case 4243999587:
					return ModelPose;

				case 4180015014:
					return WeaponBoneName;

				case 3359050476:
					return HeadBoneName;

				case 3967379317:
					return HipBoneName;

				case 771838749:
					return CameraBoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 951771351:
					return typeof(SkeletonAsset).GetProperty(nameof(BoneNames));

				case 2981249554:
					return typeof(SkeletonAsset).GetProperty(nameof(Hierarchy));

				case 773169313:
					return typeof(SkeletonAsset).GetProperty(nameof(LocalPose));

				case 4243999587:
					return typeof(SkeletonAsset).GetProperty(nameof(ModelPose));

				case 4180015014:
					return typeof(SkeletonAsset).GetProperty(nameof(WeaponBoneName));

				case 3359050476:
					return typeof(SkeletonAsset).GetProperty(nameof(HeadBoneName));

				case 3967379317:
					return typeof(SkeletonAsset).GetProperty(nameof(HipBoneName));

				case 771838749:
					return typeof(SkeletonAsset).GetProperty(nameof(CameraBoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
