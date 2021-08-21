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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class InputRecorderData : 
		DataContainer
	{
		protected string m_FileNamePrefix = string.Empty;
		[ContainerField(Name: "FileNamePrefix", Offset: 8, NameHash: 452437588, Flags: 16509), LayoutImmutable]
		public string FileNamePrefix { get { return m_FileNamePrefix; } set { if (OnPropertyChanging("InputRecorderData." + nameof(FileNamePrefix), this, m_FileNamePrefix, value)) m_FileNamePrefix = value; } } // 0x8 (8)
		
		protected string m_FileName = string.Empty;
		[ContainerField(Name: "FileName", Offset: 12, NameHash: 1134474212, Flags: 16509), LayoutImmutable]
		public string FileName { get { return m_FileName; } set { if (OnPropertyChanging("InputRecorderData." + nameof(FileName), this, m_FileName, value)) m_FileName = value; } } // 0xC (12)
		
		protected EntryInputActionEnum m_ToggleRecordAction = new EntryInputActionEnum();
		[ContainerField(Name: "ToggleRecordAction", Offset: 16, NameHash: 390577636, Flags: 137)]
		public EntryInputActionEnum ToggleRecordAction { get { return m_ToggleRecordAction; } set { if (OnPropertyChanging("InputRecorderData." + nameof(ToggleRecordAction), this, m_ToggleRecordAction, value)) m_ToggleRecordAction = value; } } // 0x10 (16)
		
		protected bool m_AutoIncrementFileName = new bool();
		[ContainerField(Name: "AutoIncrementFileName", Offset: 20, NameHash: 4191315274, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoIncrementFileName { get { return m_AutoIncrementFileName; } set { if (OnPropertyChanging("InputRecorderData." + nameof(AutoIncrementFileName), this, m_AutoIncrementFileName, value)) m_AutoIncrementFileName = value; } } // 0x14 (20)
		
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
