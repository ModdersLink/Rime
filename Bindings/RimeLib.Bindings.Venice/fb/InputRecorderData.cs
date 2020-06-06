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
	public class InputRecorderData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string FileNamePrefix { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string FileName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public EntryInputActionEnum ToggleRecordAction { get; set; } = new EntryInputActionEnum(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoIncrementFileName { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 452437588:
					FileNamePrefix = (string) p_Value;
					break;

				case 1134474212:
					FileName = (string) p_Value;
					break;

				case 390577636:
					ToggleRecordAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 4191315274:
					AutoIncrementFileName = (bool) p_Value;
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
				case 452437588:
					return FileNamePrefix;

				case 1134474212:
					return FileName;

				case 390577636:
					return ToggleRecordAction;

				case 4191315274:
					return AutoIncrementFileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 452437588:
					return typeof(InputRecorderData).GetProperty(nameof(FileNamePrefix));

				case 1134474212:
					return typeof(InputRecorderData).GetProperty(nameof(FileName));

				case 390577636:
					return typeof(InputRecorderData).GetProperty(nameof(ToggleRecordAction));

				case 4191315274:
					return typeof(InputRecorderData).GetProperty(nameof(AutoIncrementFileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
