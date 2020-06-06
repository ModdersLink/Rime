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
	public class AIProximityReactionsComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AIProximityReactionsBinding Binding { get; set; } = new AIProximityReactionsBinding(); // 0x60 (96)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float MinExplosionImpulseForce { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float MaxExplosionLookDistance { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float FireReactionDistance { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (AIProximityReactionsBinding) p_Value;
					break;

				case 1140171772:
					MinExplosionImpulseForce = (float) p_Value;
					break;

				case 322238752:
					MaxExplosionLookDistance = (float) p_Value;
					break;

				case 2123733591:
					FireReactionDistance = (float) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 2590060228:
					return Binding;

				case 1140171772:
					return MinExplosionImpulseForce;

				case 322238752:
					return MaxExplosionLookDistance;

				case 2123733591:
					return FireReactionDistance;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(Binding));

				case 1140171772:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(MinExplosionImpulseForce));

				case 322238752:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(MaxExplosionLookDistance));

				case 2123733591:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(FireReactionDistance));

				case 2662400:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
