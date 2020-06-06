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
	public class InputActionMapData : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<InputActionsData> Actions { get; set; } = new RefArray<InputActionsData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public InputActionMapPlatform PlatformSpecific { get; set; } = new InputActionMapPlatform(); // 0xC (12)
		
		[ContainerField(16)]
		public InputActionMapSlot Slot { get; set; } = new InputActionMapSlot(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string CopyKeyBindingsFrom { get; set; } // 0x14 (20)
		
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
