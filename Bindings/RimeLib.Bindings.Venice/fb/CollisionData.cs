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
	public class CollisionData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<ValueAtX> DamageAtVerticalVelocity { get; set; } = new List<ValueAtX>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<ValueAtX> DamageAtHorizVelocity { get; set; } = new List<ValueAtX>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 670681886:
					DamageAtVerticalVelocity = (List<ValueAtX>) p_Value;
					break;

				case 3966259722:
					DamageAtHorizVelocity = (List<ValueAtX>) p_Value;
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
				case 670681886:
					return DamageAtVerticalVelocity;

				case 3966259722:
					return DamageAtHorizVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 670681886:
					return typeof(CollisionData).GetProperty(nameof(DamageAtVerticalVelocity));

				case 3966259722:
					return typeof(CollisionData).GetProperty(nameof(DamageAtHorizVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
