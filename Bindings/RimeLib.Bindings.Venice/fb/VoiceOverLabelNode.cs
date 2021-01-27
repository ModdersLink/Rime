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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class VoiceOverLabelNode : 
		VoiceOverExpressionNode
	{
		protected RefArray<VoiceOverLabelSource> m_Sources = new RefArray<VoiceOverLabelSource>();
		[ContainerField(Name: "Sources", Offset: 8, NameHash: 2837180395, Flags: 65)]
		public RefArray<VoiceOverLabelSource> Sources { get { return m_Sources; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(Sources), this, m_Sources, value)) m_Sources = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_False = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "False", Offset: 12, NameHash: 206401336, Flags: 53)]
		public CtrRef<VoiceOverValue> False { get { return m_False; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverValue> m_True = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "True", Offset: 16, NameHash: 2089293587, Flags: 53)]
		public CtrRef<VoiceOverValue> True { get { return m_True; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverLabel> m_WantedLabels = new RefArray<VoiceOverLabel>();
		[ContainerField(Name: "WantedLabels", Offset: 20, NameHash: 591591005, Flags: 65)]
		public RefArray<VoiceOverLabel> WantedLabels { get { return m_WantedLabels; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(WantedLabels), this, m_WantedLabels, value)) m_WantedLabels = value; } } // 0x14 (20)
		
		protected RefArray<VoiceOverLabel> m_UnwantedLabels = new RefArray<VoiceOverLabel>();
		[ContainerField(Name: "UnwantedLabels", Offset: 24, NameHash: 2244868070, Flags: 65)]
		public RefArray<VoiceOverLabel> UnwantedLabels { get { return m_UnwantedLabels; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(UnwantedLabels), this, m_UnwantedLabels, value)) m_UnwantedLabels = value; } } // 0x18 (24)
		
		protected VoiceOverLabelSourceMode m_SourceMode = new VoiceOverLabelSourceMode();
		[ContainerField(Name: "SourceMode", Offset: 28, NameHash: 1522324635, Flags: 137)]
		public VoiceOverLabelSourceMode SourceMode { get { return m_SourceMode; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(SourceMode), this, m_SourceMode, value)) m_SourceMode = value; } } // 0x1C (28)
		
		protected VoiceOverLabelCompareMode m_WantedCompareMode = new VoiceOverLabelCompareMode();
		[ContainerField(Name: "WantedCompareMode", Offset: 32, NameHash: 1232611212, Flags: 137)]
		public VoiceOverLabelCompareMode WantedCompareMode { get { return m_WantedCompareMode; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(WantedCompareMode), this, m_WantedCompareMode, value)) m_WantedCompareMode = value; } } // 0x20 (32)
		
		protected VoiceOverLabelCompareMode m_UnwantedCompareMode = new VoiceOverLabelCompareMode();
		[ContainerField(Name: "UnwantedCompareMode", Offset: 36, NameHash: 133443287, Flags: 137)]
		public VoiceOverLabelCompareMode UnwantedCompareMode { get { return m_UnwantedCompareMode; } set { if (OnPropertyChanging("VoiceOverLabelNode." + nameof(UnwantedCompareMode), this, m_UnwantedCompareMode, value)) m_UnwantedCompareMode = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2837180395:
					Sources = (RefArray<VoiceOverLabelSource>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 591591005:
					WantedLabels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 2244868070:
					UnwantedLabels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 1522324635:
					SourceMode = (VoiceOverLabelSourceMode) Enum.ToObject(typeof(VoiceOverLabelSourceMode), p_Value);
					break;

				case 1232611212:
					WantedCompareMode = (VoiceOverLabelCompareMode) Enum.ToObject(typeof(VoiceOverLabelCompareMode), p_Value);
					break;

				case 133443287:
					UnwantedCompareMode = (VoiceOverLabelCompareMode) Enum.ToObject(typeof(VoiceOverLabelCompareMode), p_Value);
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
				case 2837180395:
					return Sources;

				case 206401336:
					return False;

				case 2089293587:
					return True;

				case 591591005:
					return WantedLabels;

				case 2244868070:
					return UnwantedLabels;

				case 1522324635:
					return SourceMode;

				case 1232611212:
					return WantedCompareMode;

				case 133443287:
					return UnwantedCompareMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2837180395:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(Sources));

				case 206401336:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(False));

				case 2089293587:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(True));

				case 591591005:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(WantedLabels));

				case 2244868070:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(UnwantedLabels));

				case 1522324635:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(SourceMode));

				case 1232611212:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(WantedCompareMode));

				case 133443287:
					return typeof(VoiceOverLabelNode).GetProperty(nameof(UnwantedCompareMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
