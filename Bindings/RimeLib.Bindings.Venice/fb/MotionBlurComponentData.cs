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
    [ContainerType(16)]
	public class MotionBlurComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float CutoffGradientScale { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float MotionBlurCutoffRadius { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool MotionBlurEnable { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 686258422:
					CutoffGradientScale = (float) p_Value;
					break;

				case 1171302503:
					MotionBlurCutoffRadius = (float) p_Value;
					break;

				case 1384583315:
					MotionBlurEnable = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 686258422:
					return CutoffGradientScale;

				case 1171302503:
					return MotionBlurCutoffRadius;

				case 1384583315:
					return MotionBlurEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(MotionBlurComponentData).GetProperty(nameof(Realm));

				case 686258422:
					return typeof(MotionBlurComponentData).GetProperty(nameof(CutoffGradientScale));

				case 1171302503:
					return typeof(MotionBlurComponentData).GetProperty(nameof(MotionBlurCutoffRadius));

				case 1384583315:
					return typeof(MotionBlurComponentData).GetProperty(nameof(MotionBlurEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
