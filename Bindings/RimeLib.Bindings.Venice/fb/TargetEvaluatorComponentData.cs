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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TargetEvaluatorComponentData : 
		ComponentData
	{
		protected float m_UpdateInterval = new float();
		[ContainerField(Name: "UpdateInterval", Offset: 96, NameHash: 754325291, Flags: 49469), LayoutImmutable, Blittable]
		public float UpdateInterval { get { return m_UpdateInterval; } set { if (OnPropertyChanging("TargetEvaluatorComponentData." + nameof(UpdateInterval), this, m_UpdateInterval, value)) m_UpdateInterval = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 754325291:
					UpdateInterval = (float) p_Value;
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
				case 754325291:
					return UpdateInterval;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 754325291:
					return typeof(TargetEvaluatorComponentData).GetProperty(nameof(UpdateInterval));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
