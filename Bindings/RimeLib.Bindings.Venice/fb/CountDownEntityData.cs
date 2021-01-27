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
	public class CountDownEntityData : 
		EntityData
	{
		protected int m_StartValue = new int();
		[ContainerField(Name: "StartValue", Offset: 12, NameHash: 2748522638, Flags: 49405), LayoutImmutable, Blittable]
		public int StartValue { get { return m_StartValue; } set { if (OnPropertyChanging("CountDownEntityData." + nameof(StartValue), this, m_StartValue, value)) m_StartValue = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 16, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CountDownEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		protected bool m_RunOnce = new bool();
		[ContainerField(Name: "RunOnce", Offset: 20, NameHash: 709901739, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("CountDownEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2748522638:
					StartValue = (int) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
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
				case 2748522638:
					return StartValue;

				case 229961746:
					return Realm;

				case 709901739:
					return RunOnce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2748522638:
					return typeof(CountDownEntityData).GetProperty(nameof(StartValue));

				case 229961746:
					return typeof(CountDownEntityData).GetProperty(nameof(Realm));

				case 709901739:
					return typeof(CountDownEntityData).GetProperty(nameof(RunOnce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
