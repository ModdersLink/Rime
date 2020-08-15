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
	[ContainerType(16)]
	public class WindComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(96), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("WindComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected float m_WindDirection = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(3147800788)]
		public float WindDirection { get { return m_WindDirection; } set { if (OnPropertyChanging("WindComponentData." + nameof(WindDirection), this, m_WindDirection, value)) m_WindDirection = value; } } // 0x64 (100)
		
		protected float m_WindStrength = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(3768589012)]
		public float WindStrength { get { return m_WindStrength; } set { if (OnPropertyChanging("WindComponentData." + nameof(WindStrength), this, m_WindStrength, value)) m_WindStrength = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3147800788:
					WindDirection = (float) p_Value;
					break;

				case 3768589012:
					WindStrength = (float) p_Value;
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

				case 3147800788:
					return WindDirection;

				case 3768589012:
					return WindStrength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(WindComponentData).GetProperty(nameof(Realm));

				case 3147800788:
					return typeof(WindComponentData).GetProperty(nameof(WindDirection));

				case 3768589012:
					return typeof(WindComponentData).GetProperty(nameof(WindStrength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
