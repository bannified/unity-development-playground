using UnityEngine;

namespace Glazed.Example
{
	public class Projectile : MonoBehaviour, Optimization.IPoolableGameObject
	{
		public void OnReuse(GameObject gameObject)
		{

		}

		public void OnReuseWithArguments(GameObject gameObject, params object[] list)
		{

		}
	}
}
