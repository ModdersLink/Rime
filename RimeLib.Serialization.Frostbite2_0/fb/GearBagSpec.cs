///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class GearBagSpec :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _MaxPrimaryWeapons;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _MaxSecondaryWeapons;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _MaxSidearms;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _MaxGadgetsPerSlot;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _GadgetSlots;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<GearBagSpec> _ChildSpecs = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxPrimaryWeapons);
			p_Writer.Write(MaxSecondaryWeapons);
			p_Writer.Write(MaxSidearms);
			p_Writer.Write(MaxGadgetsPerSlot);
			p_Writer.Write(GadgetSlots);
			(RimeWriter Writer, uint ArrayIndex) s_ChildSpecs = p_EbxWriter.GetArrayWriter(ChildSpecs.GetType(), ChildSpecs.Count);
			p_Writer.Write(s_ChildSpecs.ArrayIndex);
			foreach (var s_Entry in ChildSpecs)
			{
				s_ChildSpecs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
