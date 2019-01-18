namespace Glazed.Optimization
{
	/// <summary>
	/// Interface for a PoolableGameObject.
	/// </summary>
	public interface IPoolableGameObject
	{

		/// <summary>
		/// Called when the GameObject is reused.
		/// Used to reset the GameObject to its default values.
		/// </summary>
		void OnReuse(UnityEngine.GameObject gameObject);

		/// <summary>
		/// Called when the GameObject is reused.
		/// Used to reset the GameObject to its specific values.
		/// </summary>
		void OnReuseWithArguments(UnityEngine.GameObject gameObject, params object[] list);

	}
}