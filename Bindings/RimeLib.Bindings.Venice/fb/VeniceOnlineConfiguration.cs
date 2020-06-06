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
	public class VeniceOnlineConfiguration : 
		OnlineConfiguration
	{
		[ContainerField(28)]
		public List<OnlinePlatformConfiguration> Platforms { get; set; } = new List<OnlinePlatformConfiguration>(); // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<EntitlementQuery> EntitlementQueries { get; set; } = new RefArray<EntitlementQuery>(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool UseFallback { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1046011945:
					Platforms = (List<OnlinePlatformConfiguration>) p_Value;
					break;

				case 2121789744:
					EntitlementQueries = (RefArray<EntitlementQuery>) p_Value;
					break;

				case 2260806602:
					UseFallback = (bool) p_Value;
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
				case 1046011945:
					return Platforms;

				case 2121789744:
					return EntitlementQueries;

				case 2260806602:
					return UseFallback;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1046011945:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(Platforms));

				case 2121789744:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(EntitlementQueries));

				case 2260806602:
					return typeof(VeniceOnlineConfiguration).GetProperty(nameof(UseFallback));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
