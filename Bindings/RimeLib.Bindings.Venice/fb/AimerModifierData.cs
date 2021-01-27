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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class AimerModifierData : 
		Asset
	{
		protected float m_LookSpeedMultiplier = new float();
		[ContainerField(Name: "LookSpeedMultiplier", Offset: 12, NameHash: 1418472942, Flags: 49469), LayoutImmutable, Blittable]
		public float LookSpeedMultiplier { get { return m_LookSpeedMultiplier; } set { if (OnPropertyChanging("AimerModifierData." + nameof(LookSpeedMultiplier), this, m_LookSpeedMultiplier, value)) m_LookSpeedMultiplier = value; } } // 0xC (12)
		
		protected bool m_OnlyInSupportedShooting = new bool();
		[ContainerField(Name: "OnlyInSupportedShooting", Offset: 16, NameHash: 809776183, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get { return m_OnlyInSupportedShooting; } set { if (OnPropertyChanging("AimerModifierData." + nameof(OnlyInSupportedShooting), this, m_OnlyInSupportedShooting, value)) m_OnlyInSupportedShooting = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1418472942:
					LookSpeedMultiplier = (float) p_Value;
					break;

				case 809776183:
					OnlyInSupportedShooting = (bool) p_Value;
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
				case 1418472942:
					return LookSpeedMultiplier;

				case 809776183:
					return OnlyInSupportedShooting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1418472942:
					return typeof(AimerModifierData).GetProperty(nameof(LookSpeedMultiplier));

				case 809776183:
					return typeof(AimerModifierData).GetProperty(nameof(OnlyInSupportedShooting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
