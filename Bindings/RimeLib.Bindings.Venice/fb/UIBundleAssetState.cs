///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIBundleAssetState : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string StateName { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public UIState UIState { get; set; } = new UIState(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable]
		public string ResourceBundleName { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4126874677:
					StateName = (string) p_Value;
					break;

				case 187033486:
						UIState = (UIState) Enum.ToObject(typeof(UIState), p_Value);
					break;

				case 1249588540:
					ResourceBundleName = (string) p_Value;
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
				case 4126874677:
					return StateName;

				case 187033486:
					return UIState;

				case 1249588540:
					return ResourceBundleName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4126874677:
					return typeof(UIBundleAssetState).GetProperty(nameof(StateName));

				case 187033486:
					return typeof(UIBundleAssetState).GetProperty(nameof(UIState));

				case 1249588540:
					return typeof(UIBundleAssetState).GetProperty(nameof(ResourceBundleName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
