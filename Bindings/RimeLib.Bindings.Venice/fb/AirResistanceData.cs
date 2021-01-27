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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class AirResistanceData : 
		ProcessorData
	{
		protected float m_DragFactor = new float();
		[ContainerField(Name: "DragFactor", Offset: 48, NameHash: 709065016, Flags: 49469), LayoutImmutable, Blittable]
		public float DragFactor { get { return m_DragFactor; } set { if (OnPropertyChanging("AirResistanceData." + nameof(DragFactor), this, m_DragFactor, value)) m_DragFactor = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 709065016:
					DragFactor = (float) p_Value;
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
				case 709065016:
					return DragFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 709065016:
					return typeof(AirResistanceData).GetProperty(nameof(DragFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
