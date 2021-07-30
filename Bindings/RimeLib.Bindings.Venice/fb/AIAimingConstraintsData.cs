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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class AIAimingConstraintsData : 
		DataContainer
	{
		protected float m_MinYaw = new float();
		[ContainerField(Name: "MinYaw", Offset: 8, NameHash: 2633709248, Flags: 49469), LayoutImmutable, Blittable]
		public float MinYaw { get { return m_MinYaw; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MinYaw), this, m_MinYaw, value)) m_MinYaw = value; } } // 0x8 (8)
		
		protected float m_MaxYaw = new float();
		[ContainerField(Name: "MaxYaw", Offset: 12, NameHash: 2642824094, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxYaw { get { return m_MaxYaw; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MaxYaw), this, m_MaxYaw, value)) m_MaxYaw = value; } } // 0xC (12)
		
		protected float m_MinPitch = new float();
		[ContainerField(Name: "MinPitch", Offset: 16, NameHash: 3374061353, Flags: 49469), LayoutImmutable, Blittable]
		public float MinPitch { get { return m_MinPitch; } set { if (OnPropertyChanging("AIAimingConstraintsData." + nameof(MinPitch), this, m_MinPitch, value)) m_MinPitch = value; } } // 0x10 (16)
		
		protected float m_MaxPitch = new float();
		[ContainerField(Name: "MaxPitch", Offset: 20, NameHash: 397101687, Flags: 49469), LayoutImmutable, Blittable]
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
