///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class OcclusionSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x8 (8)
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool DrawZbuffer { get; set; } // 0x9 (9)
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool DrawBinaryBuffer { get; set; } // 0xA (10)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 449305695:
					DrawZbuffer = (bool) p_Value;
					break;

				case 728628138:
					DrawBinaryBuffer = (bool) p_Value;
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
				case 2342790116:
					return Enable;

				case 449305695:
					return DrawZbuffer;

				case 728628138:
					return DrawBinaryBuffer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2342790116:
					return typeof(OcclusionSettings).GetProperty(nameof(Enable));

				case 449305695:
					return typeof(OcclusionSettings).GetProperty(nameof(DrawZbuffer));

				case 728628138:
					return typeof(OcclusionSettings).GetProperty(nameof(DrawBinaryBuffer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
