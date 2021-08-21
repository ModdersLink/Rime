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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VeniceMatchmakingLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected string m_Mod = string.Empty;
		[ContainerField(Name: "Mod", Offset: 8, NameHash: 193446659, Flags: 16509), LayoutImmutable]
		public string Mod { get { return m_Mod; } set { if (OnPropertyChanging("VeniceMatchmakingLevelDescriptionComponent." + nameof(Mod), this, m_Mod, value)) m_Mod = value; } } // 0x8 (8)
		
		protected List<string> m_Licenses = new List<string>();
		[ContainerField(Name: "Licenses", Offset: 12, NameHash: 2259172461, Flags: 65)]
		public List<string> Licenses { get { return m_Licenses; } set { if (OnPropertyChanging("VeniceMatchmakingLevelDescriptionComponent." + nameof(Licenses), this, m_Licenses, value)) m_Licenses = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446659:
					Mod = (string) p_Value;
					break;

				case 2259172461:
					Licenses = (List<string>) p_Value;
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
				case 193446659:
					return Mod;

				case 2259172461:
					return Licenses;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193446659:
					return typeof(VeniceMatchmakingLevelDescriptionComponent).GetProperty(nameof(Mod));

				case 2259172461:
					return typeof(VeniceMatchmakingLevelDescriptionComponent).GetProperty(nameof(Licenses));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
