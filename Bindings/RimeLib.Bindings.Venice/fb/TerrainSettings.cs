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
	public class TerrainSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint HeightQueryCacheSize { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ModifiersCapacity { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint IntersectingModifiersMax { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ModifierDepthFactor { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ModifierSlopeMax { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool ModifiersEnable { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 360991385:
					HeightQueryCacheSize = (uint) p_Value;
					break;

				case 3948255029:
					ModifiersCapacity = (uint) p_Value;
					break;

				case 3775873328:
					IntersectingModifiersMax = (uint) p_Value;
					break;

				case 2305338610:
					ModifierDepthFactor = (float) p_Value;
					break;

				case 2295593955:
					ModifierSlopeMax = (float) p_Value;
					break;

				case 3614191008:
					ModifiersEnable = (bool) p_Value;
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
				case 360991385:
					return HeightQueryCacheSize;

				case 3948255029:
					return ModifiersCapacity;

				case 3775873328:
					return IntersectingModifiersMax;

				case 2305338610:
					return ModifierDepthFactor;

				case 2295593955:
					return ModifierSlopeMax;

				case 3614191008:
					return ModifiersEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 360991385:
					return typeof(TerrainSettings).GetProperty(nameof(HeightQueryCacheSize));

				case 3948255029:
					return typeof(TerrainSettings).GetProperty(nameof(ModifiersCapacity));

				case 3775873328:
					return typeof(TerrainSettings).GetProperty(nameof(IntersectingModifiersMax));

				case 2305338610:
					return typeof(TerrainSettings).GetProperty(nameof(ModifierDepthFactor));

				case 2295593955:
					return typeof(TerrainSettings).GetProperty(nameof(ModifierSlopeMax));

				case 3614191008:
					return typeof(TerrainSettings).GetProperty(nameof(ModifiersEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
