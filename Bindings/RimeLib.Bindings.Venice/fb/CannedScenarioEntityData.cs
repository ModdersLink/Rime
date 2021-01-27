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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 60)]
	public class CannedScenarioEntityData : 
		EntityData
	{
		protected CannedAnimationBinding m_CannedAnimBinding = new CannedAnimationBinding();
		[ContainerField(Name: "CannedAnimBinding", Offset: 12, NameHash: 3536770252, Flags: 41)]
		public CannedAnimationBinding CannedAnimBinding { get { return m_CannedAnimBinding; } set { if (OnPropertyChanging("CannedScenarioEntityData." + nameof(CannedAnimBinding), this, m_CannedAnimBinding, value)) m_CannedAnimBinding = value; } } // 0xC (12)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(Name: "AnimationEntitySpacePriority", Offset: 52, NameHash: 4041607518, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("CannedScenarioEntityData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0x34 (52)
		
		protected bool m_AlwaysClearEntitySpaceWhenInScenario = new bool();
		[ContainerField(Name: "AlwaysClearEntitySpaceWhenInScenario", Offset: 56, NameHash: 4447823, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysClearEntitySpaceWhenInScenario { get { return m_AlwaysClearEntitySpaceWhenInScenario; } set { if (OnPropertyChanging("CannedScenarioEntityData." + nameof(AlwaysClearEntitySpaceWhenInScenario), this, m_AlwaysClearEntitySpaceWhenInScenario, value)) m_AlwaysClearEntitySpaceWhenInScenario = value; } } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3536770252:
					CannedAnimBinding = (CannedAnimationBinding) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 4447823:
					AlwaysClearEntitySpaceWhenInScenario = (bool) p_Value;
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
				case 3536770252:
					return CannedAnimBinding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 4447823:
					return AlwaysClearEntitySpaceWhenInScenario;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3536770252:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(CannedAnimBinding));

				case 4041607518:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 4447823:
					return typeof(CannedScenarioEntityData).GetProperty(nameof(AlwaysClearEntitySpaceWhenInScenario));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
