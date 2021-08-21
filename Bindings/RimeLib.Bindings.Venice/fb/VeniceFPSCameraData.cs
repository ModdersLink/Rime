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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 240)]
	public class VeniceFPSCameraData : 
		FPSCameraData
	{
		protected float m_SuppressionBlurAmountMultiplier = new float();
		[ContainerField(Name: "SuppressionBlurAmountMultiplier", Offset: 224, NameHash: 471397458, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressionBlurAmountMultiplier { get { return m_SuppressionBlurAmountMultiplier; } set { if (OnPropertyChanging("VeniceFPSCameraData." + nameof(SuppressionBlurAmountMultiplier), this, m_SuppressionBlurAmountMultiplier, value)) m_SuppressionBlurAmountMultiplier = value; } } // 0xE0 (224)
		
		protected float m_SuppressionBlurSizeMultiplier = new float();
		[ContainerField(Name: "SuppressionBlurSizeMultiplier", Offset: 228, NameHash: 1437853051, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressionBlurSizeMultiplier { get { return m_SuppressionBlurSizeMultiplier; } set { if (OnPropertyChanging("VeniceFPSCameraData." + nameof(SuppressionBlurSizeMultiplier), this, m_SuppressionBlurSizeMultiplier, value)) m_SuppressionBlurSizeMultiplier = value; } } // 0xE4 (228)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 471397458:
					SuppressionBlurAmountMultiplier = (float) p_Value;
					break;

				case 1437853051:
					SuppressionBlurSizeMultiplier = (float) p_Value;
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
				case 471397458:
					return SuppressionBlurAmountMultiplier;

				case 1437853051:
					return SuppressionBlurSizeMultiplier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 471397458:
					return typeof(VeniceFPSCameraData).GetProperty(nameof(SuppressionBlurAmountMultiplier));

				case 1437853051:
					return typeof(VeniceFPSCameraData).GetProperty(nameof(SuppressionBlurSizeMultiplier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
