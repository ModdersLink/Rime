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
	[ContainerType(4)]
	public class SearchAndDestroyOrderEntityData : 
		BFOrderEntityData
	{
		protected TargetPosKnowledgeType m_TargetPosKnowledge = new TargetPosKnowledgeType();
		[ContainerField(40), ContainerFieldNameHash(230186890)]
		public TargetPosKnowledgeType TargetPosKnowledge { get { return m_TargetPosKnowledge; } set { if (OnPropertyChanging("SearchAndDestroyOrderEntityData." + nameof(TargetPosKnowledge), this, m_TargetPosKnowledge, value)) m_TargetPosKnowledge = value; } } // 0x28 (40)
		
		protected float m_FindTargetTime = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3667793764)]
		public float FindTargetTime { get { return m_FindTargetTime; } set { if (OnPropertyChanging("SearchAndDestroyOrderEntityData." + nameof(FindTargetTime), this, m_FindTargetTime, value)) m_FindTargetTime = value; } } // 0x2C (44)
		
		protected bool m_TargetAreaFollowsTarget = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3741825168)]
		public bool TargetAreaFollowsTarget { get { return m_TargetAreaFollowsTarget; } set { if (OnPropertyChanging("SearchAndDestroyOrderEntityData." + nameof(TargetAreaFollowsTarget), this, m_TargetAreaFollowsTarget, value)) m_TargetAreaFollowsTarget = value; } } // 0x30 (48)
		
		protected bool m_Aggressive = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, ContainerFieldNameHash(4037886889)]
		public bool Aggressive { get { return m_Aggressive; } set { if (OnPropertyChanging("SearchAndDestroyOrderEntityData." + nameof(Aggressive), this, m_Aggressive, value)) m_Aggressive = value; } } // 0x31 (49)
		
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
