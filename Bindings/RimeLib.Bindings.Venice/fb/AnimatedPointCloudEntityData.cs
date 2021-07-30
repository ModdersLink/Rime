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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class AnimatedPointCloudEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("AnimatedPointCloudEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected CtrRef<AnimatedPointCloudAsset> m_PointCloud = new CtrRef<AnimatedPointCloudAsset>();
		[ContainerField(Name: "PointCloud", Offset: 16, NameHash: 396521112, Flags: 53)]
		public CtrRef<AnimatedPointCloudAsset> PointCloud { get { return m_PointCloud; } set { if (OnPropertyChanging("AnimatedPointCloudEntityData." + nameof(PointCloud), this, m_PointCloud, value)) m_PointCloud = value; } } // 0x10 (16)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 20, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("AnimatedPointCloudEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x14 (20)
		
		protected bool m_StartPaused = new bool();
		[ContainerField(Name: "StartPaused", Offset: 24, NameHash: 735997331, Flags: 49325), LayoutImmutable, Blittable]
		public bool StartPaused { get { return m_StartPaused; } set { if (OnPropertyChanging("AnimatedPointCloudEntityData." + nameof(StartPaused), this, m_StartPaused, value)) m_StartPaused = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 396521112:
					PointCloud = (CtrRef<AnimatedPointCloudAsset>) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 735997331:
					StartPaused = (bool) p_Value;
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

				case 396521112:
					return PointCloud;

				case 2162678253:
					return ExternalTime;

				case 735997331:
					return StartPaused;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(AnimatedPointCloudEntityData).GetProperty(nameof(Realm));

				case 396521112:
					return typeof(AnimatedPointCloudEntityData).GetProperty(nameof(PointCloud));

				case 2162678253:
					return typeof(AnimatedPointCloudEntityData).GetProperty(nameof(ExternalTime));

				case 735997331:
					return typeof(AnimatedPointCloudEntityData).GetProperty(nameof(StartPaused));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
