///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VectorShapeData : 
		BaseShapeData
	{
		[ContainerField(12)]
		public List<Vec3> Points { get; set; } = new List<Vec3>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<Vec3> Normals { get; set; } = new List<Vec3>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Tension { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool IsClosed { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool AllowRoll { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3383606106:
					Points = (List<Vec3>) p_Value;
					break;

				case 3102907301:
					Normals = (List<Vec3>) p_Value;
					break;

				case 3196074177:
					Tension = (float) p_Value;
					break;

				case 1070153421:
					IsClosed = (bool) p_Value;
					break;

				case 2314066145:
					AllowRoll = (bool) p_Value;
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
				case 3383606106:
					return Points;

				case 3102907301:
					return Normals;

				case 3196074177:
					return Tension;

				case 1070153421:
					return IsClosed;

				case 2314066145:
					return AllowRoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3383606106:
					return typeof(VectorShapeData).GetProperty(nameof(Points));

				case 3102907301:
					return typeof(VectorShapeData).GetProperty(nameof(Normals));

				case 3196074177:
					return typeof(VectorShapeData).GetProperty(nameof(Tension));

				case 1070153421:
					return typeof(VectorShapeData).GetProperty(nameof(IsClosed));

				case 2314066145:
					return typeof(VectorShapeData).GetProperty(nameof(AllowRoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
