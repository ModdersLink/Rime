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
	public class GameObjectData : 
		GameDataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public ushort IndexInBlueprint { get; set; } // 0x8 (8)
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public sbyte IsEventConnectionTarget { get; set; } // 0xA (10)
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public sbyte IsPropertyConnectionTarget { get; set; } // 0xB (11)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1440948467:
					IndexInBlueprint = (ushort) p_Value;
					break;

				case 443195188:
					IsEventConnectionTarget = (sbyte) p_Value;
					break;

				case 3243963839:
					IsPropertyConnectionTarget = (sbyte) p_Value;
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
				case 1440948467:
					return IndexInBlueprint;

				case 443195188:
					return IsEventConnectionTarget;

				case 3243963839:
					return IsPropertyConnectionTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1440948467:
					return typeof(GameObjectData).GetProperty(nameof(IndexInBlueprint));

				case 443195188:
					return typeof(GameObjectData).GetProperty(nameof(IsEventConnectionTarget));

				case 3243963839:
					return typeof(GameObjectData).GetProperty(nameof(IsPropertyConnectionTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
