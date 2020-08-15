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
	public class InputRecorderData : 
		DataContainer
	{
		protected string m_FileNamePrefix = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(452437588)]
		public string FileNamePrefix { get { return m_FileNamePrefix; } set { if (OnPropertyChanging("InputRecorderData." + nameof(FileNamePrefix), this, m_FileNamePrefix, value)) m_FileNamePrefix = value; } } // 0x8 (8)
		
		protected string m_FileName = new string();
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(1134474212)]
		public string FileName { get { return m_FileName; } set { if (OnPropertyChanging("InputRecorderData." + nameof(FileName), this, m_FileName, value)) m_FileName = value; } } // 0xC (12)
		
		protected EntryInputActionEnum m_ToggleRecordAction = new EntryInputActionEnum();
		[ContainerField(16), ContainerFieldNameHash(390577636)]
		public EntryInputActionEnum ToggleRecordAction { get { return m_ToggleRecordAction; } set { if (OnPropertyChanging("InputRecorderData." + nameof(ToggleRecordAction), this, m_ToggleRecordAction, value)) m_ToggleRecordAction = value; } } // 0x10 (16)
		
		protected bool m_AutoIncrementFileName = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(4191315274)]
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
