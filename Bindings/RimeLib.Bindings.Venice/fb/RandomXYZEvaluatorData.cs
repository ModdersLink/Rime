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
	public class RandomXYZEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxX { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MinX { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxY { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinY { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxZ { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MinZ { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088779177:
					MaxX = (float) p_Value;
					break;

				case 2088770807:
					MinX = (float) p_Value;
					break;

				case 2088779176:
					MaxY = (float) p_Value;
					break;

				case 2088770806:
					MinY = (float) p_Value;
					break;

				case 2088779179:
					MaxZ = (float) p_Value;
					break;

				case 2088770805:
					MinZ = (float) p_Value;
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
				case 2088779177:
					return MaxX;

				case 2088770807:
					return MinX;

				case 2088779176:
					return MaxY;

				case 2088770806:
					return MinY;

				case 2088779179:
					return MaxZ;

				case 2088770805:
					return MinZ;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088779177:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxX));

				case 2088770807:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinX));

				case 2088779176:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxY));

				case 2088770806:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinY));

				case 2088779179:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxZ));

				case 2088770805:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinZ));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
