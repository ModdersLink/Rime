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
	public class LookAtEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool UseStaticDirection { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x52 (82)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 709901739:
					RunOnce = (bool) p_Value;
					break;

				case 597626235:
					UseStaticDirection = (bool) p_Value;
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
				case 709901739:
					return RunOnce;

				case 597626235:
					return UseStaticDirection;

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
				case 709901739:
					return typeof(LookAtEntityData).GetProperty(nameof(RunOnce));

				case 597626235:
					return typeof(LookAtEntityData).GetProperty(nameof(UseStaticDirection));

				case 2662400:
					return typeof(LookAtEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
