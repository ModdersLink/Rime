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
	public class VeniceUISettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string MetaDataAssetPath { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool GetStatsInOnlineFlow { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1169897301:
					MetaDataAssetPath = (string) p_Value;
					break;

				case 3247310760:
					GetStatsInOnlineFlow = (bool) p_Value;
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
				case 1169897301:
					return MetaDataAssetPath;

				case 3247310760:
					return GetStatsInOnlineFlow;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1169897301:
					return typeof(VeniceUISettings).GetProperty(nameof(MetaDataAssetPath));

				case 3247310760:
					return typeof(VeniceUISettings).GetProperty(nameof(GetStatsInOnlineFlow));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
