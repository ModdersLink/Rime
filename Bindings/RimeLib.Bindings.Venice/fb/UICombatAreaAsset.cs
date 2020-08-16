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
	public class UICombatAreaAsset : 
		Asset
	{
		protected string m_Prefix = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(3358704757)]
		public string Prefix { get { return m_Prefix; } set { if (OnPropertyChanging("UICombatAreaAsset." + nameof(Prefix), this, m_Prefix, value)) m_Prefix = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3358704757:
					Prefix = (string) p_Value;
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
				case 3358704757:
					return Prefix;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3358704757:
					return typeof(UICombatAreaAsset).GetProperty(nameof(Prefix));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
