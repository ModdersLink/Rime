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
	public class PreRoundEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int RoundMaxPlayerCount { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint RoundRestartCountdown { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public int RoundMinPlayerCount { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3644312963:
					RoundMaxPlayerCount = (int) p_Value;
					break;

				case 1048503553:
					RoundRestartCountdown = (uint) p_Value;
					break;

				case 1656551901:
					RoundMinPlayerCount = (int) p_Value;
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
				case 3644312963:
					return RoundMaxPlayerCount;

				case 1048503553:
					return RoundRestartCountdown;

				case 1656551901:
					return RoundMinPlayerCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3644312963:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundMaxPlayerCount));

				case 1048503553:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundRestartCountdown));

				case 1656551901:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundMinPlayerCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
