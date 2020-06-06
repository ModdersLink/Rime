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
	public class RigidBodyConstraintData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public CtrRef<RigidBodyData> ParentBody { get; set; } = new CtrRef<RigidBodyData>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float BreakThreshold { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool IsBreakable { get; set; } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 2813534665:
					ParentBody = (CtrRef<RigidBodyData>) p_Value;
					break;

				case 869561325:
					BreakThreshold = (float) p_Value;
					break;

				case 3764480426:
					IsBreakable = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 2813534665:
					return ParentBody;

				case 869561325:
					return BreakThreshold;

				case 3764480426:
					return IsBreakable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(Transform));

				case 2813534665:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(ParentBody));

				case 869561325:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(BreakThreshold));

				case 3764480426:
					return typeof(RigidBodyConstraintData).GetProperty(nameof(IsBreakable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
