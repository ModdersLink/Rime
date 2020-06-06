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
	public class VisualEnvironmentReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int Priority { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool OverrideVisibility { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 3611184311:
					OverrideVisibility = (bool) p_Value;
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
				case 3062102871:
					return Priority;

				case 3611184311:
					return OverrideVisibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3062102871:
					return typeof(VisualEnvironmentReferenceObjectData).GetProperty(nameof(Priority));

				case 3611184311:
					return typeof(VisualEnvironmentReferenceObjectData).GetProperty(nameof(OverrideVisibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
