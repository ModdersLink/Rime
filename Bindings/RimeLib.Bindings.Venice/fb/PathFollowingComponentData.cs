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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class PathFollowingComponentData : 
		ComponentData
	{
		protected float m_UpdatePathAtDistancePercent = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(324611860)]
		public float UpdatePathAtDistancePercent { get { return m_UpdatePathAtDistancePercent; } set { if (OnPropertyChanging("PathFollowingComponentData." + nameof(UpdatePathAtDistancePercent), this, m_UpdatePathAtDistancePercent, value)) m_UpdatePathAtDistancePercent = value; } } // 0x60 (96)
		
		protected uint m_PreferredPathfindingIndex = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(233434614)]
		public uint PreferredPathfindingIndex { get { return m_PreferredPathfindingIndex; } set { if (OnPropertyChanging("PathFollowingComponentData." + nameof(PreferredPathfindingIndex), this, m_PreferredPathfindingIndex, value)) m_PreferredPathfindingIndex = value; } } // 0x64 (100)
		
		protected List<uint> m_AlternatePathfindingIndices = new List<uint>();
		[ContainerField(104), MemberInfoFlag(65), ContainerFieldNameHash(1978090370), ContainerArray]
		public List<uint> AlternatePathfindingIndices { get { return m_AlternatePathfindingIndices; } set { if (OnPropertyChanging("PathFollowingComponentData." + nameof(AlternatePathfindingIndices), this, m_AlternatePathfindingIndices, value)) m_AlternatePathfindingIndices = value; } } // 0x68 (104)
		
		protected float m_MovementCorridorRadius = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1392343010)]
		public float MovementCorridorRadius { get { return m_MovementCorridorRadius; } set { if (OnPropertyChanging("PathFollowingComponentData." + nameof(MovementCorridorRadius), this, m_MovementCorridorRadius, value)) m_MovementCorridorRadius = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 324611860:
					UpdatePathAtDistancePercent = (float) p_Value;
					break;

				case 233434614:
					PreferredPathfindingIndex = (uint) p_Value;
					break;

				case 1978090370:
					AlternatePathfindingIndices = (List<uint>) p_Value;
					break;

				case 1392343010:
					MovementCorridorRadius = (float) p_Value;
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
				case 324611860:
					return UpdatePathAtDistancePercent;

				case 233434614:
					return PreferredPathfindingIndex;

				case 1978090370:
					return AlternatePathfindingIndices;

				case 1392343010:
					return MovementCorridorRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 324611860:
					return typeof(PathFollowingComponentData).GetProperty(nameof(UpdatePathAtDistancePercent));

				case 233434614:
					return typeof(PathFollowingComponentData).GetProperty(nameof(PreferredPathfindingIndex));

				case 1978090370:
					return typeof(PathFollowingComponentData).GetProperty(nameof(AlternatePathfindingIndices));

				case 1392343010:
					return typeof(PathFollowingComponentData).GetProperty(nameof(MovementCorridorRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
