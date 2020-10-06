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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class TestCaseEntityData : 
		EntityData
	{
		protected float m_TimeOut = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3344659518)]
		public float TimeOut { get { return m_TimeOut; } set { if (OnPropertyChanging("TestCaseEntityData." + nameof(TimeOut), this, m_TimeOut, value)) m_TimeOut = value; } } // 0xC (12)
		
		protected string m_TestGroup = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1436402060)]
		public string TestGroup { get { return m_TestGroup; } set { if (OnPropertyChanging("TestCaseEntityData." + nameof(TestGroup), this, m_TestGroup, value)) m_TestGroup = value; } } // 0x10 (16)
		
		protected string m_TestCaseName = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2495365472)]
		public string TestCaseName { get { return m_TestCaseName; } set { if (OnPropertyChanging("TestCaseEntityData." + nameof(TestCaseName), this, m_TestCaseName, value)) m_TestCaseName = value; } } // 0x14 (20)
		
		protected bool m_Stable = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3319702312)]
		public bool Stable { get { return m_Stable; } set { if (OnPropertyChanging("TestCaseEntityData." + nameof(Stable), this, m_Stable, value)) m_Stable = value; } } // 0x18 (24)
		
		protected bool m_Enabled = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("TestCaseEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3344659518:
					TimeOut = (float) p_Value;
					break;

				case 1436402060:
					TestGroup = (string) p_Value;
					break;

				case 2495365472:
					TestCaseName = (string) p_Value;
					break;

				case 3319702312:
					Stable = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 3344659518:
					return TimeOut;

				case 1436402060:
					return TestGroup;

				case 2495365472:
					return TestCaseName;

				case 3319702312:
					return Stable;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3344659518:
					return typeof(TestCaseEntityData).GetProperty(nameof(TimeOut));

				case 1436402060:
					return typeof(TestCaseEntityData).GetProperty(nameof(TestGroup));

				case 2495365472:
					return typeof(TestCaseEntityData).GetProperty(nameof(TestCaseName));

				case 3319702312:
					return typeof(TestCaseEntityData).GetProperty(nameof(Stable));

				case 2662400:
					return typeof(TestCaseEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
