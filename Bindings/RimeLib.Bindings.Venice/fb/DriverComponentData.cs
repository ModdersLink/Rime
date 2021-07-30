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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class DriverComponentData : 
		ComponentData
	{
		protected float m_WantedSpeed = new float();
		[ContainerField(Name: "WantedSpeed", Offset: 96, NameHash: 3561027151, Flags: 49469), LayoutImmutable, Blittable]
		public float WantedSpeed { get { return m_WantedSpeed; } set { if (OnPropertyChanging("DriverComponentData." + nameof(WantedSpeed), this, m_WantedSpeed, value)) m_WantedSpeed = value; } } // 0x60 (96)
		
		protected CtrRef<DriverSettings> m_Settings = new CtrRef<DriverSettings>();
		[ContainerField(Name: "Settings", Offset: 100, NameHash: 649772672, Flags: 53)]
		public CtrRef<DriverSettings> Settings { get { return m_Settings; } set { if (OnPropertyChanging("DriverComponentData." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3561027151:
					WantedSpeed = (float) p_Value;
					break;

				case 649772672:
					Settings = (CtrRef<DriverSettings>) p_Value;
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
				case 3561027151:
					return WantedSpeed;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3561027151:
					return typeof(DriverComponentData).GetProperty(nameof(WantedSpeed));

				case 649772672:
					return typeof(DriverComponentData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
