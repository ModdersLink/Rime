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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class SpottingTargetComponentData : 
		ComponentData
	{
		protected float m_ActiveSpottedTime = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(748599697)]
		public float ActiveSpottedTime { get { return m_ActiveSpottedTime; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(ActiveSpottedTime), this, m_ActiveSpottedTime, value)) m_ActiveSpottedTime = value; } } // 0x60 (96)
		
		protected float m_PassiveSpottedTime = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2532328150)]
		public float PassiveSpottedTime { get { return m_PassiveSpottedTime; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(PassiveSpottedTime), this, m_PassiveSpottedTime, value)) m_PassiveSpottedTime = value; } } // 0x64 (100)
		
		protected float m_ActiveSpottedTimeMultiplier = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1518946778)]
		public float ActiveSpottedTimeMultiplier { get { return m_ActiveSpottedTimeMultiplier; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(ActiveSpottedTimeMultiplier), this, m_ActiveSpottedTimeMultiplier, value)) m_ActiveSpottedTimeMultiplier = value; } } // 0x68 (104)
		
		protected float m_PassiveSpottedTimeMultiplier = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(996451229)]
		public float PassiveSpottedTimeMultiplier { get { return m_PassiveSpottedTimeMultiplier; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(PassiveSpottedTimeMultiplier), this, m_PassiveSpottedTimeMultiplier, value)) m_PassiveSpottedTimeMultiplier = value; } } // 0x6C (108)
		
		protected float m_SpotOnFireMultiplier = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3169810191)]
		public float SpotOnFireMultiplier { get { return m_SpotOnFireMultiplier; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(SpotOnFireMultiplier), this, m_SpotOnFireMultiplier, value)) m_SpotOnFireMultiplier = value; } } // 0x70 (112)
		
		protected bool m_TargetBoundingBoxCenter = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2640665496)]
		public bool TargetBoundingBoxCenter { get { return m_TargetBoundingBoxCenter; } set { if (OnPropertyChanging("SpottingTargetComponentData." + nameof(TargetBoundingBoxCenter), this, m_TargetBoundingBoxCenter, value)) m_TargetBoundingBoxCenter = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 748599697:
					ActiveSpottedTime = (float) p_Value;
					break;

				case 2532328150:
					PassiveSpottedTime = (float) p_Value;
					break;

				case 1518946778:
					ActiveSpottedTimeMultiplier = (float) p_Value;
					break;

				case 996451229:
					PassiveSpottedTimeMultiplier = (float) p_Value;
					break;

				case 3169810191:
					SpotOnFireMultiplier = (float) p_Value;
					break;

				case 2640665496:
					TargetBoundingBoxCenter = (bool) p_Value;
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
				case 748599697:
					return ActiveSpottedTime;

				case 2532328150:
					return PassiveSpottedTime;

				case 1518946778:
					return ActiveSpottedTimeMultiplier;

				case 996451229:
					return PassiveSpottedTimeMultiplier;

				case 3169810191:
					return SpotOnFireMultiplier;

				case 2640665496:
					return TargetBoundingBoxCenter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 748599697:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(ActiveSpottedTime));

				case 2532328150:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(PassiveSpottedTime));

				case 1518946778:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(ActiveSpottedTimeMultiplier));

				case 996451229:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(PassiveSpottedTimeMultiplier));

				case 3169810191:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(SpotOnFireMultiplier));

				case 2640665496:
					return typeof(SpottingTargetComponentData).GetProperty(nameof(TargetBoundingBoxCenter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
