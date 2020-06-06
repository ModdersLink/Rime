///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SearchAndDestroyOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public TargetPosKnowledgeType TargetPosKnowledge { get; set; } = new TargetPosKnowledgeType(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float FindTargetTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool TargetAreaFollowsTarget { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool Aggressive { get; set; } // 0x31 (49)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230186890:
					TargetPosKnowledge = (TargetPosKnowledgeType) Enum.ToObject(typeof(TargetPosKnowledgeType), p_Value);
					break;

				case 3667793764:
					FindTargetTime = (float) p_Value;
					break;

				case 3741825168:
					TargetAreaFollowsTarget = (bool) p_Value;
					break;

				case 4037886889:
					Aggressive = (bool) p_Value;
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
				case 230186890:
					return TargetPosKnowledge;

				case 3667793764:
					return FindTargetTime;

				case 3741825168:
					return TargetAreaFollowsTarget;

				case 4037886889:
					return Aggressive;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230186890:
					return typeof(SearchAndDestroyOrderEntityData).GetProperty(nameof(TargetPosKnowledge));

				case 3667793764:
					return typeof(SearchAndDestroyOrderEntityData).GetProperty(nameof(FindTargetTime));

				case 3741825168:
					return typeof(SearchAndDestroyOrderEntityData).GetProperty(nameof(TargetAreaFollowsTarget));

				case 4037886889:
					return typeof(SearchAndDestroyOrderEntityData).GetProperty(nameof(Aggressive));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
