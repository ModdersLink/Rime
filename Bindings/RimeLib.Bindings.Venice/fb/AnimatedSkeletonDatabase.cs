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
	public class AnimatedSkeletonDatabase : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<RagdollAsset> Ragdolls { get; set; } = new RefArray<RagdollAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<AnimatedSkeletonDatabaseItem> Items { get; set; } = new List<AnimatedSkeletonDatabaseItem>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1397195817:
					Ragdolls = (RefArray<RagdollAsset>) p_Value;
					break;

				case 215446531:
					Items = (List<AnimatedSkeletonDatabaseItem>) p_Value;
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
				case 1397195817:
					return Ragdolls;

				case 215446531:
					return Items;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1397195817:
					return typeof(AnimatedSkeletonDatabase).GetProperty(nameof(Ragdolls));

				case 215446531:
					return typeof(AnimatedSkeletonDatabase).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
