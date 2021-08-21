///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class PhysicsDebugSettings : 
		DataContainer
	{
		protected uint m_TimingRecursionDepth = new uint();
		[ContainerField(Name: "TimingRecursionDepth", Offset: 8, NameHash: 2471681392, Flags: 49421), LayoutImmutable, Blittable]
		public uint TimingRecursionDepth { get { return m_TimingRecursionDepth; } set { if (OnPropertyChanging("PhysicsDebugSettings." + nameof(TimingRecursionDepth), this, m_TimingRecursionDepth, value)) m_TimingRecursionDepth = value; } } // 0x8 (8)
		
		protected bool m_UsePhysicsCpuTimers = new bool();
		[ContainerField(Name: "UsePhysicsCpuTimers", Offset: 12, NameHash: 888297727, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePhysicsCpuTimers { get { return m_UsePhysicsCpuTimers; } set { if (OnPropertyChanging("PhysicsDebugSettings." + nameof(UsePhysicsCpuTimers), this, m_UsePhysicsCpuTimers, value)) m_UsePhysicsCpuTimers = value; } } // 0xC (12)
		
		protected bool m_DebugHingeConstraints = new bool();
		[ContainerField(Name: "DebugHingeConstraints", Offset: 13, NameHash: 4121530031, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugHingeConstraints { get { return m_DebugHingeConstraints; } set { if (OnPropertyChanging("PhysicsDebugSettings." + nameof(DebugHingeConstraints), this, m_DebugHingeConstraints, value)) m_DebugHingeConstraints = value; } } // 0xD (13)
		
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
