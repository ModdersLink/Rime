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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class CollisionData : 
		DataContainer
	{
		protected List<ValueAtX> m_DamageAtVerticalVelocity = new List<ValueAtX>();
		[ContainerField(Name: "DamageAtVerticalVelocity", Offset: 8, NameHash: 670681886, Flags: 65)]
		public List<ValueAtX> DamageAtVerticalVelocity { get { return m_DamageAtVerticalVelocity; } set { if (OnPropertyChanging("CollisionData." + nameof(DamageAtVerticalVelocity), this, m_DamageAtVerticalVelocity, value)) m_DamageAtVerticalVelocity = value; } } // 0x8 (8)
		
		protected List<ValueAtX> m_DamageAtHorizVelocity = new List<ValueAtX>();
		[ContainerField(Name: "DamageAtHorizVelocity", Offset: 12, NameHash: 3966259722, Flags: 65)]
		public List<ValueAtX> DamageAtHorizVelocity { get { return m_DamageAtHorizVelocity; } set { if (OnPropertyChanging("CollisionData." + nameof(DamageAtHorizVelocity), this, m_DamageAtHorizVelocity, value)) m_DamageAtHorizVelocity = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 670681886:
					DamageAtVerticalVelocity = (List<ValueAtX>) p_Value;
					break;

				case 3966259722:
					DamageAtHorizVelocity = (List<ValueAtX>) p_Value;
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
				case 670681886:
					return DamageAtVerticalVelocity;

				case 3966259722:
					return DamageAtHorizVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 670681886:
					return typeof(CollisionData).GetProperty(nameof(DamageAtVerticalVelocity));

				case 3966259722:
					return typeof(CollisionData).GetProperty(nameof(DamageAtHorizVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
