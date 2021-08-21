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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 80)]
	public class CameraProximityEvaluatorData : 
		EvaluatorData
	{
		protected Vec3 m_Size = new Vec3();
		[ContainerField(Name: "Size", Offset: 16, NameHash: 2089429248, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Size { get { return m_Size; } set { if (OnPropertyChanging("CameraProximityEvaluatorData." + nameof(Size), this, m_Size, value)) m_Size = value; } } // 0x10 (16)
		
		protected Vec3 m_Offset = new Vec3();
		[ContainerField(Name: "Offset", Offset: 32, NameHash: 2871410728, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get { return m_Offset; } set { if (OnPropertyChanging("CameraProximityEvaluatorData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x20 (32)
		
		protected Vec3 m_InnerRadiusDirection = new Vec3();
		[ContainerField(Name: "InnerRadiusDirection", Offset: 48, NameHash: 3044199494, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InnerRadiusDirection { get { return m_InnerRadiusDirection; } set { if (OnPropertyChanging("CameraProximityEvaluatorData." + nameof(InnerRadiusDirection), this, m_InnerRadiusDirection, value)) m_InnerRadiusDirection = value; } } // 0x30 (48)
		
		protected float m_InnerRadius = new float();
		[ContainerField(Name: "InnerRadius", Offset: 64, NameHash: 3334193859, Flags: 49469), LayoutImmutable, Blittable]
		public float InnerRadius { get { return m_InnerRadius; } set { if (OnPropertyChanging("CameraProximityEvaluatorData." + nameof(InnerRadius), this, m_InnerRadius, value)) m_InnerRadius = value; } } // 0x40 (64)
		
		protected float m_ForwardOffset = new float();
		[ContainerField(Name: "ForwardOffset", Offset: 68, NameHash: 2564135379, Flags: 49469), LayoutImmutable, Blittable]
		public float ForwardOffset { get { return m_ForwardOffset; } set { if (OnPropertyChanging("CameraProximityEvaluatorData." + nameof(ForwardOffset), this, m_ForwardOffset, value)) m_ForwardOffset = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (Vec3) p_Value;
					break;

				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 3044199494:
					InnerRadiusDirection = (Vec3) p_Value;
					break;

				case 3334193859:
					InnerRadius = (float) p_Value;
					break;

				case 2564135379:
					ForwardOffset = (float) p_Value;
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
				case 2089429248:
					return Size;

				case 2871410728:
					return Offset;

				case 3044199494:
					return InnerRadiusDirection;

				case 3334193859:
					return InnerRadius;

				case 2564135379:
					return ForwardOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089429248:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(Size));

				case 2871410728:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(Offset));

				case 3044199494:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(InnerRadiusDirection));

				case 3334193859:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(InnerRadius));

				case 2564135379:
					return typeof(CameraProximityEvaluatorData).GetProperty(nameof(ForwardOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
