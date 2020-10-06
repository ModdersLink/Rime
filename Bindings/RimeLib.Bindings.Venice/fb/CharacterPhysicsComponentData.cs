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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class CharacterPhysicsComponentData : 
		ComponentData
	{
		protected CtrRef<CharacterPhysicsData> m_CharacterPhysics = new CtrRef<CharacterPhysicsData>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(4032988407), ContainerCtrRef]
		public CtrRef<CharacterPhysicsData> CharacterPhysics { get { return m_CharacterPhysics; } set { if (OnPropertyChanging("CharacterPhysicsComponentData." + nameof(CharacterPhysics), this, m_CharacterPhysics, value)) m_CharacterPhysics = value; } } // 0x60 (96)
		
		protected bool m_EnableCollisionOnSpawn = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1861797248)]
		public bool EnableCollisionOnSpawn { get { return m_EnableCollisionOnSpawn; } set { if (OnPropertyChanging("CharacterPhysicsComponentData." + nameof(EnableCollisionOnSpawn), this, m_EnableCollisionOnSpawn, value)) m_EnableCollisionOnSpawn = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4032988407:
					CharacterPhysics = (CtrRef<CharacterPhysicsData>) p_Value;
					break;

				case 1861797248:
					EnableCollisionOnSpawn = (bool) p_Value;
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
				case 4032988407:
					return CharacterPhysics;

				case 1861797248:
					return EnableCollisionOnSpawn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4032988407:
					return typeof(CharacterPhysicsComponentData).GetProperty(nameof(CharacterPhysics));

				case 1861797248:
					return typeof(CharacterPhysicsComponentData).GetProperty(nameof(EnableCollisionOnSpawn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
