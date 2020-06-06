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
	public class SpottingTargetComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ActiveSpottedTime { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float PassiveSpottedTime { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ActiveSpottedTimeMultiplier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float PassiveSpottedTimeMultiplier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float SpotOnFireMultiplier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool TargetBoundingBoxCenter { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 748599697:
					ActiveSpottedTime = (float) p_Value;
					break;

				case 2532328150:
					PassiveSpottedTime = (float) p_Value;
					break;

				case 1518946778:
					ActiveSpottedTimeMultiplier = (float) p_Value;
					break;

				case 996451229:
					PassiveSpottedTimeMultiplier = (float) p_Value;
					break;

				case 3169810191:
					SpotOnFireMultiplier = (float) p_Value;
					break;

				case 2640665496:
					TargetBoundingBoxCenter = (bool) p_Value;
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
				case 748599697:
					return ActiveSpottedTime;

				case 2532328150:
					return PassiveSpottedTime;

				case 1518946778:
					return ActiveSpottedTimeMultiplier;

				case 996451229:
					return PassiveSpottedTimeMultiplier;

				case 3169810191:
					return SpotOnFireMultiplier;

				case 2640665496:
					return TargetBoundingBoxCenter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 748599697:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(ActiveSpottedTime));

				case 2532328150:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(PassiveSpottedTime));

				case 1518946778:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(ActiveSpottedTimeMultiplier));

				case 996451229:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(PassiveSpottedTimeMultiplier));

				case 3169810191:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(SpotOnFireMultiplier));

				case 2640665496:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(TargetBoundingBoxCenter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
