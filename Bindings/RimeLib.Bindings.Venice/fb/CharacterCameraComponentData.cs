///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CharacterCameraComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new RefArray<TargetCameraData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string CameraBoneName { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3740512847:
					Cameras = (RefArray<TargetCameraData>) p_Value;
					break;

				case 771838749:
					CameraBoneName = (string) p_Value;
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
				case 3740512847:
					return Cameras;

				case 771838749:
					return CameraBoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3740512847:
					return typeof(CharacterCameraComponentData).GetProperty(nameof(Cameras));

				case 771838749:
					return typeof(CharacterCameraComponentData).GetProperty(nameof(CameraBoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
