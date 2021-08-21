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
	public class MatchmakingPlayerCapacityModifier : 
		MatchmakingModifier
	{
		protected string m_Attribute = string.Empty;
		[ContainerField(Name: "Attribute", Offset: 8, NameHash: 2715851769, Flags: 16509), LayoutImmutable]
		public string Attribute { get { return m_Attribute; } set { if (OnPropertyChanging("MatchmakingPlayerCapacityModifier." + nameof(Attribute), this, m_Attribute, value)) m_Attribute = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2715851769:
					Attribute = (string) p_Value;
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
				case 2715851769:
					return Attribute;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2715851769:
					return typeof(MatchmakingPlayerCapacityModifier).GetProperty(nameof(Attribute));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
