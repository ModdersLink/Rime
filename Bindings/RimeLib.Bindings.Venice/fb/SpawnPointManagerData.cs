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
	public class SpawnPointManagerData : 
		Asset
	{
		protected bool m_UseAiLodSystem = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1610978156)]
		public bool UseAiLodSystem { get { return m_UseAiLodSystem; } set { if (OnPropertyChanging("SpawnPointManagerData." + nameof(UseAiLodSystem), this, m_UseAiLodSystem, value)) m_UseAiLodSystem = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1610978156:
					UseAiLodSystem = (bool) p_Value;
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
				case 1610978156:
					return UseAiLodSystem;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1610978156:
					return typeof(SpawnPointManagerData).GetProperty(nameof(UseAiLodSystem));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
