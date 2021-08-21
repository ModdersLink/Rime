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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class ObjectBlueprint : 
		Blueprint
	{
		protected CtrRef<GameObjectData> m_Object = new CtrRef<GameObjectData>();
		[ContainerField(Name: "Object", Offset: 32, NameHash: 2866508144, Flags: 53)]
		public CtrRef<GameObjectData> Object { get { return m_Object; } set { if (OnPropertyChanging("ObjectBlueprint." + nameof(Object), this, m_Object, value)) m_Object = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2866508144:
					Object = (CtrRef<GameObjectData>) p_Value;
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
				case 2866508144:
					return Object;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2866508144:
					return typeof(ObjectBlueprint).GetProperty(nameof(Object));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
