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
	[ContainerType(4)]
	public class StabilizerData : 
		DataContainer
	{
		protected float m_PitchStrength = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(724430630)]
		public float PitchStrength { get { return m_PitchStrength; } set { if (OnPropertyChanging("StabilizerData." + nameof(PitchStrength), this, m_PitchStrength, value)) m_PitchStrength = value; } } // 0x8 (8)
		
		protected float m_RollStrength = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3312814269)]
		public float RollStrength { get { return m_RollStrength; } set { if (OnPropertyChanging("StabilizerData." + nameof(RollStrength), this, m_RollStrength, value)) m_RollStrength = value; } } // 0xC (12)
		
		protected float m_VerticalVelocityStrength = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3950176229)]
		public float VerticalVelocityStrength { get { return m_VerticalVelocityStrength; } set { if (OnPropertyChanging("StabilizerData." + nameof(VerticalVelocityStrength), this, m_VerticalVelocityStrength, value)) m_VerticalVelocityStrength = value; } } // 0x10 (16)
		
		protected float m_YawStrength = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2378860303)]
		public float YawStrength { get { return m_YawStrength; } set { if (OnPropertyChanging("StabilizerData." + nameof(YawStrength), this, m_YawStrength, value)) m_YawStrength = value; } } // 0x14 (20)
		
		protected bool m_AdvancedYaw = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2833028724)]
		public bool AdvancedYaw { get { return m_AdvancedYaw; } set { if (OnPropertyChanging("StabilizerData." + nameof(AdvancedYaw), this, m_AdvancedYaw, value)) m_AdvancedYaw = value; } } // 0x18 (24)
		
		protected bool m_Advanced = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, ContainerFieldNameHash(2748179067)]
		public bool Advanced { get { return m_Advanced; } set { if (OnPropertyChanging("StabilizerData." + nameof(Advanced), this, m_Advanced, value)) m_Advanced = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 724430630:
					PitchStrength = (float) p_Value;
					break;

				case 3312814269:
					RollStrength = (float) p_Value;
					break;

				case 3950176229:
					VerticalVelocityStrength = (float) p_Value;
					break;

				case 2378860303:
					YawStrength = (float) p_Value;
					break;

				case 2833028724:
					AdvancedYaw = (bool) p_Value;
					break;

				case 2748179067:
					Advanced = (bool) p_Value;
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
				case 724430630:
					return PitchStrength;

				case 3312814269:
					return RollStrength;

				case 3950176229:
					return VerticalVelocityStrength;

				case 2378860303:
					return YawStrength;

				case 2833028724:
					return AdvancedYaw;

				case 2748179067:
					return Advanced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 724430630:
					return typeof(StabilizerData).GetProperty(nameof(PitchStrength));

				case 3312814269:
					return typeof(StabilizerData).GetProperty(nameof(RollStrength));

				case 3950176229:
					return typeof(StabilizerData).GetProperty(nameof(VerticalVelocityStrength));

				case 2378860303:
					return typeof(StabilizerData).GetProperty(nameof(YawStrength));

				case 2833028724:
					return typeof(StabilizerData).GetProperty(nameof(AdvancedYaw));

				case 2748179067:
					return typeof(StabilizerData).GetProperty(nameof(Advanced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
