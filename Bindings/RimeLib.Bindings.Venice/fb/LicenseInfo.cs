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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class LicenseInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "StagingPlatform", Offset: 4, NameHash: 1395887771, Flags: 137)]
		public GamePlatform StagingPlatform { get; set; } = new GamePlatform(); // 0x4 (4)
		
		[ContainerField(Name: "AllowStaging", Offset: 8, NameHash: 1112770237, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowStaging { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ClientOnly", Offset: 9, NameHash: 892252904, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClientOnly { get; set; } // 0x9 (9)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 1395887771:
						StagingPlatform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 1112770237:
					AllowStaging = (bool) p_Value;
					break;

				case 892252904:
					ClientOnly = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 1395887771:
					return StagingPlatform;

				case 1112770237:
					return AllowStaging;

				case 892252904:
					return ClientOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(LicenseInfo).GetProperty(nameof(Name));

				case 1395887771:
					return typeof(LicenseInfo).GetProperty(nameof(StagingPlatform));

				case 1112770237:
					return typeof(LicenseInfo).GetProperty(nameof(AllowStaging));

				case 892252904:
					return typeof(LicenseInfo).GetProperty(nameof(ClientOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
