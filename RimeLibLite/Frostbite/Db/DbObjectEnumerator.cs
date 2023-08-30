using System.Collections;
using System.Collections.Generic;

namespace RimeLib.Frostbite.Db;

public class DbObjectEnumerator : IEnumerator<DbObjectElement>
{
	public DbObjectEnumerator(DbObject p_Object)
	{
		Object = p_Object;
	}

	private DbObject Object { get; set; }
	
	private int Index { get; set; } = -1;

	
	object IEnumerator.Current => Object[Index];
	public DbObjectElement Current => Object[Index];
	
	public bool MoveNext()
	{
		Index++;
		return Index > 0 && Index < Object.Count;
	}
	
	public void Reset()
	{
		Index = -1;
	}

	public void Dispose()
	{
	}
}