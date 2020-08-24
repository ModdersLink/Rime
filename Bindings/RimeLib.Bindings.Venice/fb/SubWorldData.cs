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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SubWorldData : 
		SpatialPrefabBlueprint
	{
		protected CtrRef<RegistryContainer> m_RegistryContainer = new CtrRef<RegistryContainer>();
		[ContainerField(36), MemberInfoFlag(53), ContainerFieldNameHash(1535522391), ContainerCtrRef]
		public CtrRef<RegistryContainer> RegistryContainer { get { return m_RegistryContainer; } set { if (OnPropertyChanging("SubWorldData." + nameof(RegistryContainer), this, m_RegistryContainer, value)) m_RegistryContainer = value; } } // 0x24 (36)
		
		protected bool m_IsWin32SubLevel = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2682003100)]
		public bool IsWin32SubLevel { get { return m_IsWin32SubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsWin32SubLevel), this, m_IsWin32SubLevel, value)) m_IsWin32SubLevel = value; } } // 0x28 (40)
		
		protected bool m_IsXenonSubLevel = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(948884383)]
		public bool IsXenonSubLevel { get { return m_IsXenonSubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsXenonSubLevel), this, m_IsXenonSubLevel, value)) m_IsXenonSubLevel = value; } } // 0x29 (41)
		
		protected bool m_IsPs3SubLevel = new bool();
		[ContainerField(42), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(396788349)]
		public bool IsPs3SubLevel { get { return m_IsPs3SubLevel; } set { if (OnPropertyChanging("SubWorldData." + nameof(IsPs3SubLevel), this, m_IsPs3SubLevel, value)) m_IsPs3SubLevel = value; } } // 0x2A (42)
		
		protected bool m_RememberStateOnStreamOut = new bool();
		[ContainerField(43), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4212179462)]
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
