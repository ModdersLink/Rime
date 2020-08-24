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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SendEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("SendEntry." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected CtrRef<AudioGraphParameter> m_Target = new CtrRef<AudioGraphParameter>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(3215022804), ContainerCtrRef]
		public CtrRef<AudioGraphParameter> Target { get { return m_Target; } set { if (OnPropertyChanging("SendEntry." + nameof(Target), this, m_Target, value)) m_Target = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<AudioGraphParameter>) p_Value;
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

				case 3215022804:
					return Target;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(SendEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(SendEntry).GetProperty(nameof(Target));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
