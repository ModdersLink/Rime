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
	public class SphereCollisionData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ExtraRadius { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CounterNormalBrakeForceMod { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3555352615:
					ExtraRadius = (float) p_Value;
					break;

				case 2290320390:
					CounterNormalBrakeForceMod = (float) p_Value;
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
				case 3555352615:
					return ExtraRadius;

				case 2290320390:
					return CounterNormalBrakeForceMod;

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
				case 3555352615:
					return typeof(SphereCollisionData).GetProperty(nameof(ExtraRadius));

				case 2290320390:
					return typeof(SphereCollisionData).GetProperty(nameof(CounterNormalBrakeForceMod));

				case 2662400:
					return typeof(SphereCollisionData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
