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
	public class SubWorldReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), LayoutImmutable]
		public string BundleName { get; set; } // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<SubWorldInclusionSettings> InclusionSettings { get; set; } = new CtrRef<SubWorldInclusionSettings>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool AutoLoad { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsWin32SubLevel { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool IsXenonSubLevel { get; set; } // 0x6A (106)
		
		[ContainerField(107), LayoutImmutable, Blittable]
		public bool IsPs3SubLevel { get; set; } // 0x6B (107)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 461157046:
					BundleName = (string) p_Value;
					break;

				case 1787638950:
					InclusionSettings = (CtrRef<SubWorldInclusionSettings>) p_Value;
					break;

				case 3537348684:
					AutoLoad = (bool) p_Value;
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

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 461157046:
					return BundleName;

				case 1787638950:
					return InclusionSettings;

				case 3537348684:
					return AutoLoad;

				case 2682003100:
					return IsWin32SubLevel;

				case 948884383:
					return IsXenonSubLevel;

				case 396788349:
					return IsPs3SubLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 461157046:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(BundleName));

				case 1787638950:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(InclusionSettings));

				case 3537348684:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(AutoLoad));

				case 2682003100:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsWin32SubLevel));

				case 948884383:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsXenonSubLevel));

				case 396788349:
					return typeof(SubWorldReferenceObjectData).GetProperty(nameof(IsPs3SubLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
