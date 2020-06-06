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
	public class PositionEvaluationConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float OwnRandomPositionsRadius { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LeaderRandomPositionsRadius { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 40735674:
					OwnRandomPositionsRadius = (float) p_Value;
					break;

				case 1408843063:
					LeaderRandomPositionsRadius = (float) p_Value;
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
				case 40735674:
					return OwnRandomPositionsRadius;

				case 1408843063:
					return LeaderRandomPositionsRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 40735674:
					return typeof(PositionEvaluationConstantData).GetProperty(nameof(OwnRandomPositionsRadius));

				case 1408843063:
					return typeof(PositionEvaluationConstantData).GetProperty(nameof(LeaderRandomPositionsRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
