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
	public class WorldPartData : 
		SpatialPrefabBlueprint
	{
		[ContainerField(36), LayoutImmutable, Blittable]
		public GUID HackToSolveRealTimeTweakingIssue { get; set; } // 0x24 (36)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool UseDeferredEntityCreation { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x35 (53)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1452521702:
					HackToSolveRealTimeTweakingIssue = (GUID) p_Value;
					break;

				case 2224120471:
					UseDeferredEntityCreation = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 1452521702:
					return HackToSolveRealTimeTweakingIssue;

				case 2224120471:
					return UseDeferredEntityCreation;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1452521702:
					return typeof(WorldPartData).GetProperty(nameof(HackToSolveRealTimeTweakingIssue));

				case 2224120471:
					return typeof(WorldPartData).GetProperty(nameof(UseDeferredEntityCreation));

				case 2662400:
					return typeof(WorldPartData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
