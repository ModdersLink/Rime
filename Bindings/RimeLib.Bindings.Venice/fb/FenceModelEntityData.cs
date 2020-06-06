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
	public class FenceModelEntityData : 
		StaticModelEntityData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
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
				case 226981187:
					return Width;

				case 205597860:
					return Angle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(FenceModelEntityData).GetProperty(nameof(Width));

				case 205597860:
					return typeof(FenceModelEntityData).GetProperty(nameof(Angle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
