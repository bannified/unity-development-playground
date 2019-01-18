/// <summary>
/// Interface for a PoolableGameObject.
/// </summary>
public interface IPoolableGameObject {

	/// <summary>
	/// Called when the GameObject is reused.
	/// Used to reset the GameObject to its default values.
	/// </summary>
	void OnReuse();

	/// <summary>
	/// Called when the GameObject is reused.
	/// Used to reset the GameObject to its specific values.
	/// </summary>
	void OnReuseWithArguments(params object[] list);

}
