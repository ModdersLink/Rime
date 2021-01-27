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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class MaterialContainerPair : 
		DataContainer
	{
		protected uint m_FlagsAndIndex = new uint();
		[ContainerField(Name: "FlagsAndIndex", Offset: 8, NameHash: 948792655, Flags: 49421), LayoutImmutable, Blittable]
		public uint FlagsAndIndex { get { return m_FlagsAndIndex; } set { if (OnPropertyChanging("MaterialContainerPair." + nameof(FlagsAndIndex), this, m_FlagsAndIndex, value)) m_FlagsAndIndex = value; } } // 0x8 (8)
		
		protected sbyte m_PhysicsPropertyIndex = new sbyte();
		[ContainerField(Name: "PhysicsPropertyIndex", Offset: 12, NameHash: 2298256471, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte PhysicsPropertyIndex { get { return m_PhysicsPropertyIndex; } set { if (OnPropertyChanging("MaterialContainerPair." + nameof(PhysicsPropertyIndex), this, m_PhysicsPropertyIndex, value)) m_PhysicsPropertyIndex = value; } } // 0xC (12)
		
		protected sbyte m_PhysicsMaterialIndex = new sbyte();
		[ContainerField(Name: "PhysicsMaterialIndex", Offset: 13, NameHash: 2836775707, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte PhysicsMaterialIndex { get { return m_PhysicsMaterialIndex; } set { if (OnPropertyChanging("MaterialContainerPair." + nameof(PhysicsMaterialIndex), this, m_PhysicsMaterialIndex, value)) m_PhysicsMaterialIndex = value; } } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 948792655:
					FlagsAndIndex = (uint) p_Value;
					break;

				case 2298256471:
					PhysicsPropertyIndex = (sbyte) p_Value;
					break;

				case 2836775707:
					PhysicsMaterialIndex = (sbyte) p_Value;
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
				case 948792655:
					return FlagsAndIndex;

				case 2298256471:
					return PhysicsPropertyIndex;

				case 2836775707:
					return PhysicsMaterialIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 948792655:
					return typeof(MaterialContainerPair).GetProperty(nameof(FlagsAndIndex));

				case 2298256471:
					return typeof(MaterialContainerPair).GetProperty(nameof(PhysicsPropertyIndex));

				case 2836775707:
					return typeof(MaterialContainerPair).GetProperty(nameof(PhysicsMaterialIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
