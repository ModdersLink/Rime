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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 28)]
	public class OnlineProviderConfiguration : FrostbiteContainer
	{
		[ContainerField(Name: "Platform", Offset: 0, NameHash: 942751002, Flags: 137)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(Name: "Client", Offset: 4, NameHash: 2721713788, Flags: 16509), LayoutImmutable]
		public string Client { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ServiceName", Offset: 8, NameHash: 2487476607, Flags: 16509), LayoutImmutable]
		public string ServiceName { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "SKU", Offset: 12, NameHash: 193467592, Flags: 16509), LayoutImmutable]
		public string SKU { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Version", Offset: 16, NameHash: 747123679, Flags: 16509), LayoutImmutable]
		public string Version { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "ServerSocketPacketSize", Offset: 20, NameHash: 2343662152, Flags: 49421), LayoutImmutable, Blittable]
		public uint ServerSocketPacketSize { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "IsServer", Offset: 24, NameHash: 452268730, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsServer { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 2721713788:
					Client = (string) p_Value;
					break;

				case 2487476607:
					ServiceName = (string) p_Value;
					break;

				case 193467592:
					SKU = (string) p_Value;
					break;

				case 747123679:
					Version = (string) p_Value;
					break;

				case 2343662152:
					ServerSocketPacketSize = (uint) p_Value;
					break;

				case 452268730:
					IsServer = (bool) p_Value;
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
				case 942751002:
					return Platform;

				case 2721713788:
					return Client;

				case 2487476607:
					return ServiceName;

				case 193467592:
					return SKU;

				case 747123679:
					return Version;

				case 2343662152:
					return ServerSocketPacketSize;

				case 452268730:
					return IsServer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(Platform));

				case 2721713788:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(Client));

				case 2487476607:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(ServiceName));

				case 193467592:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(SKU));

				case 747123679:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(Version));

				case 2343662152:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(ServerSocketPacketSize));

				case 452268730:
					return typeof(OnlineProviderConfiguration).GetProperty(nameof(IsServer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
