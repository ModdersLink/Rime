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
	public class EffectEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public RefArray<GameObjectData> Components { get; set; } = new RefArray<GameObjectData>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public uint MaxInstanceCount { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float CullDistance { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float StartDelay { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool HighEndPc { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool MediumPc { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool LowEndPc { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool ResetInstanceWhenStarted { get; set; } // 0x63 (99)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3391050425:
					Components = (RefArray<GameObjectData>) p_Value;
					break;

				case 3587631771:
					MaxInstanceCount = (uint) p_Value;
					break;

				case 1000432400:
					CullDistance = (float) p_Value;
					break;

				case 2731915920:
					StartDelay = (float) p_Value;
					break;

				case 47851991:
					HighEndPc = (bool) p_Value;
					break;

				case 773886027:
					MediumPc = (bool) p_Value;
					break;

				case 2485938765:
					LowEndPc = (bool) p_Value;
					break;

				case 1039558380:
					ResetInstanceWhenStarted = (bool) p_Value;
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
				case 3391050425:
					return Components;

				case 3587631771:
					return MaxInstanceCount;

				case 1000432400:
					return CullDistance;

				case 2731915920:
					return StartDelay;

				case 47851991:
					return HighEndPc;

				case 773886027:
					return MediumPc;

				case 2485938765:
					return LowEndPc;

				case 1039558380:
					return ResetInstanceWhenStarted;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3391050425:
					return typeof(EffectEntityData).GetProperty(nameof(Components));

				case 3587631771:
					return typeof(EffectEntityData).GetProperty(nameof(MaxInstanceCount));

				case 1000432400:
					return typeof(EffectEntityData).GetProperty(nameof(CullDistance));

				case 2731915920:
					return typeof(EffectEntityData).GetProperty(nameof(StartDelay));

				case 47851991:
					return typeof(EffectEntityData).GetProperty(nameof(HighEndPc));

				case 773886027:
					return typeof(EffectEntityData).GetProperty(nameof(MediumPc));

				case 2485938765:
					return typeof(EffectEntityData).GetProperty(nameof(LowEndPc));

				case 1039558380:
					return typeof(EffectEntityData).GetProperty(nameof(ResetInstanceWhenStarted));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
