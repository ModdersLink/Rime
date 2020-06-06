///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WeaponAnimationConfigurationModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new List<float>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AnimationConfigurationData AnimationConfiguration { get; set; } = new AnimationConfigurationData(); // 0xC (12)
		
		[ContainerField(24)]
		public AnimatedFireEnum AnimatedFireType { get; set; } = new AnimatedFireEnum(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1322171705:
					ZoomInOutMeshTransitionFactors = (List<float>) p_Value;
					break;

				case 711248867:
					AnimationConfiguration = (AnimationConfigurationData) p_Value;
					break;

				case 1066105722:
					AnimatedFireType = (AnimatedFireEnum) Enum.ToObject(typeof(AnimatedFireEnum), p_Value);
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
				case 1322171705:
					return ZoomInOutMeshTransitionFactors;

				case 711248867:
					return AnimationConfiguration;

				case 1066105722:
					return AnimatedFireType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1322171705:
					return typeof(WeaponAnimationConfigurationModifier).GetProperty(nameof(ZoomInOutMeshTransitionFactors));

				case 711248867:
					return typeof(WeaponAnimationConfigurationModifier).GetProperty(nameof(AnimationConfiguration));

				case 1066105722:
					return typeof(WeaponAnimationConfigurationModifier).GetProperty(nameof(AnimatedFireType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
