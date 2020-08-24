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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class InputActionMapData : 
		DataContainer
	{
		protected RefArray<InputActionsData> m_Actions = new RefArray<InputActionsData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(373511656), ContainerRefArray]
		public RefArray<InputActionsData> Actions { get { return m_Actions; } set { if (OnPropertyChanging("InputActionMapData." + nameof(Actions), this, m_Actions, value)) m_Actions = value; } } // 0x8 (8)
		
		protected InputActionMapPlatform m_PlatformSpecific = new InputActionMapPlatform();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(818960378)]
		public InputActionMapPlatform PlatformSpecific { get { return m_PlatformSpecific; } set { if (OnPropertyChanging("InputActionMapData." + nameof(PlatformSpecific), this, m_PlatformSpecific, value)) m_PlatformSpecific = value; } } // 0xC (12)
		
		protected InputActionMapSlot m_Slot = new InputActionMapSlot();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(2089426785)]
		public InputActionMapSlot Slot { get { return m_Slot; } set { if (OnPropertyChanging("InputActionMapData." + nameof(Slot), this, m_Slot, value)) m_Slot = value; } } // 0x10 (16)
		
		protected string m_CopyKeyBindingsFrom = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2847317651)]
		public string CopyKeyBindingsFrom { get { return m_CopyKeyBindingsFrom; } set { if (OnPropertyChanging("InputActionMapData." + nameof(CopyKeyBindingsFrom), this, m_CopyKeyBindingsFrom, value)) m_CopyKeyBindingsFrom = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 373511656:
					Actions = (RefArray<InputActionsData>) p_Value;
					break;

				case 818960378:
					PlatformSpecific = (InputActionMapPlatform) Enum.ToObject(typeof(InputActionMapPlatform), p_Value);
					break;

				case 2089426785:
					Slot = (InputActionMapSlot) Enum.ToObject(typeof(InputActionMapSlot), p_Value);
					break;

				case 2847317651:
					CopyKeyBindingsFrom = (string) p_Value;
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
				case 373511656:
					return Actions;

				case 818960378:
					return PlatformSpecific;

				case 2089426785:
					return Slot;

				case 2847317651:
					return CopyKeyBindingsFrom;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 373511656:
					return typeof(InputActionMapData).GetProperty(nameof(Actions));

				case 818960378:
					return typeof(InputActionMapData).GetProperty(nameof(PlatformSpecific));

				case 2089426785:
					return typeof(InputActionMapData).GetProperty(nameof(Slot));

				case 2847317651:
					return typeof(InputActionMapData).GetProperty(nameof(CopyKeyBindingsFrom));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
