///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(1)]
	public class CharacterPoseConstraintsData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool StandPose { get; set; } // 0x0 (0)
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool CrouchPose { get; set; } // 0x1 (1)
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool PronePose { get; set; } // 0x2 (2)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3580661600:
					StandPose = (bool) p_Value;
					break;

				case 1318089740:
					CrouchPose = (bool) p_Value;
					break;

				case 3841962:
					PronePose = (bool) p_Value;
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
				case 3580661600:
					return StandPose;

				case 1318089740:
					return CrouchPose;

				case 3841962:
					return PronePose;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3580661600:
					return typeof(CharacterPoseConstraintsData).GetProperty(nameof(StandPose));

				case 1318089740:
					return typeof(CharacterPoseConstraintsData).GetProperty(nameof(CrouchPose));

				case 3841962:
					return typeof(CharacterPoseConstraintsData).GetProperty(nameof(PronePose));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
