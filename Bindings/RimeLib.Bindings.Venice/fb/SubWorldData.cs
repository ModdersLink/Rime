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
	public class SubWorldData : 
		SpatialPrefabBlueprint
	{
		[ContainerField(36)]
		public CtrRef<RegistryContainer> RegistryContainer { get; set; } = new CtrRef<RegistryContainer>(); // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsWin32SubLevel { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool IsXenonSubLevel { get; set; } // 0x29 (41)
		
		[ContainerField(42), LayoutImmutable, Blittable]
		public bool IsPs3SubLevel { get; set; } // 0x2A (42)
		
		[ContainerField(43), LayoutImmutable, Blittable]
		public bool RememberStateOnStreamOut { get; set; } // 0x2B (43)
		
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
