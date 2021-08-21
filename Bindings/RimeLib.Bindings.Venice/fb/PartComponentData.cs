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
	public class PartComponentData : 
		ComponentData
	{
		protected RefArray<HealthStateData> m_HealthStates = new RefArray<HealthStateData>();
		[ContainerField(Name: "HealthStates", Offset: 96, NameHash: 2256734877, Flags: 65)]
		public RefArray<HealthStateData> HealthStates { get { return m_HealthStates; } set { if (OnPropertyChanging("PartComponentData." + nameof(HealthStates), this, m_HealthStates, value)) m_HealthStates = value; } } // 0x60 (96)
		
		protected RefArray<PartLinkData> m_PartLinks = new RefArray<PartLinkData>();
		[ContainerField(Name: "PartLinks", Offset: 100, NameHash: 3210318177, Flags: 65)]
		public RefArray<PartLinkData> PartLinks { get { return m_PartLinks; } set { if (OnPropertyChanging("PartComponentData." + nameof(PartLinks), this, m_PartLinks, value)) m_PartLinks = value; } } // 0x64 (100)
		
		protected bool m_IsSupported = new bool();
		[ContainerField(Name: "IsSupported", Offset: 104, NameHash: 797903537, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsSupported { get { return m_IsSupported; } set { if (OnPropertyChanging("PartComponentData." + nameof(IsSupported), this, m_IsSupported, value)) m_IsSupported = value; } } // 0x68 (104)
		
		protected bool m_IsFragile = new bool();
		[ContainerField(Name: "IsFragile", Offset: 105, NameHash: 3219228557, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsFragile { get { return m_IsFragile; } set { if (OnPropertyChanging("PartComponentData." + nameof(IsFragile), this, m_IsFragile, value)) m_IsFragile = value; } } // 0x69 (105)
		
		protected bool m_IsNetworkable = new bool();
		[ContainerField(Name: "IsNetworkable", Offset: 106, NameHash: 4000919755, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsNetworkable { get { return m_IsNetworkable; } set { if (OnPropertyChanging("PartComponentData." + nameof(IsNetworkable), this, m_IsNetworkable, value)) m_IsNetworkable = value; } } // 0x6A (106)
		
		protected bool m_IsWindow = new bool();
		[ContainerField(Name: "IsWindow", Offset: 107, NameHash: 290846451, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsWindow { get { return m_IsWindow; } set { if (OnPropertyChanging("PartComponentData." + nameof(IsWindow), this, m_IsWindow, value)) m_IsWindow = value; } } // 0x6B (107)
		
		protected bool m_AnimatePhysics = new bool();
		[ContainerField(Name: "AnimatePhysics", Offset: 108, NameHash: 443997333, Flags: 49325), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get { return m_AnimatePhysics; } set { if (OnPropertyChanging("PartComponentData." + nameof(AnimatePhysics), this, m_AnimatePhysics, value)) m_AnimatePhysics = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2256734877:
					HealthStates = (RefArray<HealthStateData>) p_Value;
					break;

				case 3210318177:
					PartLinks = (RefArray<PartLinkData>) p_Value;
					break;

				case 797903537:
					IsSupported = (bool) p_Value;
					break;

				case 3219228557:
					IsFragile = (bool) p_Value;
					break;

				case 4000919755:
					IsNetworkable = (bool) p_Value;
					break;

				case 290846451:
					IsWindow = (bool) p_Value;
					break;

				case 443997333:
					AnimatePhysics = (bool) p_Value;
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
				case 2256734877:
					return HealthStates;

				case 3210318177:
					return PartLinks;

				case 797903537:
					return IsSupported;

				case 3219228557:
					return IsFragile;

				case 4000919755:
					return IsNetworkable;

				case 290846451:
					return IsWindow;

				case 443997333:
					return AnimatePhysics;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2256734877:
					return typeof(PartComponentData).GetProperty(nameof(HealthStates));

				case 3210318177:
					return typeof(PartComponentData).GetProperty(nameof(PartLinks));

				case 797903537:
					return typeof(PartComponentData).GetProperty(nameof(IsSupported));

				case 3219228557:
					return typeof(PartComponentData).GetProperty(nameof(IsFragile));

				case 4000919755:
					return typeof(PartComponentData).GetProperty(nameof(IsNetworkable));

				case 290846451:
					return typeof(PartComponentData).GetProperty(nameof(IsWindow));

				case 443997333:
					return typeof(PartComponentData).GetProperty(nameof(AnimatePhysics));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
