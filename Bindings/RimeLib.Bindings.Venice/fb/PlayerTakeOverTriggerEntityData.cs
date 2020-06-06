///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PlayerTakeOverTriggerEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float TimeToLoseControl { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3830029753:
					TimeToLoseControl = (float) p_Value;
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
				case 3220374101:
					return TeamId;

				case 3830029753:
					return TimeToLoseControl;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3220374101:
					return typeof(PlayerTakeOverTriggerEntityData).GetProperty(nameof(TeamId));

				case 3830029753:
					return typeof(PlayerTakeOverTriggerEntityData).GetProperty(nameof(TimeToLoseControl));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
