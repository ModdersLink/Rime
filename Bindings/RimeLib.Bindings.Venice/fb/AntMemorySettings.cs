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
	public class AntMemorySettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int RTPoolLayersControllers { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int RTPoolStateflowControllers { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int RTPoolStateflowNodeControllers { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int RTPoolTransitionControllers { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int RTPoolClipControllers { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int RTPoolChooserControllers { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int RTPoolLoopingControllers { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int RTPoolTransparentControllers { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2134937184:
					RTPoolLayersControllers = (int) p_Value;
					break;

				case 399895253:
					RTPoolStateflowControllers = (int) p_Value;
					break;

				case 3245671861:
					RTPoolStateflowNodeControllers = (int) p_Value;
					break;

				case 509962655:
					RTPoolTransitionControllers = (int) p_Value;
					break;

				case 2397424326:
					RTPoolClipControllers = (int) p_Value;
					break;

				case 2848570943:
					RTPoolChooserControllers = (int) p_Value;
					break;

				case 392141612:
					RTPoolLoopingControllers = (int) p_Value;
					break;

				case 3696829270:
					RTPoolTransparentControllers = (int) p_Value;
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
				case 2134937184:
					return RTPoolLayersControllers;

				case 399895253:
					return RTPoolStateflowControllers;

				case 3245671861:
					return RTPoolStateflowNodeControllers;

				case 509962655:
					return RTPoolTransitionControllers;

				case 2397424326:
					return RTPoolClipControllers;

				case 2848570943:
					return RTPoolChooserControllers;

				case 392141612:
					return RTPoolLoopingControllers;

				case 3696829270:
					return RTPoolTransparentControllers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2134937184:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolLayersControllers));

				case 399895253:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolStateflowControllers));

				case 3245671861:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolStateflowNodeControllers));

				case 509962655:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolTransitionControllers));

				case 2397424326:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolClipControllers));

				case 2848570943:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolChooserControllers));

				case 392141612:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolLoopingControllers));

				case 3696829270:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolTransparentControllers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
