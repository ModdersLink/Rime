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
	public class BFAISettingsData : 
		AISettingsData
	{
		[ContainerField(80)]
		public CtrRef<MovementConstantData> MovementConstants { get; set; } = new CtrRef<MovementConstantData>(); // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<TurretControlConstantData> TurretControlConstants { get; set; } = new CtrRef<TurretControlConstantData>(); // 0x54 (84)
		
		[ContainerField(88)]
		public CtrRef<SearchAndDestroyConstantData> SearchAndDestroyConstants { get; set; } = new CtrRef<SearchAndDestroyConstantData>(); // 0x58 (88)
		
		[ContainerField(92)]
		public CtrRef<FollowConstantData> FollowConstants { get; set; } = new CtrRef<FollowConstantData>(); // 0x5C (92)
		
		[ContainerField(96)]
		public CtrRef<CombatConstantData> CombatConstants { get; set; } = new CtrRef<CombatConstantData>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4256858251:
					MovementConstants = (CtrRef<MovementConstantData>) p_Value;
					break;

				case 1803214367:
					TurretControlConstants = (CtrRef<TurretControlConstantData>) p_Value;
					break;

				case 3710618575:
					SearchAndDestroyConstants = (CtrRef<SearchAndDestroyConstantData>) p_Value;
					break;

				case 3864754617:
					FollowConstants = (CtrRef<FollowConstantData>) p_Value;
					break;

				case 2495160158:
					CombatConstants = (CtrRef<CombatConstantData>) p_Value;
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
				case 4256858251:
					return MovementConstants;

				case 1803214367:
					return TurretControlConstants;

				case 3710618575:
					return SearchAndDestroyConstants;

				case 3864754617:
					return FollowConstants;

				case 2495160158:
					return CombatConstants;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4256858251:
					return typeof(BFAISettingsData).GetProperty(nameof(MovementConstants));

				case 1803214367:
					return typeof(BFAISettingsData).GetProperty(nameof(TurretControlConstants));

				case 3710618575:
					return typeof(BFAISettingsData).GetProperty(nameof(SearchAndDestroyConstants));

				case 3864754617:
					return typeof(BFAISettingsData).GetProperty(nameof(FollowConstants));

				case 2495160158:
					return typeof(BFAISettingsData).GetProperty(nameof(CombatConstants));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
