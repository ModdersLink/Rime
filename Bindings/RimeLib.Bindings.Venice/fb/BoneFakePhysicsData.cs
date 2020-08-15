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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class BoneFakePhysicsData : 
		DataContainer
	{
		protected CtrRef<FakePhysicsData> m_FakePhysics = new CtrRef<FakePhysicsData>();
		[ContainerField(8), ContainerFieldNameHash(3614234055)]
		public CtrRef<FakePhysicsData> FakePhysics { get { return m_FakePhysics; } set { if (OnPropertyChanging("BoneFakePhysicsData." + nameof(FakePhysics), this, m_FakePhysics, value)) m_FakePhysics = value; } } // 0x8 (8)
		
		protected string m_BoneName = new string();
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(1590647844)]
		public string BoneName { get { return m_BoneName; } set { if (OnPropertyChanging("BoneFakePhysicsData." + nameof(BoneName), this, m_BoneName, value)) m_BoneName = value; } } // 0xC (12)
		
		protected int m_BoneId = new int();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2679406126)]
		public int BoneId { get { return m_BoneId; } set { if (OnPropertyChanging("BoneFakePhysicsData." + nameof(BoneId), this, m_BoneId, value)) m_BoneId = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3614234055:
					FakePhysics = (CtrRef<FakePhysicsData>) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
					break;

				case 2679406126:
					BoneId = (int) p_Value;
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
				case 3614234055:
					return FakePhysics;

				case 1590647844:
					return BoneName;

				case 2679406126:
					return BoneId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3614234055:
					return typeof(BoneFakePhysicsData).GetProperty(nameof(FakePhysics));

				case 1590647844:
					return typeof(BoneFakePhysicsData).GetProperty(nameof(BoneName));

				case 2679406126:
					return typeof(BoneFakePhysicsData).GetProperty(nameof(BoneId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
