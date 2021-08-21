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
	public class UnlockValuePair : 
		DataContainer
	{
		protected string m_Id = string.Empty;
		[ContainerField(Name: "Id", Offset: 8, NameHash: 5862152, Flags: 16509), LayoutImmutable]
		public string Id { get { return m_Id; } set { if (OnPropertyChanging("UnlockValuePair." + nameof(Id), this, m_Id, value)) m_Id = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862152:
					Id = (string) p_Value;
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
				case 5862152:
					return Id;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862152:
					return typeof(UnlockValuePair).GetProperty(nameof(Id));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
