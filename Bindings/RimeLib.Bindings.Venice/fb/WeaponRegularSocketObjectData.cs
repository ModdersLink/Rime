///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WeaponRegularSocketObjectData : 
		WeaponSocketObjectData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x20 (32)
		
		[ContainerField(96)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new List<LinearTransform>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 1625436330:
					Mesh3pTransforms = (List<LinearTransform>) p_Value;
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
				case 2270319721:
					return Transform;

				case 1625436330:
					return Mesh3pTransforms;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(WeaponRegularSocketObjectData).GetProperty(nameof(Transform));

				case 1625436330:
					return typeof(WeaponRegularSocketObjectData).GetProperty(nameof(Mesh3pTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
