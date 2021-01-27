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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class SubSkeleton : FrostbiteContainer
	{
		[ContainerField(Name: "Skeleton", Offset: 0, NameHash: 291024164, Flags: 53)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "BoneMap", Offset: 4, NameHash: 2521060607, Flags: 65)]
		public List<int> BoneMap { get; set; } = new List<int>(); // 0x4 (4)
		
		[ContainerField(Name: "TransformMap", Offset: 8, NameHash: 1281121973, Flags: 65)]
		public List<LinearTransform> TransformMap { get; set; } = new List<LinearTransform>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 291024164:
					Skeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 2521060607:
					BoneMap = (List<int>) p_Value;
					break;

				case 1281121973:
					TransformMap = (List<LinearTransform>) p_Value;
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
				case 291024164:
					return Skeleton;

				case 2521060607:
					return BoneMap;

				case 1281121973:
					return TransformMap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 291024164:
					return typeof(SubSkeleton).GetProperty(nameof(Skeleton));

				case 2521060607:
					return typeof(SubSkeleton).GetProperty(nameof(BoneMap));

				case 1281121973:
					return typeof(SubSkeleton).GetProperty(nameof(TransformMap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
