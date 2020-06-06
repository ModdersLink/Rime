///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class FriendlyFireEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<TeamId> Teams { get; set; } = new List<TeamId>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float EnemyCommitmentAllocation { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FriendlyCommitmentAllocation { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxCommitment { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FailureThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DecayRate { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 227737643:
					if (p_Value.GetType() == typeof (List<uint>))
						Teams = ((List<uint>) p_Value).Select(x => (TeamId) Enum.ToObject(typeof(TeamId), x)).ToList();
					else
						Teams = (List<TeamId>) p_Value;
					break;

				case 2175171884:
					EnemyCommitmentAllocation = (float) p_Value;
					break;

				case 4158058161:
					FriendlyCommitmentAllocation = (float) p_Value;
					break;

				case 2794924786:
					MaxCommitment = (float) p_Value;
					break;

				case 280940370:
					FailureThreshold = (float) p_Value;
					break;

				case 3274236317:
					DecayRate = (float) p_Value;
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
				case 227737643:
					return Teams;

				case 2175171884:
					return EnemyCommitmentAllocation;

				case 4158058161:
					return FriendlyCommitmentAllocation;

				case 2794924786:
					return MaxCommitment;

				case 280940370:
					return FailureThreshold;

				case 3274236317:
					return DecayRate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 227737643:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(Teams));

				case 2175171884:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(EnemyCommitmentAllocation));

				case 4158058161:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(FriendlyCommitmentAllocation));

				case 2794924786:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(MaxCommitment));

				case 280940370:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(FailureThreshold));

				case 3274236317:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(DecayRate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
