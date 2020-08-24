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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class GameObjectData : 
		GameDataContainer
	{
		protected ushort m_IndexInBlueprint = new ushort();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49389), ContainerFieldNameHash(1440948467)]
		public ushort IndexInBlueprint { get { return m_IndexInBlueprint; } set { if (OnPropertyChanging("GameObjectData." + nameof(IndexInBlueprint), this, m_IndexInBlueprint, value)) m_IndexInBlueprint = value; } } // 0x8 (8)
		
		protected sbyte m_IsEventConnectionTarget = new sbyte();
		[ContainerField(10), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(443195188)]
		public sbyte IsEventConnectionTarget { get { return m_IsEventConnectionTarget; } set { if (OnPropertyChanging("GameObjectData." + nameof(IsEventConnectionTarget), this, m_IsEventConnectionTarget, value)) m_IsEventConnectionTarget = value; } } // 0xA (10)
		
		protected sbyte m_IsPropertyConnectionTarget = new sbyte();
		[ContainerField(11), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3243963839)]
		public sbyte IsPropertyConnectionTarget { get { return m_IsPropertyConnectionTarget; } set { if (OnPropertyChanging("GameObjectData." + nameof(IsPropertyConnectionTarget), this, m_IsPropertyConnectionTarget, value)) m_IsPropertyConnectionTarget = value; } } // 0xB (11)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1440948467:
					IndexInBlueprint = (ushort) p_Value;
					break;

				case 443195188:
					IsEventConnectionTarget = (sbyte) p_Value;
					break;

				case 3243963839:
					IsPropertyConnectionTarget = (sbyte) p_Value;
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
				case 1440948467:
					return IndexInBlueprint;

				case 443195188:
					return IsEventConnectionTarget;

				case 3243963839:
					return IsPropertyConnectionTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1440948467:
					return typeof(GameObjectData).GetProperty(nameof(IndexInBlueprint));

				case 443195188:
					return typeof(GameObjectData).GetProperty(nameof(IsEventConnectionTarget));

				case 3243963839:
					return typeof(GameObjectData).GetProperty(nameof(IsPropertyConnectionTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
