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
	public class SensingComponentData : 
		ComponentData
	{
		protected CtrRef<SensingTemplateData> m_Template = new CtrRef<SensingTemplateData>();
		[ContainerField(96), ContainerFieldNameHash(2427043285)]
		public CtrRef<SensingTemplateData> Template { get { return m_Template; } set { if (OnPropertyChanging("SensingComponentData." + nameof(Template), this, m_Template, value)) m_Template = value; } } // 0x60 (96)
		
		protected CtrRef<SensingSettings> m_Settings = new CtrRef<SensingSettings>();
		[ContainerField(100), ContainerFieldNameHash(649772672)]
		public CtrRef<SensingSettings> Settings { get { return m_Settings; } set { if (OnPropertyChanging("SensingComponentData." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0x64 (100)
		
		protected bool m_Enabled = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("SensingComponentData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x68 (104)
		
		protected bool m_SharedPlayerMemory = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, ContainerFieldNameHash(3832351454)]
		public bool SharedPlayerMemory { get { return m_SharedPlayerMemory; } set { if (OnPropertyChanging("SensingComponentData." + nameof(SharedPlayerMemory), this, m_SharedPlayerMemory, value)) m_SharedPlayerMemory = value; } } // 0x69 (105)
		
		protected bool m_UseWeaponTransform = new bool();
		[ContainerField(106), LayoutImmutable, Blittable, ContainerFieldNameHash(3375914696)]
		public bool UseWeaponTransform { get { return m_UseWeaponTransform; } set { if (OnPropertyChanging("SensingComponentData." + nameof(UseWeaponTransform), this, m_UseWeaponTransform, value)) m_UseWeaponTransform = value; } } // 0x6A (106)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2427043285:
					Template = (CtrRef<SensingTemplateData>) p_Value;
					break;

				case 649772672:
					Settings = (CtrRef<SensingSettings>) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				case 3832351454:
					SharedPlayerMemory = (bool) p_Value;
					break;

				case 3375914696:
					UseWeaponTransform = (bool) p_Value;
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
				case 2427043285:
					return Template;

				case 649772672:
					return Settings;

				case 2662400:
					return Enabled;

				case 3832351454:
					return SharedPlayerMemory;

				case 3375914696:
					return UseWeaponTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2427043285:
					return typeof(SensingComponentData).GetProperty(nameof(Template));

				case 649772672:
					return typeof(SensingComponentData).GetProperty(nameof(Settings));

				case 2662400:
					return typeof(SensingComponentData).GetProperty(nameof(Enabled));

				case 3832351454:
					return typeof(SensingComponentData).GetProperty(nameof(SharedPlayerMemory));

				case 3375914696:
					return typeof(SensingComponentData).GetProperty(nameof(UseWeaponTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
