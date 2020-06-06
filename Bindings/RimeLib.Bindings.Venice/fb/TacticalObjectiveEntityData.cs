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
	public class TacticalObjectiveEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable]
		public string MissionSid { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string BriefingSidTeam1 { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string BriefingSidTeam2 { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float Team1Timer { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float Team2Timer { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1231602263:
					MissionSid = (string) p_Value;
					break;

				case 3340727469:
					BriefingSidTeam1 = (string) p_Value;
					break;

				case 3340727470:
					BriefingSidTeam2 = (string) p_Value;
					break;

				case 2082003598:
					Team1Timer = (float) p_Value;
					break;

				case 2125739053:
					Team2Timer = (float) p_Value;
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
				case 1231602263:
					return MissionSid;

				case 3340727469:
					return BriefingSidTeam1;

				case 3340727470:
					return BriefingSidTeam2;

				case 2082003598:
					return Team1Timer;

				case 2125739053:
					return Team2Timer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1231602263:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(MissionSid));

				case 3340727469:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(BriefingSidTeam1));

				case 3340727470:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(BriefingSidTeam2));

				case 2082003598:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(Team1Timer));

				case 2125739053:
					return typeof(TacticalObjectiveEntityData).GetProperty(nameof(Team2Timer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
