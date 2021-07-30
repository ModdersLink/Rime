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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class AnimatedSkeletonDatabase : 
		DataContainer
	{
		protected RefArray<RagdollAsset> m_Ragdolls = new RefArray<RagdollAsset>();
		[ContainerField(Name: "Ragdolls", Offset: 8, NameHash: 1397195817, Flags: 65)]
		public RefArray<RagdollAsset> Ragdolls { get { return m_Ragdolls; } set { if (OnPropertyChanging("AnimatedSkeletonDatabase." + nameof(Ragdolls), this, m_Ragdolls, value)) m_Ragdolls = value; } } // 0x8 (8)
		
		protected List<AnimatedSkeletonDatabaseItem> m_Items = new List<AnimatedSkeletonDatabaseItem>();
		[ContainerField(Name: "Items", Offset: 12, NameHash: 215446531, Flags: 65)]
		public List<AnimatedSkeletonDatabaseItem> Items { get { return m_Items; } set { if (OnPropertyChanging("AnimatedSkeletonDatabase." + nameof(Items), this, m_Items, value)) m_Items = value; } } // 0xC (12)
		
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
