///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIComponentData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string ShortName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<string> DataSources { get; set; } = new List<string>(); // 0x10 (16)
		
		[ContainerField(20)]
		public UIUpdateType UpdateType { get; set; } = new UIUpdateType(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int UpdatesPerSecond { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1803010032:
					ShortName = (string) p_Value;
					break;

				case 1204335067:
					DataSources = (List<string>) p_Value;
					break;

				case 2270667052:
					UpdateType = (UIUpdateType) Enum.ToObject(typeof(UIUpdateType), p_Value);
					break;

				case 2192548880:
					UpdatesPerSecond = (int) p_Value;
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
				case 1803010032:
					return ShortName;

				case 1204335067:
					return DataSources;

				case 2270667052:
					return UpdateType;

				case 2192548880:
					return UpdatesPerSecond;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1803010032:
					return typeof(UIComponentData).GetProperty(nameof(ShortName));

				case 1204335067:
					return typeof(UIComponentData).GetProperty(nameof(DataSources));

				case 2270667052:
					return typeof(UIComponentData).GetProperty(nameof(UpdateType));

				case 2192548880:
					return typeof(UIComponentData).GetProperty(nameof(UpdatesPerSecond));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
