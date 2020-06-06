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
	public class ViewFxData : 
		DataContainer
	{
		[ContainerField(8)]
		public PoissonRadialBlurData PoissonRadialBlur { get; set; } = new PoissonRadialBlurData(); // 0x8 (8)
		
		[ContainerField(32)]
		public ColorTintData ColorTint { get; set; } = new ColorTintData(); // 0x20 (32)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float BlurAdd { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool ColorTintEnable { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool PoissonRadialBlurEnable { get; set; } // 0x65 (101)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 838527112:
					PoissonRadialBlur = (PoissonRadialBlurData) p_Value;
					break;

				case 518108063:
					ColorTint = (ColorTintData) p_Value;
					break;

				case 2736421901:
					BlurAdd = (float) p_Value;
					break;

				case 596952702:
					ColorTintEnable = (bool) p_Value;
					break;

				case 2327396521:
					PoissonRadialBlurEnable = (bool) p_Value;
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
				case 838527112:
					return PoissonRadialBlur;

				case 518108063:
					return ColorTint;

				case 2736421901:
					return BlurAdd;

				case 596952702:
					return ColorTintEnable;

				case 2327396521:
					return PoissonRadialBlurEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 838527112:
					return typeof(ViewFxData).GetProperty(nameof(PoissonRadialBlur));

				case 518108063:
					return typeof(ViewFxData).GetProperty(nameof(ColorTint));

				case 2736421901:
					return typeof(ViewFxData).GetProperty(nameof(BlurAdd));

				case 596952702:
					return typeof(ViewFxData).GetProperty(nameof(ColorTintEnable));

				case 2327396521:
					return typeof(ViewFxData).GetProperty(nameof(PoissonRadialBlurEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
