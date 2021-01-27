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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class TreeNodeBase : 
		DataContainer
	{
		protected string m_NodeName = string.Empty;
		[ContainerField(Name: "NodeName", Offset: 8, NameHash: 2598021986, Flags: 16509), LayoutImmutable]
		public string NodeName { get { return m_NodeName; } set { if (OnPropertyChanging("TreeNodeBase." + nameof(NodeName), this, m_NodeName, value)) m_NodeName = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2598021986:
					NodeName = (string) p_Value;
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
				case 2598021986:
					return NodeName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2598021986:
					return typeof(TreeNodeBase).GetProperty(nameof(NodeName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
