/// <summary>
/// Interface for a Component that can be reused (alongside its GameObject).
/// </summary>
public interface IPoolableComponent
{
	void OnReuse();
}
