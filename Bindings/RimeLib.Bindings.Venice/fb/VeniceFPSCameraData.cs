///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VeniceFPSCameraData : 
		FPSCameraData
	{
		[ContainerField(224), LayoutImmutable, Blittable]
		public float SuppressionBlurAmountMultiplier { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float SuppressionBlurSizeMultiplier { get; set; } // 0xE4 (228)
		
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
