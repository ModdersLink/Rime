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
	public class MaterialRelationPenetrationData : 
		PhysicsPropertyRelationPropertyData
	{
		protected bool m_NeverPenetrate = new bool();
		[ContainerField(Name: "NeverPenetrate", Offset: 8, NameHash: 2064798663, Flags: 49325), LayoutImmutable, Blittable]
		public bool NeverPenetrate { get { return m_NeverPenetrate; } set { if (OnPropertyChanging("MaterialRelationPenetrationData." + nameof(NeverPenetrate), this, m_NeverPenetrate, value)) m_NeverPenetrate = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2064798663:
					NeverPenetrate = (bool) p_Value;
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
				case 2064798663:
					return NeverPenetrate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2064798663:
					return typeof(MaterialRelationPenetrationData).GetProperty(nameof(NeverPenetrate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
