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
	public class AnimatedPointCloudComponentData : 
		ComponentData
	{
		protected CtrRef<AnimatedPointCloudAsset> m_PointCloud = new CtrRef<AnimatedPointCloudAsset>();
		[ContainerField(Name: "PointCloud", Offset: 96, NameHash: 396521112, Flags: 53)]
		public CtrRef<AnimatedPointCloudAsset> PointCloud { get { return m_PointCloud; } set { if (OnPropertyChanging("AnimatedPointCloudComponentData." + nameof(PointCloud), this, m_PointCloud, value)) m_PointCloud = value; } } // 0x60 (96)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 100, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("AnimatedPointCloudComponentData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x64 (100)
		
		protected bool m_StartPaused = new bool();
		[ContainerField(Name: "StartPaused", Offset: 104, NameHash: 735997331, Flags: 49325), LayoutImmutable, Blittable]
		public bool StartPaused { get { return m_StartPaused; } set { if (OnPropertyChanging("AnimatedPointCloudComponentData." + nameof(StartPaused), this, m_StartPaused, value)) m_StartPaused = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
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
				case 396521112:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(PointCloud));

				case 2162678253:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(ExternalTime));

				case 735997331:
					return typeof(AnimatedPointCloudComponentData).GetProperty(nameof(StartPaused));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
