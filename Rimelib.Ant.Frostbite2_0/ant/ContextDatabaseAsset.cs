///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// As type schemas dont contain full information, modifying  //
// can be done to fix information thats wrong or missing.    //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using RimeLib.Ant.EA.Attributes;
using RimeLib.Ant.EA.Types;

namespace ant
{

	[AntBinding(0xf4db6cb4)]
	public class ContextDatabaseAsset
		: AntObject
	{
		[AntField(0)]
		public List<EntryAsset?> EntryAssets { get; set; } = new();


		//This can also be "RegistryFieldAsset" as well as "FieldDescriptionAsset" 
		[AntField(1)]
		public List<AntObject?> FieldDescriptionAssets { get; set; } = new();

	}
}
