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
	[ContainerType(4)]
	public class MaterialPropertyImpulseData : 
		PhysicsPropertyRelationPropertyData
	{
		protected float m_ImpulseAbsorptionMultiplier = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(1970095508)]
		public float ImpulseAbsorptionMultiplier { get { return m_ImpulseAbsorptionMultiplier; } set { if (OnPropertyChanging("MaterialPropertyImpulseData." + nameof(ImpulseAbsorptionMultiplier), this, m_ImpulseAbsorptionMultiplier, value)) m_ImpulseAbsorptionMultiplier = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1970095508:
					ImpulseAbsorptionMultiplier = (float) p_Value;
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
				case 1970095508:
					return ImpulseAbsorptionMultiplier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1970095508:
					return typeof(MaterialPropertyImpulseData).GetProperty(nameof(ImpulseAbsorptionMultiplier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
