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
	public class EntitlementQuery : 
		Asset
	{
		[ContainerField(12)]
		public List<EntitlementData> EntitlementsData { get; set; } = new List<EntitlementData>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<string> GroupNames { get; set; } = new List<string>(); // 0x10 (16)
		
		[ContainerField(20)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string EntitlementTag { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string ProductId { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string ProjectId { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2421825855:
					EntitlementsData = (List<EntitlementData>) p_Value;
					break;

				case 1803493518:
					GroupNames = (List<string>) p_Value;
					break;

				case 942751002:
					Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 1654763342:
					EntitlementTag = (string) p_Value;
					break;

				case 106414083:
					ProductId = (string) p_Value;
					break;

				case 4152360413:
					ProjectId = (string) p_Value;
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
				case 2421825855:
					return EntitlementsData;

				case 1803493518:
					return GroupNames;

				case 942751002:
					return Platform;

				case 1654763342:
					return EntitlementTag;

				case 106414083:
					return ProductId;

				case 4152360413:
					return ProjectId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2421825855:
					return typeof(EntitlementQuery).GetProperty(nameof(EntitlementsData));

				case 1803493518:
					return typeof(EntitlementQuery).GetProperty(nameof(GroupNames));

				case 942751002:
					return typeof(EntitlementQuery).GetProperty(nameof(Platform));

				case 1654763342:
					return typeof(EntitlementQuery).GetProperty(nameof(EntitlementTag));

				case 106414083:
					return typeof(EntitlementQuery).GetProperty(nameof(ProductId));

				case 4152360413:
					return typeof(EntitlementQuery).GetProperty(nameof(ProjectId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
