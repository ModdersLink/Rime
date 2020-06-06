///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LogicReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96)]
		public SubRealm SubRealm { get; set; } = new SubRealm(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1747841366:
					SubRealm = (SubRealm) Enum.ToObject(typeof(SubRealm), p_Value);
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
				case 1747841366:
					return SubRealm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1747841366:
					return typeof(LogicReferenceObjectData).GetProperty(nameof(SubRealm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
