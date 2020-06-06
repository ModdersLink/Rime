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
	public class DebrisSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MeshDrawCountLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint DrawStats { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MeshBatchCountLimit { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MeshStreamingPriorityMultiplier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool MeshRenderingEnable { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool MeshShadowEnable { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool MeshViewCullingEnable { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool MeshHavokRenderingEnable { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool MeshDrawTransforms { get; set; } // 0x25 (37)
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x26 (38)
		
		[ContainerField(39), LayoutImmutable, Blittable]
		public bool MeshDrawBoundingBoxes { get; set; } // 0x27 (39)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool MeshDrawCullStats { get; set; } // 0x28 (40)
		
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
