using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Sb;

public class ChunkManifest : DbObjectSerializable
{
	public class Chunk : DbObjectSerializable
	{
		[DbObjectField("id")]
		public int Id { get; set; } = 0;
            
		[DbObjectField("installPackageId")]
		public GUID InstallPackageId { get; set; } = GUID.Empty;
		
		
		[DbObjectField("launch", DefaultValue = false)]
		public bool Launch { get; set; }
	}


	[DbObjectField("version")]
	public float Version { get; set; } = 0.0f;

	[DbObjectField("chunks")]
	public Chunk[] Chunks { get; set; } = new Chunk[0];

	
}