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
	public class WeaponAnimationConfigurationModifier : 
		WeaponModifierBase
	{
		protected List<float> m_ZoomInOutMeshTransitionFactors = new List<float>();
		[ContainerField(Name: "ZoomInOutMeshTransitionFactors", Offset: 8, NameHash: 1322171705, Flags: 65)]
		public List<float> ZoomInOutMeshTransitionFactors { get { return m_ZoomInOutMeshTransitionFactors; } set { if (OnPropertyChanging("WeaponAnimationConfigurationModifier." + nameof(ZoomInOutMeshTransitionFactors), this, m_ZoomInOutMeshTransitionFactors, value)) m_ZoomInOutMeshTransitionFactors = value; } } // 0x8 (8)
		
		protected AnimationConfigurationData m_AnimationConfiguration = new AnimationConfigurationData();
		[ContainerField(Name: "AnimationConfiguration", Offset: 12, NameHash: 711248867, Flags: 41)]
		public AnimationConfigurationData AnimationConfiguration { get { return m_AnimationConfiguration; } set { if (OnPropertyChanging("WeaponAnimationConfigurationModifier." + nameof(AnimationConfiguration), this, m_AnimationConfiguration, value)) m_AnimationConfiguration = value; } } // 0xC (12)
		
		protected AnimatedFireEnum m_AnimatedFireType = new AnimatedFireEnum();
		[ContainerField(Name: "AnimatedFireType", Offset: 24, NameHash: 1066105722, Flags: 137)]
		public AnimatedFireEnum AnimatedFireType { get { return m_AnimatedFireType; } set { if (OnPropertyChanging("WeaponAnimationConfigurationModifier." + nameof(AnimatedFireType), this, m_AnimatedFireType, value)) m_AnimatedFireType = value; } } // 0x18 (24)
		
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
