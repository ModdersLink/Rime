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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class ConsoleCommandTriggerEntityData : 
		EntityData
	{
		protected string m_CommandName = string.Empty;
		[ContainerField(Name: "CommandName", Offset: 12, NameHash: 1071676005, Flags: 16509), LayoutImmutable]
		public string CommandName { get { return m_CommandName; } set { if (OnPropertyChanging("ConsoleCommandTriggerEntityData." + nameof(CommandName), this, m_CommandName, value)) m_CommandName = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 16, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ConsoleCommandTriggerEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1071676005:
					CommandName = (string) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 1071676005:
					return CommandName;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1071676005:
					return typeof(ConsoleCommandTriggerEntityData).GetProperty(nameof(CommandName));

				case 229961746:
					return typeof(ConsoleCommandTriggerEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
