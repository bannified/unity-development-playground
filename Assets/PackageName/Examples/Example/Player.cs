using UnityEngine;
using Glazed.Optimization;

namespace Glazed.Example
{
	public class Player : MonoBehaviour
	{
		[SerializeField]
		GameObject projectilePrefab;

		void Start()
		{
			PoolManager.instance.CreatePool(projectilePrefab, 100);
		}

		private void Update()
		{
			if (Input.GetButton("Fire"))
			{
				Shoot();
			}
		}

		void Shoot()
		{

		}

	}
}
