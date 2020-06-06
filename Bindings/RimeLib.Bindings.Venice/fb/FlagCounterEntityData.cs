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
	public class FlagCounterEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float EnemyFlagProgress { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float RoundTime { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public int ObjectiveFlagCount { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool VisibleInMinimap { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 1874843822:
					EnemyFlagProgress = (float) p_Value;
					break;

				case 4171794130:
					RoundTime = (float) p_Value;
					break;

				case 952118181:
					ObjectiveFlagCount = (int) p_Value;
					break;

				case 2256980243:
					VisibleInMinimap = (bool) p_Value;
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

				case 1874843822:
					return EnemyFlagProgress;

				case 4171794130:
					return RoundTime;

				case 952118181:
					return ObjectiveFlagCount;

				case 2256980243:
					return VisibleInMinimap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3220374101:
					return typeof(FlagCounterEntityData).GetProperty(nameof(TeamId));

				case 1874843822:
					return typeof(FlagCounterEntityData).GetProperty(nameof(EnemyFlagProgress));

				case 4171794130:
					return typeof(FlagCounterEntityData).GetProperty(nameof(RoundTime));

				case 952118181:
					return typeof(FlagCounterEntityData).GetProperty(nameof(ObjectiveFlagCount));

				case 2256980243:
					return typeof(FlagCounterEntityData).GetProperty(nameof(VisibleInMinimap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
