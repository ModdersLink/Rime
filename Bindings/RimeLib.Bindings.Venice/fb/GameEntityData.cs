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
	public class GameEntityData : 
		SpatialEntityData
	{
		protected RefArray<GameObjectData> m_Components = new RefArray<GameObjectData>();
		[ContainerField(80), MemberInfoFlag(65), ContainerFieldNameHash(3391050425), ContainerRefArray]
		public RefArray<GameObjectData> Components { get { return m_Components; } set { if (OnPropertyChanging("GameEntityData." + nameof(Components), this, m_Components, value)) m_Components = value; } } // 0x50 (80)
		
		protected bool m_Enabled = new bool();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("GameEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x54 (84)
		
		protected sbyte m_RuntimeComponentCount = new sbyte();
		[ContainerField(85), LayoutImmutable, Blittable, MemberInfoFlag(49341), ContainerFieldNameHash(3928419541)]
		public sbyte RuntimeComponentCount { get { return m_RuntimeComponentCount; } set { if (OnPropertyChanging("GameEntityData." + nameof(RuntimeComponentCount), this, m_RuntimeComponentCount, value)) m_RuntimeComponentCount = value; } } // 0x55 (85)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 3928419541:
					RuntimeComponentCount = (sbyte) p_Value;
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
				case 3391050425:
					return Components;

				case 2662400:
					return Enabled;

				case 3928419541:
					return RuntimeComponentCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3391050425:
					return typeof(GameEntityData).GetProperty(nameof(Components));

				case 2662400:
					return typeof(GameEntityData).GetProperty(nameof(Enabled));

				case 3928419541:
					return typeof(GameEntityData).GetProperty(nameof(RuntimeComponentCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
