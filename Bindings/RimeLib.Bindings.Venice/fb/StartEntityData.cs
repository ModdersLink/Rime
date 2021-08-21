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
	public class StartEntityData : 
		EntityData
	{
		protected float m_SortIndex = new float();
		[ContainerField(Name: "SortIndex", Offset: 12, NameHash: 1347637313, Flags: 49469), LayoutImmutable, Blittable]
		public float SortIndex { get { return m_SortIndex; } set { if (OnPropertyChanging("StartEntityData." + nameof(SortIndex), this, m_SortIndex, value)) m_SortIndex = value; } } // 0xC (12)
		
		protected string m_StartName = string.Empty;
		[ContainerField(Name: "StartName", Offset: 16, NameHash: 3727215458, Flags: 16509), LayoutImmutable]
		public string StartName { get { return m_StartName; } set { if (OnPropertyChanging("StartEntityData." + nameof(StartName), this, m_StartName, value)) m_StartName = value; } } // 0x10 (16)
		
		protected bool m_IsDefault = new bool();
		[ContainerField(Name: "IsDefault", Offset: 20, NameHash: 2802724276, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsDefault { get { return m_IsDefault; } set { if (OnPropertyChanging("StartEntityData." + nameof(IsDefault), this, m_IsDefault, value)) m_IsDefault = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1347637313:
					SortIndex = (float) p_Value;
					break;

				case 3727215458:
					StartName = (string) p_Value;
					break;

				case 2802724276:
					IsDefault = (bool) p_Value;
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
				case 1347637313:
					return SortIndex;

				case 3727215458:
					return StartName;

				case 2802724276:
					return IsDefault;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1347637313:
					return typeof(StartEntityData).GetProperty(nameof(SortIndex));

				case 3727215458:
					return typeof(StartEntityData).GetProperty(nameof(StartName));

				case 2802724276:
					return typeof(StartEntityData).GetProperty(nameof(IsDefault));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
