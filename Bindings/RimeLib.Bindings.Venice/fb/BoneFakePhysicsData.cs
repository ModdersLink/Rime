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
	public class BoneFakePhysicsData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<FakePhysicsData> FakePhysics { get; set; } = new CtrRef<FakePhysicsData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string BoneName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int BoneId { get; set; } // 0x10 (16)
		
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
