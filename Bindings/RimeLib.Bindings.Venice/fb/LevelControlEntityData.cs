///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LevelControlEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string LevelToLoad { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool RollCredits { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 932165454:
					LevelToLoad = (string) p_Value;
					break;

				case 3139123878:
					RollCredits = (bool) p_Value;
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
				case 932165454:
					return LevelToLoad;

				case 3139123878:
					return RollCredits;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 932165454:
					return typeof(LevelControlEntityData).GetProperty(nameof(LevelToLoad));

				case 3139123878:
					return typeof(LevelControlEntityData).GetProperty(nameof(RollCredits));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
