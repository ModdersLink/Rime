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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CharacterAnimationEntityData : 
		EntityData
	{
		protected LinearTransform m_EntitySpaceTransform = new LinearTransform();
		[ContainerField(Name: "EntitySpaceTransform", Offset: 16, NameHash: 3912132918, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform EntitySpaceTransform { get { return m_EntitySpaceTransform; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(EntitySpaceTransform), this, m_EntitySpaceTransform, value)) m_EntitySpaceTransform = value; } } // 0x10 (16)
		
		protected AntRef m_Controller = new AntRef();
		[ContainerField(Name: "Controller", Offset: 80, NameHash: 1870777401, Flags: 41)]
		public AntRef Controller { get { return m_Controller; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(Controller), this, m_Controller, value)) m_Controller = value; } } // 0x50 (80)
		
		protected float m_TrackLength = new float();
		[ContainerField(Name: "TrackLength", Offset: 84, NameHash: 736448950, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackLength { get { return m_TrackLength; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(TrackLength), this, m_TrackLength, value)) m_TrackLength = value; } } // 0x54 (84)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 88, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x58 (88)
		
		protected float m_WarpAnimationBlendTime = new float();
		[ContainerField(Name: "WarpAnimationBlendTime", Offset: 92, NameHash: 1283988115, Flags: 49469), LayoutImmutable, Blittable]
		public float WarpAnimationBlendTime { get { return m_WarpAnimationBlendTime; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(WarpAnimationBlendTime), this, m_WarpAnimationBlendTime, value)) m_WarpAnimationBlendTime = value; } } // 0x5C (92)
		
		protected bool m_RestoreControllerOnFinish = new bool();
		[ContainerField(Name: "RestoreControllerOnFinish", Offset: 96, NameHash: 2934168163, Flags: 49325), LayoutImmutable, Blittable]
		public bool RestoreControllerOnFinish { get { return m_RestoreControllerOnFinish; } set { if (OnPropertyChanging("CharacterAnimationEntityData." + nameof(RestoreControllerOnFinish), this, m_RestoreControllerOnFinish, value)) m_RestoreControllerOnFinish = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3912132918:
					EntitySpaceTransform = (LinearTransform) p_Value;
					break;

				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 736448950:
					TrackLength = (float) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1283988115:
					WarpAnimationBlendTime = (float) p_Value;
					break;

				case 2934168163:
					RestoreControllerOnFinish = (bool) p_Value;
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
				case 3912132918:
					return EntitySpaceTransform;

				case 1870777401:
					return Controller;

				case 736448950:
					return TrackLength;

				case 2162678253:
					return ExternalTime;

				case 1283988115:
					return WarpAnimationBlendTime;

				case 2934168163:
					return RestoreControllerOnFinish;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3912132918:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(EntitySpaceTransform));

				case 1870777401:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(Controller));

				case 736448950:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(TrackLength));

				case 2162678253:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(ExternalTime));

				case 1283988115:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(WarpAnimationBlendTime));

				case 2934168163:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(RestoreControllerOnFinish));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
