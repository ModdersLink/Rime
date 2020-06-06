///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SensingComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SensingTemplateData> Template { get; set; } = new CtrRef<SensingTemplateData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<SensingSettings> Settings { get; set; } = new CtrRef<SensingSettings>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool SharedPlayerMemory { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool UseWeaponTransform { get; set; } // 0x6A (106)
		
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
