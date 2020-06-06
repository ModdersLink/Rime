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
	public class FakePhysicsData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<FakePhysicsData> ChildFakePhysics { get; set; } = new CtrRef<FakePhysicsData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StartSpeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float StartDampening { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float EndDampening { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinSpeed { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1652180525:
					ChildFakePhysics = (CtrRef<FakePhysicsData>) p_Value;
					break;

				case 2753756066:
					StartSpeed = (float) p_Value;
					break;

				case 1597941524:
					GravityModifier = (float) p_Value;
					break;

				case 3397890358:
					StartDampening = (float) p_Value;
					break;

				case 1802636313:
					EndDampening = (float) p_Value;
					break;

				case 3368183944:
					MinSpeed = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 2088779625:
					Mass = (float) p_Value;
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
				case 1652180525:
					return ChildFakePhysics;

				case 2753756066:
					return StartSpeed;

				case 1597941524:
					return GravityModifier;

				case 3397890358:
					return StartDampening;

				case 1802636313:
					return EndDampening;

				case 3368183944:
					return MinSpeed;

				case 396228950:
					return MaxSpeed;

				case 2088779625:
					return Mass;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1652180525:
					return typeof(FakePhysicsData).GetProperty(nameof(ChildFakePhysics));

				case 2753756066:
					return typeof(FakePhysicsData).GetProperty(nameof(StartSpeed));

				case 1597941524:
					return typeof(FakePhysicsData).GetProperty(nameof(GravityModifier));

				case 3397890358:
					return typeof(FakePhysicsData).GetProperty(nameof(StartDampening));

				case 1802636313:
					return typeof(FakePhysicsData).GetProperty(nameof(EndDampening));

				case 3368183944:
					return typeof(FakePhysicsData).GetProperty(nameof(MinSpeed));

				case 396228950:
					return typeof(FakePhysicsData).GetProperty(nameof(MaxSpeed));

				case 2088779625:
					return typeof(FakePhysicsData).GetProperty(nameof(Mass));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
