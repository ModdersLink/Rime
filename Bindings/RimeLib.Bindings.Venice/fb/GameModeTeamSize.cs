///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GameModeTeamSize : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint PlayerCount { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint SquadSize { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4110176597:
					PlayerCount = (uint) p_Value;
					break;

				case 1279632114:
					SquadSize = (uint) p_Value;
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
				case 4110176597:
					return PlayerCount;

				case 1279632114:
					return SquadSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4110176597:
					return typeof(GameModeTeamSize).GetProperty(nameof(PlayerCount));

				case 1279632114:
					return typeof(GameModeTeamSize).GetProperty(nameof(SquadSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
