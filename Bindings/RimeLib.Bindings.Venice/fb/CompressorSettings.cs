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
	public class CompressorSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Ratio { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Threshold { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Attack { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Release { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230084836:
					Ratio = (float) p_Value;
					break;

				case 3768602130:
					Threshold = (float) p_Value;
					break;

				case 2500885101:
					Attack = (float) p_Value;
					break;

				case 1335266828:
					Release = (float) p_Value;
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
				case 230084836:
					return Ratio;

				case 3768602130:
					return Threshold;

				case 2500885101:
					return Attack;

				case 1335266828:
					return Release;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230084836:
					return typeof(CompressorSettings).GetProperty(nameof(Ratio));

				case 3768602130:
					return typeof(CompressorSettings).GetProperty(nameof(Threshold));

				case 2500885101:
					return typeof(CompressorSettings).GetProperty(nameof(Attack));

				case 1335266828:
					return typeof(CompressorSettings).GetProperty(nameof(Release));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
