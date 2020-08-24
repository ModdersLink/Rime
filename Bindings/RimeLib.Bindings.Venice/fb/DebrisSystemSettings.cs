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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class DebrisSystemSettings : 
		DataContainer
	{
		protected uint m_MeshDrawCountLimit = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3584341216)]
		public uint MeshDrawCountLimit { get { return m_MeshDrawCountLimit; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshDrawCountLimit), this, m_MeshDrawCountLimit, value)) m_MeshDrawCountLimit = value; } } // 0x8 (8)
		
		protected float m_TimeScale = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(169511528)]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0xC (12)
		
		protected float m_MeshCullingDistance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2057455619)]
		public float MeshCullingDistance { get { return m_MeshCullingDistance; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshCullingDistance), this, m_MeshCullingDistance, value)) m_MeshCullingDistance = value; } } // 0x10 (16)
		
		protected uint m_DrawStats = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2413142628)]
		public uint DrawStats { get { return m_DrawStats; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(DrawStats), this, m_DrawStats, value)) m_DrawStats = value; } } // 0x14 (20)
		
		protected uint m_MeshBatchCountLimit = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1925711996)]
		public uint MeshBatchCountLimit { get { return m_MeshBatchCountLimit; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshBatchCountLimit), this, m_MeshBatchCountLimit, value)) m_MeshBatchCountLimit = value; } } // 0x18 (24)
		
		protected float m_MeshStreamingPriorityMultiplier = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1971206387)]
		public float MeshStreamingPriorityMultiplier { get { return m_MeshStreamingPriorityMultiplier; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshStreamingPriorityMultiplier), this, m_MeshStreamingPriorityMultiplier, value)) m_MeshStreamingPriorityMultiplier = value; } } // 0x1C (28)
		
		protected bool m_MeshRenderingEnable = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2979790077)]
		public bool MeshRenderingEnable { get { return m_MeshRenderingEnable; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshRenderingEnable), this, m_MeshRenderingEnable, value)) m_MeshRenderingEnable = value; } } // 0x20 (32)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1190923856)]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x21 (33)
		
		protected bool m_MeshShadowEnable = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(418824849)]
		public bool MeshShadowEnable { get { return m_MeshShadowEnable; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshShadowEnable), this, m_MeshShadowEnable, value)) m_MeshShadowEnable = value; } } // 0x22 (34)
		
		protected bool m_MeshViewCullingEnable = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(875555468)]
		public bool MeshViewCullingEnable { get { return m_MeshViewCullingEnable; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshViewCullingEnable), this, m_MeshViewCullingEnable, value)) m_MeshViewCullingEnable = value; } } // 0x23 (35)
		
		protected bool m_MeshHavokRenderingEnable = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1194385862)]
		public bool MeshHavokRenderingEnable { get { return m_MeshHavokRenderingEnable; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshHavokRenderingEnable), this, m_MeshHavokRenderingEnable, value)) m_MeshHavokRenderingEnable = value; } } // 0x24 (36)
		
		protected bool m_MeshDrawTransforms = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(67393161)]
		public bool MeshDrawTransforms { get { return m_MeshDrawTransforms; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshDrawTransforms), this, m_MeshDrawTransforms, value)) m_MeshDrawTransforms = value; } } // 0x25 (37)
		
		protected bool m_Enable = new bool();
		[ContainerField(38), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x26 (38)
		
		protected bool m_MeshDrawBoundingBoxes = new bool();
		[ContainerField(39), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1284065831)]
		public bool MeshDrawBoundingBoxes { get { return m_MeshDrawBoundingBoxes; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshDrawBoundingBoxes), this, m_MeshDrawBoundingBoxes, value)) m_MeshDrawBoundingBoxes = value; } } // 0x27 (39)
		
		protected bool m_MeshDrawCullStats = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2146509665)]
		public bool MeshDrawCullStats { get { return m_MeshDrawCullStats; } set { if (OnPropertyChanging("DebrisSystemSettings." + nameof(MeshDrawCullStats), this, m_MeshDrawCullStats, value)) m_MeshDrawCullStats = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3584341216:
					MeshDrawCountLimit = (uint) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 2057455619:
					MeshCullingDistance = (float) p_Value;
					break;

				case 2413142628:
					DrawStats = (uint) p_Value;
					break;

				case 1925711996:
					MeshBatchCountLimit = (uint) p_Value;
					break;

				case 1971206387:
					MeshStreamingPriorityMultiplier = (float) p_Value;
					break;

				case 2979790077:
					MeshRenderingEnable = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 418824849:
					MeshShadowEnable = (bool) p_Value;
					break;

				case 875555468:
					MeshViewCullingEnable = (bool) p_Value;
					break;

				case 1194385862:
					MeshHavokRenderingEnable = (bool) p_Value;
					break;

				case 67393161:
					MeshDrawTransforms = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 1284065831:
					MeshDrawBoundingBoxes = (bool) p_Value;
					break;

				case 2146509665:
					MeshDrawCullStats = (bool) p_Value;
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
				case 3584341216:
					return MeshDrawCountLimit;

				case 169511528:
					return TimeScale;

				case 2057455619:
					return MeshCullingDistance;

				case 2413142628:
					return DrawStats;

				case 1925711996:
					return MeshBatchCountLimit;

				case 1971206387:
					return MeshStreamingPriorityMultiplier;

				case 2979790077:
					return MeshRenderingEnable;

				case 1190923856:
					return EnableJobs;

				case 418824849:
					return MeshShadowEnable;

				case 875555468:
					return MeshViewCullingEnable;

				case 1194385862:
					return MeshHavokRenderingEnable;

				case 67393161:
					return MeshDrawTransforms;

				case 2342790116:
					return Enable;

				case 1284065831:
					return MeshDrawBoundingBoxes;

				case 2146509665:
					return MeshDrawCullStats;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3584341216:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshDrawCountLimit));

				case 169511528:
					return typeof(DebrisSystemSettings).GetProperty(nameof(TimeScale));

				case 2057455619:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshCullingDistance));

				case 2413142628:
					return typeof(DebrisSystemSettings).GetProperty(nameof(DrawStats));

				case 1925711996:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshBatchCountLimit));

				case 1971206387:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshStreamingPriorityMultiplier));

				case 2979790077:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshRenderingEnable));

				case 1190923856:
					return typeof(DebrisSystemSettings).GetProperty(nameof(EnableJobs));

				case 418824849:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshShadowEnable));

				case 875555468:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshViewCullingEnable));

				case 1194385862:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshHavokRenderingEnable));

				case 67393161:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshDrawTransforms));

				case 2342790116:
					return typeof(DebrisSystemSettings).GetProperty(nameof(Enable));

				case 1284065831:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshDrawBoundingBoxes));

				case 2146509665:
					return typeof(DebrisSystemSettings).GetProperty(nameof(MeshDrawCullStats));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
