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
	public class RadiosityMaterial : 
		DataContainer
	{
		protected Vec3 m_Color = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(212387320)]
		public Vec3 Color { get { return m_Color; } set { if (OnPropertyChanging("RadiosityMaterial." + nameof(Color), this, m_Color, value)) m_Color = value; } } // 0x10 (16)
		
		protected string m_Name = string.Empty;
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("RadiosityMaterial." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x20 (32)
		
		protected bool m_Emissive = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(782359646)]
		public bool Emissive { get { return m_Emissive; } set { if (OnPropertyChanging("RadiosityMaterial." + nameof(Emissive), this, m_Emissive, value)) m_Emissive = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212387320:
					Color = (Vec3) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 782359646:
					Emissive = (bool) p_Value;
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
				case 212387320:
					return Color;

				case 2088949890:
					return Name;

				case 782359646:
					return Emissive;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212387320:
					return typeof(RadiosityMaterial).GetProperty(nameof(Color));

				case 2088949890:
					return typeof(RadiosityMaterial).GetProperty(nameof(Name));

				case 782359646:
					return typeof(RadiosityMaterial).GetProperty(nameof(Emissive));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
