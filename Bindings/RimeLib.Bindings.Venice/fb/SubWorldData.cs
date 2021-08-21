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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class SubWorldData : 
		SpatialPrefabBlueprint
	{
		protected CtrRef<RegistryContainer> m_RegistryContainer = new CtrRef<RegistryContainer>();
		[ContainerField(Name: "RegistryContainer", Offset: 36, NameHash: 1535522391, Flags: 53)]
		public CtrRef<RegistryContainer> RegistryContainer { get { return m_RegistryContainer; } set { if (OnPropertyChanging("SubWorldData." + nameof(RegistryContainer), this, m_RegistryContainer, value)) m_RegistryContainer = value; } } // 0x24 (36)
		
		protected bool m_IsWin32SubLevel = new bool();
		[ContainerField(Name: "IsWin32SubLevel", Offset: 40, NameHash: 2682003100, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsWin32SubLevel { get { return m_IsWin32SubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsWin32SubLevel), this, m_IsWin32SubLevel, value)) m_IsWin32SubLevel = value; } } // 0x28 (40)
		
		protected bool m_IsXenonSubLevel = new bool();
		[ContainerField(Name: "IsXenonSubLevel", Offset: 41, NameHash: 948884383, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsXenonSubLevel { get { return m_IsXenonSubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsXenonSubLevel), this, m_IsXenonSubLevel, value)) m_IsXenonSubLevel = value; } } // 0x29 (41)
		
		protected bool m_IsPs3SubLevel = new bool();
		[ContainerField(Name: "IsPs3SubLevel", Offset: 42, NameHash: 396788349, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsPs3SubLevel { get { return m_IsPs3SubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsPs3SubLevel), this, m_IsPs3SubLevel, value)) m_IsPs3SubLevel = value; } } // 0x2A (42)
		
		protected bool m_RememberStateOnStreamOut = new bool();
		[ContainerField(Name: "RememberStateOnStreamOut", Offset: 43, NameHash: 4212179462, Flags: 49325), LayoutImmutable, Blittable]
		public bool RememberStateOnStreamOut { get { return m_RememberStateOnStreamOut; } set { if (OnPropertyChanging("SubWorldData." + nameof(RememberStateOnStreamOut), this, m_RememberStateOnStreamOut, value)) m_RememberStateOnStreamOut = value; } } // 0x2B (43)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1535522391:
					RegistryContainer = (CtrRef<RegistryContainer>) p_Value;
					break;

				case 2682003100:
					IsWin32SubLevel = (bool) p_Value;
					break;

				case 948884383:
					IsXenonSubLevel = (bool) p_Value;
					break;

				case 396788349:
					IsPs3SubLevel = (bool) p_Value;
					break;

				case 4212179462:
					RememberStateOnStreamOut = (bool) p_Value;
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
				case 1535522391:
					return RegistryContainer;

				case 2682003100:
					return IsWin32SubLevel;

				case 948884383:
					return IsXenonSubLevel;

				case 396788349:
					return IsPs3SubLevel;

				case 4212179462:
					return RememberStateOnStreamOut;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1535522391:
					return typeof(SubWorldData).GetProperty(nameof(RegistryContainer));

				case 2682003100:
					return typeof(SubWorldData).GetProperty(nameof(IsWin32SubLevel));

				case 948884383:
					return typeof(SubWorldData).GetProperty(nameof(IsXenonSubLevel));

				case 396788349:
					return typeof(SubWorldData).GetProperty(nameof(IsPs3SubLevel));

				case 4212179462:
					return typeof(SubWorldData).GetProperty(nameof(RememberStateOnStreamOut));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
