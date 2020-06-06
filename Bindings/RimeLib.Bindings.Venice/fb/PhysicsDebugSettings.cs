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
	public class PhysicsDebugSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint TimingRecursionDepth { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool UsePhysicsCpuTimers { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool DebugHingeConstraints { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2471681392:
					TimingRecursionDepth = (uint) p_Value;
					break;

				case 888297727:
					UsePhysicsCpuTimers = (bool) p_Value;
					break;

				case 4121530031:
					DebugHingeConstraints = (bool) p_Value;
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
				case 2471681392:
					return TimingRecursionDepth;

				case 888297727:
					return UsePhysicsCpuTimers;

				case 4121530031:
					return DebugHingeConstraints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2471681392:
					return typeof(PhysicsDebugSettings).GetProperty(nameof(TimingRecursionDepth));

				case 888297727:
					return typeof(PhysicsDebugSettings).GetProperty(nameof(UsePhysicsCpuTimers));

				case 4121530031:
					return typeof(PhysicsDebugSettings).GetProperty(nameof(DebugHingeConstraints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
