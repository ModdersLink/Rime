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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class VeniceGameplayLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected bool m_AllowParachuteFromMobileSpawnpoint = new bool();
		[ContainerField(Name: "AllowParachuteFromMobileSpawnpoint", Offset: 8, NameHash: 589682896, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowParachuteFromMobileSpawnpoint { get { return m_AllowParachuteFromMobileSpawnpoint; } set { if (OnPropertyChanging("VeniceGameplayLevelDescriptionComponent." + nameof(AllowParachuteFromMobileSpawnpoint), this, m_AllowParachuteFromMobileSpawnpoint, value)) m_AllowParachuteFromMobileSpawnpoint = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 589682896:
					AllowParachuteFromMobileSpawnpoint = (bool) p_Value;
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
				case 589682896:
					return AllowParachuteFromMobileSpawnpoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 589682896:
					return typeof(VeniceGameplayLevelDescriptionComponent).GetProperty(nameof(AllowParachuteFromMobileSpawnpoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
