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
	public class DebugComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DebugComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected CtrRef<TextureAsset> m_DebugTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "DebugTexture", Offset: 100, NameHash: 3615235787, Flags: 53)]
		public CtrRef<TextureAsset> DebugTexture { get { return m_DebugTexture; } set { if (OnPropertyChanging("DebugComponentData." + nameof(DebugTexture), this, m_DebugTexture, value)) m_DebugTexture = value; } } // 0x64 (100)
		
		protected bool m_Fullscreen = new bool();
		[ContainerField(Name: "Fullscreen", Offset: 104, NameHash: 2248877754, Flags: 49325), LayoutImmutable, Blittable]
		public bool Fullscreen { get { return m_Fullscreen; } set { if (OnPropertyChanging("DebugComponentData." + nameof(Fullscreen), this, m_Fullscreen, value)) m_Fullscreen = value; } } // 0x68 (104)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 105, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DebugComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x69 (105)
		
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
