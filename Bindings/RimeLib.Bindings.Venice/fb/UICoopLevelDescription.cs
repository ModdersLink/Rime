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
	public class UICoopLevelDescription : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable]
		public string Debriefing { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int DevTime { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public List<string> UnlockedByLevels { get; set; } = new List<string>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1664834078:
					Debriefing = (string) p_Value;
					break;

				case 4015961031:
					DevTime = (int) p_Value;
					break;

				case 2749335882:
					UnlockedByLevels = (List<string>) p_Value;
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
				case 1664834078:
					return Debriefing;

				case 4015961031:
					return DevTime;

				case 2749335882:
					return UnlockedByLevels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1664834078:
					return typeof(UICoopLevelDescription).GetProperty(nameof(Debriefing));

				case 4015961031:
					return typeof(UICoopLevelDescription).GetProperty(nameof(DevTime));

				case 2749335882:
					return typeof(UICoopLevelDescription).GetProperty(nameof(UnlockedByLevels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
