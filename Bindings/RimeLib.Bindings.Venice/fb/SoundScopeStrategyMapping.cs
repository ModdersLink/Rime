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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class SoundScopeStrategyMapping : FrostbiteContainer
	{
		[ContainerField(Name: "Scope", Offset: 0, NameHash: 231225103, Flags: 53)]
		public CtrRef<SoundScopeData> Scope { get; set; } = new CtrRef<SoundScopeData>(); // 0x0 (0)
		
		[ContainerField(Name: "Strategy", Offset: 4, NameHash: 3526111934, Flags: 53)]
		public CtrRef<SoundScopeStrategyData> Strategy { get; set; } = new CtrRef<SoundScopeStrategyData>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231225103:
					Scope = (CtrRef<SoundScopeData>) p_Value;
					break;

				case 3526111934:
					Strategy = (CtrRef<SoundScopeStrategyData>) p_Value;
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
				case 231225103:
					return Scope;

				case 3526111934:
					return Strategy;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231225103:
					return typeof(SoundScopeStrategyMapping).GetProperty(nameof(Scope));

				case 3526111934:
					return typeof(SoundScopeStrategyMapping).GetProperty(nameof(Strategy));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
