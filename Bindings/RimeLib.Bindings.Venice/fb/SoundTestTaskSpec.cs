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
	public class SoundTestTaskSpec : 
		DataContainer
	{
		protected string m_Description = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(1636673251)]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("SoundTestTaskSpec." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x8 (8)
		
		protected float m_Duration = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1828507227)]
		public float Duration { get { return m_Duration; } set { if (OnPropertyChanging("SoundTestTaskSpec." + nameof(Duration), this, m_Duration, value)) m_Duration = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1636673251:
					Description = (string) p_Value;
					break;

				case 1828507227:
					Duration = (float) p_Value;
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
				case 1636673251:
					return Description;

				case 1828507227:
					return Duration;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1636673251:
					return typeof(SoundTestTaskSpec).GetProperty(nameof(Description));

				case 1828507227:
					return typeof(SoundTestTaskSpec).GetProperty(nameof(Duration));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
