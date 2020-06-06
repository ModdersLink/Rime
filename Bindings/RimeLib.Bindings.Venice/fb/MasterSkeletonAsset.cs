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
	public class MasterSkeletonAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SkeletonAsset> MasterSkeleton { get; set; } = new CtrRef<SkeletonAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<SubSkeleton> SubSkeletons { get; set; } = new List<SubSkeleton>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1934150648:
					MasterSkeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 2966147091:
					SubSkeletons = (List<SubSkeleton>) p_Value;
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
				case 1934150648:
					return MasterSkeleton;

				case 2966147091:
					return SubSkeletons;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1934150648:
					return typeof(MasterSkeletonAsset).GetProperty(nameof(MasterSkeleton));

				case 2966147091:
					return typeof(MasterSkeletonAsset).GetProperty(nameof(SubSkeletons));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
