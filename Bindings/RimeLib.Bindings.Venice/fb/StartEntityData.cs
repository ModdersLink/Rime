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
	public class StartEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SortIndex { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string StartName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool IsDefault { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1347637313:
					SortIndex = (float) p_Value;
					break;

				case 3727215458:
					StartName = (string) p_Value;
					break;

				case 2802724276:
					IsDefault = (bool) p_Value;
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
				case 1347637313:
					return SortIndex;

				case 3727215458:
					return StartName;

				case 2802724276:
					return IsDefault;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1347637313:
					return typeof(StartEntityData).GetProperty(nameof(SortIndex));

				case 3727215458:
					return typeof(StartEntityData).GetProperty(nameof(StartName));

				case 2802724276:
					return typeof(StartEntityData).GetProperty(nameof(IsDefault));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
