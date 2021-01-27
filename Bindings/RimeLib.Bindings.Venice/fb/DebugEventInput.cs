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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class DebugEventInput : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_E = new AudioGraphNodePort();
		[ContainerField(Name: "E", Offset: 8, NameHash: 177632, Flags: 41)]
		public AudioGraphNodePort E { get { return m_E; } set { if (OnPropertyChanging("DebugEventInput." + nameof(E), this, m_E, value)) m_E = value; } } // 0x8 (8)
		
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 16, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("DebugEventInput." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected bool m_RequireTriggeredAndSet = new bool();
		[ContainerField(Name: "RequireTriggeredAndSet", Offset: 20, NameHash: 850664216, Flags: 49325), LayoutImmutable, Blittable]
		public bool RequireTriggeredAndSet { get { return m_RequireTriggeredAndSet; } set { if (OnPropertyChanging("DebugEventInput." + nameof(RequireTriggeredAndSet), this, m_RequireTriggeredAndSet, value)) m_RequireTriggeredAndSet = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177632:
					E = (AudioGraphNodePort) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 850664216:
					RequireTriggeredAndSet = (bool) p_Value;
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
				case 177632:
					return E;

				case 2088949890:
					return Name;

				case 850664216:
					return RequireTriggeredAndSet;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177632:
					return typeof(DebugEventInput).GetProperty(nameof(E));

				case 2088949890:
					return typeof(DebugEventInput).GetProperty(nameof(Name));

				case 850664216:
					return typeof(DebugEventInput).GetProperty(nameof(RequireTriggeredAndSet));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
