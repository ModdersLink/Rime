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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class EntryInputActionMapsData : 
		Asset
	{
		protected int m_ActionMapSettingsScheme = new int();
		[ContainerField(Name: "ActionMapSettingsScheme", Offset: 12, NameHash: 3553311511, Flags: 49405), LayoutImmutable, Blittable]
		public int ActionMapSettingsScheme { get { return m_ActionMapSettingsScheme; } set { if (OnPropertyChanging("EntryInputActionMapsData." + nameof(ActionMapSettingsScheme), this, m_ActionMapSettingsScheme, value)) m_ActionMapSettingsScheme = value; } } // 0xC (12)
		
		protected InputActionMapSlot m_DefaultInputActionMap = new InputActionMapSlot();
		[ContainerField(Name: "DefaultInputActionMap", Offset: 16, NameHash: 1781726042, Flags: 137)]
		public InputActionMapSlot DefaultInputActionMap { get { return m_DefaultInputActionMap; } set { if (OnPropertyChanging("EntryInputActionMapsData." + nameof(DefaultInputActionMap), this, m_DefaultInputActionMap, value)) m_DefaultInputActionMap = value; } } // 0x10 (16)
		
		protected RefArray<EntryInputActionMapData> m_InputActionMaps = new RefArray<EntryInputActionMapData>();
		[ContainerField(Name: "InputActionMaps", Offset: 20, NameHash: 2094181090, Flags: 65)]
		public RefArray<EntryInputActionMapData> InputActionMaps { get { return m_InputActionMaps; } set { if (OnPropertyChanging("EntryInputActionMapsData." + nameof(InputActionMaps), this, m_InputActionMaps, value)) m_InputActionMaps = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3553311511:
					ActionMapSettingsScheme = (int) p_Value;
					break;

				case 1781726042:
					DefaultInputActionMap = (InputActionMapSlot) Enum.ToObject(typeof(InputActionMapSlot), p_Value);
					break;

				case 2094181090:
					InputActionMaps = (RefArray<EntryInputActionMapData>) p_Value;
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
				case 3553311511:
					return ActionMapSettingsScheme;

				case 1781726042:
					return DefaultInputActionMap;

				case 2094181090:
					return InputActionMaps;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3553311511:
					return typeof(EntryInputActionMapsData).GetProperty(nameof(ActionMapSettingsScheme));

				case 1781726042:
					return typeof(EntryInputActionMapsData).GetProperty(nameof(DefaultInputActionMap));

				case 2094181090:
					return typeof(EntryInputActionMapsData).GetProperty(nameof(InputActionMaps));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
