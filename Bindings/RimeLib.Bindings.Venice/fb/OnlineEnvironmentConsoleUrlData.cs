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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class OnlineEnvironmentConsoleUrlData : FrostbiteContainer
	{
		[ContainerField(Name: "Platform", Offset: 0, NameHash: 942751002, Flags: 137)]
		public GamePlatform Platform { get; set; } = new GamePlatform(); // 0x0 (0)
		
		[ContainerField(Name: "Url", Offset: 4, NameHash: 193455022, Flags: 41)]
		public OnlineEnvironmentUrl Url { get; set; } = new OnlineEnvironmentUrl(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 942751002:
						Platform = (GamePlatform) Enum.ToObject(typeof(GamePlatform), p_Value);
					break;

				case 193455022:
					Url = (OnlineEnvironmentUrl) p_Value;
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

				case 193455022:
					return Url;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 942751002:
					return typeof(OnlineEnvironmentConsoleUrlData).GetProperty(nameof(Platform));

				case 193455022:
					return typeof(OnlineEnvironmentConsoleUrlData).GetProperty(nameof(Url));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
