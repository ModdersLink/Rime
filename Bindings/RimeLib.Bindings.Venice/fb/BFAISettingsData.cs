///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 100)]
	public class BFAISettingsData : 
		AISettingsData
	{
		[ContainerField(80)]
		public CtrRef<MovementConstantData> MovementConstants { get; set; } = new();

		[ContainerField(84)]
		public CtrRef<TurretControlConstantData> TurretControlConstants { get; set; } = new();

		[ContainerField(88)]
		public CtrRef<SearchAndDestroyConstantData> SearchAndDestroyConstants { get; set; } = new();

		[ContainerField(92)]
		public CtrRef<FollowConstantData> FollowConstants { get; set; } = new();

		[ContainerField(96)]
		public CtrRef<CombatConstantData> CombatConstants { get; set; } = new();

		public static void Deserialize(BFAISettingsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MovementConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TurretControlConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SearchAndDestroyConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.FollowConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CombatConstants.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
