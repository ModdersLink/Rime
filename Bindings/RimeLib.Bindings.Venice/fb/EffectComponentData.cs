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
	public class EffectComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float EmitterParameter1 { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float EmitterParameter3 { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float EmitterParameter2 { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool SnapToWaterSurface { get; set; } // 0x71 (113)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2332983090:
					Effect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3454545451:
					EmitterParameter1 = (float) p_Value;
					break;

				case 3454545449:
					EmitterParameter3 = (float) p_Value;
					break;

				case 3454545448:
					EmitterParameter2 = (float) p_Value;
					break;

				case 792615882:
					AutoStart = (bool) p_Value;
					break;

				case 2958537010:
					SnapToWaterSurface = (bool) p_Value;
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
				case 2332983090:
					return Effect;

				case 3454545451:
					return EmitterParameter1;

				case 3454545449:
					return EmitterParameter3;

				case 3454545448:
					return EmitterParameter2;

				case 792615882:
					return AutoStart;

				case 2958537010:
					return SnapToWaterSurface;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2332983090:
					return typeof(EffectComponentData).GetProperty(nameof(Effect));

				case 3454545451:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter1));

				case 3454545449:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter3));

				case 3454545448:
					return typeof(EffectComponentData).GetProperty(nameof(EmitterParameter2));

				case 792615882:
					return typeof(EffectComponentData).GetProperty(nameof(AutoStart));

				case 2958537010:
					return typeof(EffectComponentData).GetProperty(nameof(SnapToWaterSurface));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
