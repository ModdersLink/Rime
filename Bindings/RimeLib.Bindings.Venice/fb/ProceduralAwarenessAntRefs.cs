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
	public class ProceduralAwarenessAntRefs : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef ProceduralAwarenessActive { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef ProceduralAwarenessHumanIKActive { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef ProceduralAwarenessData { get; set; } = new AntRef(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 917996519:
					ProceduralAwarenessActive = (AntRef) p_Value;
					break;

				case 2022287482:
					ProceduralAwarenessHumanIKActive = (AntRef) p_Value;
					break;

				case 935670043:
					ProceduralAwarenessData = (AntRef) p_Value;
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
				case 917996519:
					return ProceduralAwarenessActive;

				case 2022287482:
					return ProceduralAwarenessHumanIKActive;

				case 935670043:
					return ProceduralAwarenessData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 917996519:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessActive));

				case 2022287482:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessHumanIKActive));

				case 935670043:
					return typeof(ProceduralAwarenessAntRefs).GetProperty(nameof(ProceduralAwarenessData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
