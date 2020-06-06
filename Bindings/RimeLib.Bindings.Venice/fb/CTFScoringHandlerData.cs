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
	public class CTFScoringHandlerData : 
		ScoringHandlerData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int MaxTeams { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PickUpAssistRadius { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CaptureAssistRadius { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float EnemyThreatRadius { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float EnemySuppressionTimeout { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 401391615:
					MaxTeams = (int) p_Value;
					break;

				case 1365389190:
					PickUpAssistRadius = (float) p_Value;
					break;

				case 2950263830:
					CaptureAssistRadius = (float) p_Value;
					break;

				case 3061043225:
					EnemyThreatRadius = (float) p_Value;
					break;

				case 1983551709:
					EnemySuppressionTimeout = (float) p_Value;
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
				case 401391615:
					return MaxTeams;

				case 1365389190:
					return PickUpAssistRadius;

				case 2950263830:
					return CaptureAssistRadius;

				case 3061043225:
					return EnemyThreatRadius;

				case 1983551709:
					return EnemySuppressionTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 401391615:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(MaxTeams));

				case 1365389190:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(PickUpAssistRadius));

				case 2950263830:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(CaptureAssistRadius));

				case 3061043225:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(EnemyThreatRadius));

				case 1983551709:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(EnemySuppressionTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
