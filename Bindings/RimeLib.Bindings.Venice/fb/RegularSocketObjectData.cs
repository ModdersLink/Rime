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
	public class RegularSocketObjectData : 
		SocketObjectData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x50 (80)
		
		[ContainerField(144)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new List<LinearTransform>(); // 0x90 (144)
		
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
					return typeof(RegularSocketObjectData).GetProperty(nameof(Transform));

				case 1625436330:
					return typeof(RegularSocketObjectData).GetProperty(nameof(Mesh3pTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
