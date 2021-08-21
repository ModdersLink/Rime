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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class ExtendedConstraintsData : 
		DataContainer
	{
		protected float m_Heading = new float();
		[ContainerField(Name: "Heading", Offset: 8, NameHash: 2009143629, Flags: 49469), LayoutImmutable, Blittable]
		public float Heading { get { return m_Heading; } set { if (OnPropertyChanging("ExtendedConstraintsData." + nameof(Heading), this, m_Heading, value)) m_Heading = value; } } // 0x8 (8)
		
		protected float m_Width = new float();
		[ContainerField(Name: "Width", Offset: 12, NameHash: 226981187, Flags: 49469), LayoutImmutable, Blittable]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("ExtendedConstraintsData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0xC (12)
		
		protected float m_Falloff = new float();
		[ContainerField(Name: "Falloff", Offset: 16, NameHash: 1431733965, Flags: 49469), LayoutImmutable, Blittable]
		public float Falloff { get { return m_Falloff; } set { if (OnPropertyChanging("ExtendedConstraintsData." + nameof(Falloff), this, m_Falloff, value)) m_Falloff = value; } } // 0x10 (16)
		
		protected float m_AngularConstraintMin = new float();
		[ContainerField(Name: "AngularConstraintMin", Offset: 20, NameHash: 731814824, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularConstraintMin { get { return m_AngularConstraintMin; } set { if (OnPropertyChanging("ExtendedConstraintsData." + nameof(AngularConstraintMin), this, m_AngularConstraintMin, value)) m_AngularConstraintMin = value; } } // 0x14 (20)
		
		protected float m_AngularConstraintMax = new float();
		[ContainerField(Name: "AngularConstraintMax", Offset: 24, NameHash: 731815094, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularConstraintMax { get { return m_AngularConstraintMax; } set { if (OnPropertyChanging("ExtendedConstraintsData." + nameof(AngularConstraintMax), this, m_AngularConstraintMax, value)) m_AngularConstraintMax = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2009143629:
					Heading = (float) p_Value;
					break;

				case 226981187:
					Width = (float) p_Value;
					break;

				case 1431733965:
					Falloff = (float) p_Value;
					break;

				case 731814824:
					AngularConstraintMin = (float) p_Value;
					break;

				case 731815094:
					AngularConstraintMax = (float) p_Value;
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
				case 2009143629:
					return Heading;

				case 226981187:
					return Width;

				case 1431733965:
					return Falloff;

				case 731814824:
					return AngularConstraintMin;

				case 731815094:
					return AngularConstraintMax;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2009143629:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Heading));

				case 226981187:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Width));

				case 1431733965:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(Falloff));

				case 731814824:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(AngularConstraintMin));

				case 731815094:
					return typeof(ExtendedConstraintsData).GetProperty(nameof(AngularConstraintMax));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
