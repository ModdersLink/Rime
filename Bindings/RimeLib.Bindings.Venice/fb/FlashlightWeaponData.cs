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
	public class FlashlightWeaponData : 
		WeaponData
	{
		protected float m_UpdateFrequency = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(219717232)]
		public float UpdateFrequency { get { return m_UpdateFrequency; } set { if (OnPropertyChanging("FlashlightWeaponData." + nameof(UpdateFrequency), this, m_UpdateFrequency, value)) m_UpdateFrequency = value; } } // 0x10 (16)
		
		protected float m_Range = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(230112826)]
		public float Range { get { return m_Range; } set { if (OnPropertyChanging("FlashlightWeaponData." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x14 (20)
		
		protected float m_Angle = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(205597860)]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("FlashlightWeaponData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 219717232:
					UpdateFrequency = (float) p_Value;
					break;

				case 230112826:
					Range = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
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
				case 219717232:
					return UpdateFrequency;

				case 230112826:
					return Range;

				case 205597860:
					return Angle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 219717232:
					return typeof(FlashlightWeaponData).GetProperty(nameof(UpdateFrequency));

				case 230112826:
					return typeof(FlashlightWeaponData).GetProperty(nameof(Range));

				case 205597860:
					return typeof(FlashlightWeaponData).GetProperty(nameof(Angle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
