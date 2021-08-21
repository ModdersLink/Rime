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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class StreamingGateEntityData : 
		EntityData
	{
		protected float m_Timeout = new float();
		[ContainerField(Name: "Timeout", Offset: 12, NameHash: 3344700766, Flags: 49469), LayoutImmutable, Blittable]
		public float Timeout { get { return m_Timeout; } set { if (OnPropertyChanging("StreamingGateEntityData." + nameof(Timeout), this, m_Timeout, value)) m_Timeout = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3344700766:
					Timeout = (float) p_Value;
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
				case 3344700766:
					return Timeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3344700766:
					return typeof(StreamingGateEntityData).GetProperty(nameof(Timeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
