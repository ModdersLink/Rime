///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIStateAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<UIComponentData> UIComponents { get; set; } = new RefArray<UIComponentData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<UIAsset> ActionscriptLibraries { get; set; } = new RefArray<UIAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<string> ActionscriptNames { get; set; } = new List<string>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string StateName { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string StatePath { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4207180421:
					UIComponents = (RefArray<UIComponentData>) p_Value;
					break;

				case 439634061:
					ActionscriptLibraries = (RefArray<UIAsset>) p_Value;
					break;

				case 581231424:
					ActionscriptNames = (List<string>) p_Value;
					break;

				case 4126874677:
					StateName = (string) p_Value;
					break;

				case 4126080863:
					StatePath = (string) p_Value;
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
				case 4207180421:
					return UIComponents;

				case 439634061:
					return ActionscriptLibraries;

				case 581231424:
					return ActionscriptNames;

				case 4126874677:
					return StateName;

				case 4126080863:
					return StatePath;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4207180421:
					return typeof(UIStateAsset).GetProperty(nameof(UIComponents));

				case 439634061:
					return typeof(UIStateAsset).GetProperty(nameof(ActionscriptLibraries));

				case 581231424:
					return typeof(UIStateAsset).GetProperty(nameof(ActionscriptNames));

				case 4126874677:
					return typeof(UIStateAsset).GetProperty(nameof(StateName));

				case 4126080863:
					return typeof(UIStateAsset).GetProperty(nameof(StatePath));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
