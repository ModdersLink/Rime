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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 80)]
	public class UpdateCameraProximityData : 
		ProcessorData
	{
		protected Vec3 m_Size = new Vec3();
		[ContainerField(Name: "Size", Offset: 48, NameHash: 2089429248, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Size { get { return m_Size; } set { if (OnPropertyChanging("UpdateCameraProximityData." + nameof(Size), this, m_Size, value)) m_Size = value; } } // 0x30 (48)
		
		protected float m_ForwardOffset = new float();
		[ContainerField(Name: "ForwardOffset", Offset: 64, NameHash: 2564135379, Flags: 49469), LayoutImmutable, Blittable]
		public float ForwardOffset { get { return m_ForwardOffset; } set { if (OnPropertyChanging("UpdateCameraProximityData." + nameof(ForwardOffset), this, m_ForwardOffset, value)) m_ForwardOffset = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089429248:
					Size = (Vec3) p_Value;
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
					return typeof(UpdateCameraProximityData).GetProperty(nameof(Size));

				case 2564135379:
					return typeof(UpdateCameraProximityData).GetProperty(nameof(ForwardOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
