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
	public class UICombatAreaCompData : 
		UIComponentData
	{
		protected string m_OutOfAreaSidPrefix = string.Empty;
		[ContainerField(28), LayoutImmutable, ContainerFieldNameHash(3191885467)]
		public string OutOfAreaSidPrefix { get { return m_OutOfAreaSidPrefix; } set { if (OnPropertyChanging("UICombatAreaCompData." + nameof(OutOfAreaSidPrefix), this, m_OutOfAreaSidPrefix, value)) m_OutOfAreaSidPrefix = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3191885467:
					OutOfAreaSidPrefix = (string) p_Value;
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
				case 3191885467:
					return OutOfAreaSidPrefix;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3191885467:
					return typeof(UICombatAreaCompData).GetProperty(nameof(OutOfAreaSidPrefix));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
