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
	[ContainerType(4, 16)]
	public partial class LevelDescription :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Name = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _Description = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<LevelDescriptionComponent> _Components = new();
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _IsCoop;
		
		[ObservableProperty]
		[property: ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		private bool _IsMenu;
		
		[ObservableProperty]
		[property: ContainerField(14), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
		private bool _IsMultiplayer;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
			p_Writer.Write(s_Components.ArrayIndex);
			foreach (var s_Entry in Components)
			{
				s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(IsCoop);
			p_Writer.Write(IsMenu);
			p_Writer.Write(IsMultiplayer);
			p_Writer.WriteNullBytes(1);
		}
	}
}
