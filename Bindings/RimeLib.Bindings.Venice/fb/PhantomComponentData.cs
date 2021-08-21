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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class PhantomComponentData : 
		ComponentData
	{
		protected Vec3 m_BoxSize = new Vec3();
		[ContainerField(Name: "BoxSize", Offset: 96, NameHash: 2526771413, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BoxSize { get { return m_BoxSize; } set { if (OnPropertyChanging("PhantomComponentData." + nameof(BoxSize), this, m_BoxSize, value)) m_BoxSize = value; } } // 0x60 (96)
		
		protected AntRef m_AsyncQueryPointerAsset = new AntRef();
		[ContainerField(Name: "AsyncQueryPointerAsset", Offset: 112, NameHash: 597429154, Flags: 41)]
		public AntRef AsyncQueryPointerAsset { get { return m_AsyncQueryPointerAsset; } set { if (OnPropertyChanging("PhantomComponentData." + nameof(AsyncQueryPointerAsset), this, m_AsyncQueryPointerAsset, value)) m_AsyncQueryPointerAsset = value; } } // 0x70 (112)
		
		protected AntRef m_EnableTrajectoryOverride = new AntRef();
		[ContainerField(Name: "EnableTrajectoryOverride", Offset: 116, NameHash: 1154108267, Flags: 41)]
		public AntRef EnableTrajectoryOverride { get { return m_EnableTrajectoryOverride; } set { if (OnPropertyChanging("PhantomComponentData." + nameof(EnableTrajectoryOverride), this, m_EnableTrajectoryOverride, value)) m_EnableTrajectoryOverride = value; } } // 0x74 (116)
		
		protected AntRef m_TrajectoryOverride = new AntRef();
		[ContainerField(Name: "TrajectoryOverride", Offset: 120, NameHash: 3150043274, Flags: 41)]
		public AntRef TrajectoryOverride { get { return m_TrajectoryOverride; } set { if (OnPropertyChanging("PhantomComponentData." + nameof(TrajectoryOverride), this, m_TrajectoryOverride, value)) m_TrajectoryOverride = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2526771413:
					BoxSize = (Vec3) p_Value;
					break;

				case 597429154:
					AsyncQueryPointerAsset = (AntRef) p_Value;
					break;

				case 1154108267:
					EnableTrajectoryOverride = (AntRef) p_Value;
					break;

				case 3150043274:
					TrajectoryOverride = (AntRef) p_Value;
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
				case 2526771413:
					return BoxSize;

				case 597429154:
					return AsyncQueryPointerAsset;

				case 1154108267:
					return EnableTrajectoryOverride;

				case 3150043274:
					return TrajectoryOverride;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2526771413:
					return typeof(PhantomComponentData).GetProperty(nameof(BoxSize));

				case 597429154:
					return typeof(PhantomComponentData).GetProperty(nameof(AsyncQueryPointerAsset));

				case 1154108267:
					return typeof(PhantomComponentData).GetProperty(nameof(EnableTrajectoryOverride));

				case 3150043274:
					return typeof(PhantomComponentData).GetProperty(nameof(TrajectoryOverride));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
