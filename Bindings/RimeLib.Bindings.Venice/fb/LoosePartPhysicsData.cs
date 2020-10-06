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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class LoosePartPhysicsData : 
		DataContainer
	{
		protected CtrRef<FakePhysicsData> m_FakePhysics = new CtrRef<FakePhysicsData>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(3614234055), ContainerCtrRef]
		public CtrRef<FakePhysicsData> FakePhysics { get { return m_FakePhysics; } set { if (OnPropertyChanging("LoosePartPhysicsData." + nameof(FakePhysics), this, m_FakePhysics, value)) m_FakePhysics = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3614234055:
					FakePhysics = (CtrRef<FakePhysicsData>) p_Value;
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3614234055:
					return typeof(LoosePartPhysicsData).GetProperty(nameof(FakePhysics));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
