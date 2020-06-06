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
	public class SpawnRateData : 
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SpawnRate { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TrailSegmentLength { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool DistributeOverTime { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool DistributeOverDistance { get; set; } // 0x39 (57)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2317161148:
					SpawnRate = (float) p_Value;
					break;

				case 3461940440:
					TrailSegmentLength = (float) p_Value;
					break;

				case 2990510569:
					DistributeOverTime = (bool) p_Value;
					break;

				case 2314066943:
					DistributeOverDistance = (bool) p_Value;
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
				case 2317161148:
					return SpawnRate;

				case 3461940440:
					return TrailSegmentLength;

				case 2990510569:
					return DistributeOverTime;

				case 2314066943:
					return DistributeOverDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2317161148:
					return typeof(SpawnRateData).GetProperty(nameof(SpawnRate));

				case 3461940440:
					return typeof(SpawnRateData).GetProperty(nameof(TrailSegmentLength));

				case 2990510569:
					return typeof(SpawnRateData).GetProperty(nameof(DistributeOverTime));

				case 2314066943:
					return typeof(SpawnRateData).GetProperty(nameof(DistributeOverDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
