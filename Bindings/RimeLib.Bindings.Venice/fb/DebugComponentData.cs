///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DebugComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<TextureAsset> DebugTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3615235787:
					DebugTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2248877754:
					Fullscreen = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 3615235787:
					return DebugTexture;

				case 2248877754:
					return Fullscreen;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(DebugComponentData).GetProperty(nameof(Realm));

				case 3615235787:
					return typeof(DebugComponentData).GetProperty(nameof(DebugTexture));

				case 2248877754:
					return typeof(DebugComponentData).GetProperty(nameof(Fullscreen));

				case 2342790116:
					return typeof(DebugComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
