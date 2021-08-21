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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class MaterialPropertyHealthData : 
		PhysicsPropertyRelationPropertyData
	{
		protected float m_Health = new float();
		[ContainerField(Name: "Health", Offset: 8, NameHash: 3054337113, Flags: 49469), LayoutImmutable, Blittable]
		public float Health { get { return m_Health; } set { if (OnPropertyChanging("MaterialPropertyHealthData." + nameof(Health), this, m_Health, value)) m_Health = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054337113:
					Health = (float) p_Value;
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
				case 3054337113:
					return Health;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054337113:
					return typeof(MaterialPropertyHealthData).GetProperty(nameof(Health));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
