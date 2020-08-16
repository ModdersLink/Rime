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
	public class AdvancedDogTagData : 
		DogTagData
	{
		protected string m_StatCode = string.Empty;
		[ContainerField(68), LayoutImmutable, ContainerFieldNameHash(3117339322)]
		public string StatCode { get { return m_StatCode; } set { if (OnPropertyChanging("AdvancedDogTagData." + nameof(StatCode), this, m_StatCode, value)) m_StatCode = value; } } // 0x44 (68)
		
		protected string m_StatSID = string.Empty;
		[ContainerField(72), LayoutImmutable, ContainerFieldNameHash(2176854761)]
		public string StatSID { get { return m_StatSID; } set { if (OnPropertyChanging("AdvancedDogTagData." + nameof(StatSID), this, m_StatSID, value)) m_StatSID = value; } } // 0x48 (72)
		
		protected bool m_IsStatMeasuredInTime = new bool();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(3369514563)]
		public bool IsStatMeasuredInTime { get { return m_IsStatMeasuredInTime; } set { if (OnPropertyChanging("AdvancedDogTagData." + nameof(IsStatMeasuredInTime), this, m_IsStatMeasuredInTime, value)) m_IsStatMeasuredInTime = value; } } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3117339322:
					StatCode = (string) p_Value;
					break;

				case 2176854761:
					StatSID = (string) p_Value;
					break;

				case 3369514563:
					IsStatMeasuredInTime = (bool) p_Value;
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
				case 3117339322:
					return StatCode;

				case 2176854761:
					return StatSID;

				case 3369514563:
					return IsStatMeasuredInTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3117339322:
					return typeof(AdvancedDogTagData).GetProperty(nameof(StatCode));

				case 2176854761:
					return typeof(AdvancedDogTagData).GetProperty(nameof(StatSID));

				case 3369514563:
					return typeof(AdvancedDogTagData).GetProperty(nameof(IsStatMeasuredInTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
