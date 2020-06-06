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
	public class ControllableEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LowHealthThreshold { get; set; } // 0x70 (112)
		
		[ContainerField(116)]
		public TeamId DefaultTeam { get; set; } = new TeamId(); // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool ResetTeamOnLastPlayerExits { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool FakeImmortal { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UsePrediction { get; set; } // 0x7E (126)
		
		[ContainerField(127), LayoutImmutable, Blittable]
		public bool Immortal { get; set; } // 0x7F (127)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool ForceForegroundRendering { get; set; } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1532389018:
					LowHealthThreshold = (float) p_Value;
					break;

				case 2015081331:
					DefaultTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 3958982630:
					ResetTeamOnLastPlayerExits = (bool) p_Value;
					break;

				case 875726273:
					FakeImmortal = (bool) p_Value;
					break;

				case 1407937619:
					UsePrediction = (bool) p_Value;
					break;

				case 922982664:
					Immortal = (bool) p_Value;
					break;

				case 251630665:
					ForceForegroundRendering = (bool) p_Value;
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
				case 1532389018:
					return LowHealthThreshold;

				case 2015081331:
					return DefaultTeam;

				case 161392100:
					return MaterialPair;

				case 3958982630:
					return ResetTeamOnLastPlayerExits;

				case 875726273:
					return FakeImmortal;

				case 1407937619:
					return UsePrediction;

				case 922982664:
					return Immortal;

				case 251630665:
					return ForceForegroundRendering;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1532389018:
					return typeof(ControllableEntityData).GetProperty(nameof(LowHealthThreshold));

				case 2015081331:
					return typeof(ControllableEntityData).GetProperty(nameof(DefaultTeam));

				case 161392100:
					return typeof(ControllableEntityData).GetProperty(nameof(MaterialPair));

				case 3958982630:
					return typeof(ControllableEntityData).GetProperty(nameof(ResetTeamOnLastPlayerExits));

				case 875726273:
					return typeof(ControllableEntityData).GetProperty(nameof(FakeImmortal));

				case 1407937619:
					return typeof(ControllableEntityData).GetProperty(nameof(UsePrediction));

				case 922982664:
					return typeof(ControllableEntityData).GetProperty(nameof(Immortal));

				case 251630665:
					return typeof(ControllableEntityData).GetProperty(nameof(ForceForegroundRendering));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
