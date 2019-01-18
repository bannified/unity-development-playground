using UnityEngine;

namespace Glazed.Example
{
	public class Projectile : MonoBehaviour, Optimization.IPoolableGameObject
	{
		public void OnReuse()
		{

		}

		public void OnReuseWithArguments(params object[] list)
		{

		}
	}
}
