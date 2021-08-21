///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class FakePhysicsData : 
		DataContainer
	{
		protected CtrRef<FakePhysicsData> m_ChildFakePhysics = new CtrRef<FakePhysicsData>();
		[ContainerField(Name: "ChildFakePhysics", Offset: 8, NameHash: 1652180525, Flags: 53)]
		public CtrRef<FakePhysicsData> ChildFakePhysics { get { return m_ChildFakePhysics; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(ChildFakePhysics), this, m_ChildFakePhysics, value)) m_ChildFakePhysics = value; } } // 0x8 (8)
		
		protected float m_StartSpeed = new float();
		[ContainerField(Name: "StartSpeed", Offset: 12, NameHash: 2753756066, Flags: 49469), LayoutImmutable, Blittable]
		public float StartSpeed { get { return m_StartSpeed; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(StartSpeed), this, m_StartSpeed, value)) m_StartSpeed = value; } } // 0xC (12)
		
		protected float m_GravityModifier = new float();
		[ContainerField(Name: "GravityModifier", Offset: 16, NameHash: 1597941524, Flags: 49469), LayoutImmutable, Blittable]
		public float GravityModifier { get { return m_GravityModifier; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(GravityModifier), this, m_GravityModifier, value)) m_GravityModifier = value; } } // 0x10 (16)
		
		protected float m_StartDampening = new float();
		[ContainerField(Name: "StartDampening", Offset: 20, NameHash: 3397890358, Flags: 49469), LayoutImmutable, Blittable]
		public float StartDampening { get { return m_StartDampening; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(StartDampening), this, m_StartDampening, value)) m_StartDampening = value; } } // 0x14 (20)
		
		protected float m_EndDampening = new float();
		[ContainerField(Name: "EndDampening", Offset: 24, NameHash: 1802636313, Flags: 49469), LayoutImmutable, Blittable]
		public float EndDampening { get { return m_EndDampening; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(EndDampening), this, m_EndDampening, value)) m_EndDampening = value; } } // 0x18 (24)
		
		protected float m_MinSpeed = new float();
		[ContainerField(Name: "MinSpeed", Offset: 28, NameHash: 3368183944, Flags: 49469), LayoutImmutable, Blittable]
		public float MinSpeed { get { return m_MinSpeed; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(MinSpeed), this, m_MinSpeed, value)) m_MinSpeed = value; } } // 0x1C (28)
		
		protected float m_MaxSpeed = new float();
		[ContainerField(Name: "MaxSpeed", Offset: 32, NameHash: 396228950, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0x20 (32)
		
		protected float m_Mass = new float();
		[ContainerField(Name: "Mass", Offset: 36, NameHash: 2088779625, Flags: 49469), LayoutImmutable, Blittable]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("FakePhysicsData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x24 (36)
		
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
