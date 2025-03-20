namespace RimeLib.Content.Frostbite2014_4.Frostbite.Cas;

public class MultipleCatalogEntry
{
	public MultipleCatalogEntry(CatalogEntry p_Entry)
	{
		AddEntry(p_Entry);
	}
	
	public IEnumerable<CatalogEntry> Entries => m_Entries;
	public CatalogEntry FirstEntry => m_Entries.First();

	protected List<CatalogEntry> m_Entries = new ();


	public void AddEntry(CatalogEntry p_Entry)
	{
		m_Entries.Add(p_Entry);
	}
}