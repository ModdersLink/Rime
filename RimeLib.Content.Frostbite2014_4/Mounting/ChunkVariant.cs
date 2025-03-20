using System.Diagnostics.CodeAnalysis;
using RimeLib.Content.Frostbite2014_4.Frostbite.Chunks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Mounting;

internal class ChunkVariant : ObjectVariant, IChunkVariant
{
	protected DbObject? m_Meta;
	protected uint m_LogicalOffset;

	public ChunkVariant(IReadableObjectWithHash p_Readable, uint p_LogicalOffset, DbObject? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) 
		: base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
	{
		m_Meta = p_Meta;
		m_LogicalOffset = p_LogicalOffset;
	}

	public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
	{
		p_Meta = m_Meta;
		return m_Meta != null;
	}

	public uint GetRangeStart()
	{
		throw new NotImplementedException();
		return 0;
	}

	public uint GetLogicalOffset()
	{
		return m_LogicalOffset;
	}

	public int? GetAssetNameHash()
	{
		if (m_Meta == null)
			return null;
            
		try
		{
			var s_Meta = DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(m_Meta);
			return s_Meta.AssetNameHash;
		}
		catch (Exception)
		{
			return null;
		}
	}
}