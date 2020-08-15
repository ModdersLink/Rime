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
	[ContainerType(16)]
	public class ComponentData : 
		GameObjectData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2270319721)]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("ComponentData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x10 (16)
		
		protected RefArray<GameObjectData> m_Components = new RefArray<GameObjectData>();
		[ContainerField(80), ContainerFieldNameHash(3391050425)]
		public RefArray<GameObjectData> Components { get { return m_Components; } set { if (OnPropertyChanging("ComponentData." + nameof(Components), this, m_Components, value)) m_Components = value; } } // 0x50 (80)
		
		protected bool m_Excluded = new bool();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(755715367)]
		public bool Excluded { get { return m_Excluded; } set { if (OnPropertyChanging("ComponentData." + nameof(Excluded), this, m_Excluded, value)) m_Excluded = value; } } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 755715367:
					Excluded = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 3391050425:
					return Components;

				case 755715367:
					return Excluded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(ComponentData).GetProperty(nameof(Transform));

				case 3391050425:
					return typeof(ComponentData).GetProperty(nameof(Components));

				case 755715367:
					return typeof(ComponentData).GetProperty(nameof(Excluded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
