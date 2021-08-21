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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class MaterialPropertyEffectData : 
		PhysicsMaterialRelationPropertyData
	{
		protected RefArray<EffectBlueprint> m_ImpactEffects = new RefArray<EffectBlueprint>();
		[ContainerField(Name: "ImpactEffects", Offset: 8, NameHash: 2149182307, Flags: 65)]
		public RefArray<EffectBlueprint> ImpactEffects { get { return m_ImpactEffects; } set { if (OnPropertyChanging("MaterialPropertyEffectData." + nameof(ImpactEffects), this, m_ImpactEffects, value)) m_ImpactEffects = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2149182307:
					ImpactEffects = (RefArray<EffectBlueprint>) p_Value;
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
				case 2149182307:
					return ImpactEffects;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2149182307:
					return typeof(MaterialPropertyEffectData).GetProperty(nameof(ImpactEffects));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
