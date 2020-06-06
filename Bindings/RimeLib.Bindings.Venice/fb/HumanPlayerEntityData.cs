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
	public class HumanPlayerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PlayerKilledDelay { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string LastManStandingSid { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 277093856:
					PlayerKilledDelay = (float) p_Value;
					break;

				case 1039359551:
					LastManStandingSid = (string) p_Value;
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
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
				case 277093856:
					return PlayerKilledDelay;

				case 1039359551:
					return LastManStandingSid;

				case 1925139498:
					return DisplayTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 277093856:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(PlayerKilledDelay));

				case 1039359551:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(LastManStandingSid));

				case 1925139498:
					return typeof(HumanPlayerEntityData).GetProperty(nameof(DisplayTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
