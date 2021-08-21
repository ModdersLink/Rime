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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CharacterCameraComponentData : 
		ComponentData
	{
		protected RefArray<TargetCameraData> m_Cameras = new RefArray<TargetCameraData>();
		[ContainerField(Name: "Cameras", Offset: 96, NameHash: 3740512847, Flags: 65)]
		public RefArray<TargetCameraData> Cameras { get { return m_Cameras; } set { if (OnPropertyChanging("CharacterCameraComponentData." + nameof(Cameras), this, m_Cameras, value)) m_Cameras = value; } } // 0x60 (96)
		
		protected string m_CameraBoneName = string.Empty;
		[ContainerField(Name: "CameraBoneName", Offset: 100, NameHash: 771838749, Flags: 16509), LayoutImmutable]
		public string CameraBoneName { get { return m_CameraBoneName; } set { if (OnPropertyChanging("CharacterCameraComponentData." + nameof(CameraBoneName), this, m_CameraBoneName, value)) m_CameraBoneName = value; } } // 0x64 (100)
		
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
