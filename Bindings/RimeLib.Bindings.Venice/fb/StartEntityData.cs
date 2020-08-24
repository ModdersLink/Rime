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
	public class StartEntityData : 
		EntityData
	{
		protected float m_SortIndex = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1347637313)]
		public float SortIndex { get { return m_SortIndex; } set { if (OnPropertyChanging("StartEntityData." + nameof(SortIndex), this, m_SortIndex, value)) m_SortIndex = value; } } // 0xC (12)
		
		protected string m_StartName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3727215458)]
		public string StartName { get { return m_StartName; } set { if (OnPropertyChanging("StartEntityData." + nameof(StartName), this, m_StartName, value)) m_StartName = value; } } // 0x10 (16)
		
		protected bool m_IsDefault = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2802724276)]
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
