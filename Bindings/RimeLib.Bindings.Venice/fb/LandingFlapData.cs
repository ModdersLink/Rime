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
	public class LandingFlapData : 
		DataContainer
	{
		protected float m_ActivationHeight = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2266632686)]
		public float ActivationHeight { get { return m_ActivationHeight; } set { if (OnPropertyChanging("LandingFlapData." + nameof(ActivationHeight), this, m_ActivationHeight, value)) m_ActivationHeight = value; } } // 0x8 (8)
		
		protected float m_HeightTolerance = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(593358163)]
		public float HeightTolerance { get { return m_HeightTolerance; } set { if (OnPropertyChanging("LandingFlapData." + nameof(HeightTolerance), this, m_HeightTolerance, value)) m_HeightTolerance = value; } } // 0xC (12)
		
		protected float m_ActivationVelocity = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1432155942)]
		public float ActivationVelocity { get { return m_ActivationVelocity; } set { if (OnPropertyChanging("LandingFlapData." + nameof(ActivationVelocity), this, m_ActivationVelocity, value)) m_ActivationVelocity = value; } } // 0x10 (16)
		
		protected float m_VelocityTolerance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(43464475)]
		public float VelocityTolerance { get { return m_VelocityTolerance; } set { if (OnPropertyChanging("LandingFlapData." + nameof(VelocityTolerance), this, m_VelocityTolerance, value)) m_VelocityTolerance = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2266632686:
					ActivationHeight = (float) p_Value;
					break;

				case 593358163:
					HeightTolerance = (float) p_Value;
					break;

				case 1432155942:
					ActivationVelocity = (float) p_Value;
					break;

				case 43464475:
					VelocityTolerance = (float) p_Value;
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
				case 2266632686:
					return ActivationHeight;

				case 593358163:
					return HeightTolerance;

				case 1432155942:
					return ActivationVelocity;

				case 43464475:
					return VelocityTolerance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2266632686:
					return typeof(LandingFlapData).GetProperty(nameof(ActivationHeight));

				case 593358163:
					return typeof(LandingFlapData).GetProperty(nameof(HeightTolerance));

				case 1432155942:
					return typeof(LandingFlapData).GetProperty(nameof(ActivationVelocity));

				case 43464475:
					return typeof(LandingFlapData).GetProperty(nameof(VelocityTolerance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
