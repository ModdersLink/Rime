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
	public class AIAimingConstraintsData : 
		DataContainer
	{
		protected float m_MinYaw = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2633709248)]
		public float MinYaw { get { return m_MinYaw; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MinYaw), this, m_MinYaw, value)) m_MinYaw = value; } } // 0x8 (8)
		
		protected float m_MaxYaw = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2642824094)]
		public float MaxYaw { get { return m_MaxYaw; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MaxYaw), this, m_MaxYaw, value)) m_MaxYaw = value; } } // 0xC (12)
		
		protected float m_MinPitch = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3374061353)]
		public float MinPitch { get { return m_MinPitch; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MinPitch), this, m_MinPitch, value)) m_MinPitch = value; } } // 0x10 (16)
		
		protected float m_MaxPitch = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(397101687)]
		public float MaxPitch { get { return m_MaxPitch; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MaxPitch), this, m_MaxPitch, value)) m_MaxPitch = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2633709248:
					MinYaw = (float) p_Value;
					break;

				case 2642824094:
					MaxYaw = (float) p_Value;
					break;

				case 3374061353:
					MinPitch = (float) p_Value;
					break;

				case 397101687:
					MaxPitch = (float) p_Value;
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
				case 2633709248:
					return MinYaw;

				case 2642824094:
					return MaxYaw;

				case 3374061353:
					return MinPitch;

				case 397101687:
					return MaxPitch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2633709248:
					return typeof(AIAimingConstraintsData).GetProperty(nameof(MinYaw));

				case 2642824094:
					return typeof(AIAimingConstraintsData).GetProperty(nameof(MaxYaw));

				case 3374061353:
					return typeof(AIAimingConstraintsData).GetProperty(nameof(MinPitch));

				case 397101687:
					return typeof(AIAimingConstraintsData).GetProperty(nameof(MaxPitch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
