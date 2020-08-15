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
	public class CharacterAnimationSpaceEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("CharacterAnimationSpaceEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected AntRef m_SpacePositionGS = new AntRef();
		[ContainerField(16), ContainerFieldNameHash(2185021708)]
		public AntRef SpacePositionGS { get { return m_SpacePositionGS; } set { if (OnPropertyChanging("CharacterAnimationSpaceEntityData." + nameof(SpacePositionGS), this, m_SpacePositionGS, value)) m_SpacePositionGS = value; } } // 0x10 (16)
		
		protected AntRef m_SpaceRotationGS = new AntRef();
		[ContainerField(20), ContainerFieldNameHash(2997550689)]
		public AntRef SpaceRotationGS { get { return m_SpaceRotationGS; } set { if (OnPropertyChanging("CharacterAnimationSpaceEntityData." + nameof(SpaceRotationGS), this, m_SpaceRotationGS, value)) m_SpaceRotationGS = value; } } // 0x14 (20)
		
		protected float m_WarpAnimationBlendTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1283988115)]
		public float WarpAnimationBlendTime { get { return m_WarpAnimationBlendTime; } set { if (OnPropertyChanging("CharacterAnimationSpaceEntityData." + nameof(WarpAnimationBlendTime), this, m_WarpAnimationBlendTime, value)) m_WarpAnimationBlendTime = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2185021708:
					SpacePositionGS = (AntRef) p_Value;
					break;

				case 2997550689:
					SpaceRotationGS = (AntRef) p_Value;
					break;

				case 1283988115:
					WarpAnimationBlendTime = (float) p_Value;
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
				case 229961746:
					return Realm;

				case 2185021708:
					return SpacePositionGS;

				case 2997550689:
					return SpaceRotationGS;

				case 1283988115:
					return WarpAnimationBlendTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(CharacterAnimationSpaceEntityData).GetProperty(nameof(Realm));

				case 2185021708:
					return typeof(CharacterAnimationSpaceEntityData).GetProperty(nameof(SpacePositionGS));

				case 2997550689:
					return typeof(CharacterAnimationSpaceEntityData).GetProperty(nameof(SpaceRotationGS));

				case 1283988115:
					return typeof(CharacterAnimationSpaceEntityData).GetProperty(nameof(WarpAnimationBlendTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
