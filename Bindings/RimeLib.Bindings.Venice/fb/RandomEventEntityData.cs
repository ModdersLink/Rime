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
	public class RandomEventEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("RandomEventEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected int m_Probability = new int();
		[ContainerField(Name: "Probability", Offset: 16, NameHash: 35957416, Flags: 49405), LayoutImmutable, Blittable]
		public int Probability { get { return m_Probability; } set { if (OnPropertyChanging("RandomEventEntityData." + nameof(Probability), this, m_Probability, value)) m_Probability = value; } } // 0x10 (16)
		
		protected bool m_RandomizeFirstOnly = new bool();
		[ContainerField(Name: "RandomizeFirstOnly", Offset: 20, NameHash: 882338790, Flags: 49325), LayoutImmutable, Blittable]
		public bool RandomizeFirstOnly { get { return m_RandomizeFirstOnly; } set { if (OnPropertyChanging("RandomEventEntityData." + nameof(RandomizeFirstOnly), this, m_RandomizeFirstOnly, value)) m_RandomizeFirstOnly = value; } } // 0x14 (20)
		
		protected bool m_AutoStart = new bool();
		[ContainerField(Name: "AutoStart", Offset: 21, NameHash: 792615882, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoStart { get { return m_AutoStart; } set { if (OnPropertyChanging("RandomEventEntityData." + nameof(AutoStart), this, m_AutoStart, value)) m_AutoStart = value; } } // 0x15 (21)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 35957416:
					Probability = (int) p_Value;
					break;

				case 882338790:
					RandomizeFirstOnly = (bool) p_Value;
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 35957416:
					return Probability;

				case 882338790:
					return RandomizeFirstOnly;

				case 792615882:
					return AutoStart;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(RandomEventEntityData).GetProperty(nameof(Realm));

				case 35957416:
					return typeof(RandomEventEntityData).GetProperty(nameof(Probability));

				case 882338790:
					return typeof(RandomEventEntityData).GetProperty(nameof(RandomizeFirstOnly));

				case 792615882:
					return typeof(RandomEventEntityData).GetProperty(nameof(AutoStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
