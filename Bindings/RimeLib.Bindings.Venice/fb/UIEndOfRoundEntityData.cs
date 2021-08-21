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
	public class UIEndOfRoundEntityData : 
		GameEntityData
	{
		protected float m_PreEorTime = new float();
		[ContainerField(Name: "PreEorTime", Offset: 96, NameHash: 3258863311, Flags: 49469), LayoutImmutable, Blittable]
		public float PreEorTime { get { return m_PreEorTime; } set { if (OnPropertyChanging("UIEndOfRoundEntityData." + nameof(PreEorTime), this, m_PreEorTime, value)) m_PreEorTime = value; } } // 0x60 (96)
		
		protected float m_EorTime = new float();
		[ContainerField(Name: "EorTime", Offset: 100, NameHash: 4274483656, Flags: 49469), LayoutImmutable, Blittable]
		public float EorTime { get { return m_EorTime; } set { if (OnPropertyChanging("UIEndOfRoundEntityData." + nameof(EorTime), this, m_EorTime, value)) m_EorTime = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3258863311:
					PreEorTime = (float) p_Value;
					break;

				case 4274483656:
					EorTime = (float) p_Value;
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
				case 3258863311:
					return PreEorTime;

				case 4274483656:
					return EorTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3258863311:
					return typeof(UIEndOfRoundEntityData).GetProperty(nameof(PreEorTime));

				case 4274483656:
					return typeof(UIEndOfRoundEntityData).GetProperty(nameof(EorTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
