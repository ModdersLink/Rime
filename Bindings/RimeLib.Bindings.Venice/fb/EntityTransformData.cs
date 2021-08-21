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
	public class EntityTransformData : 
		DataContainer
	{
		protected List<LinearTransform> m_EntityTransforms = new List<LinearTransform>();
		[ContainerField(Name: "EntityTransforms", Offset: 8, NameHash: 1975599521, Flags: 65)]
		public List<LinearTransform> EntityTransforms { get { return m_EntityTransforms; } set { if (OnPropertyChanging("EntityTransformData." + nameof(EntityTransforms), this, m_EntityTransforms, value)) m_EntityTransforms = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1975599521:
					EntityTransforms = (List<LinearTransform>) p_Value;
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
				case 1975599521:
					return EntityTransforms;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1975599521:
					return typeof(EntityTransformData).GetProperty(nameof(EntityTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
