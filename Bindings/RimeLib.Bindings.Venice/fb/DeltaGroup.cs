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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class DeltaGroup : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("DeltaGroup." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Delta = new AudioGraphNodePort();
		[ContainerField(Name: "Delta", Offset: 16, NameHash: 208768797, Flags: 41)]
		public AudioGraphNodePort Delta { get { return m_Delta; } set { if (OnPropertyChanging("DeltaGroup." + nameof(Delta), this, m_Delta, value)) m_Delta = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 208768797:
					Delta = (AudioGraphNodePort) p_Value;
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
				case 5862146:
					return In;

				case 208768797:
					return Delta;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DeltaGroup).GetProperty(nameof(In));

				case 208768797:
					return typeof(DeltaGroup).GetProperty(nameof(Delta));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
