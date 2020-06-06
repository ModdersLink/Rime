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
    [ContainerType(4)]
	public class EntryInputActionMapsData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int ActionMapSettingsScheme { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public InputActionMapSlot DefaultInputActionMap { get; set; } = new InputActionMapSlot(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<EntryInputActionMapData> InputActionMaps { get; set; } = new RefArray<EntryInputActionMapData>(); // 0x14 (20)
		
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
