using UnityEngine;

namespace Script
{
	public class Player : MonoBehaviour
	{
		private GameObject playerGameObject;
		private Vector2 position;
		
		private void Awake()
		{
			playerGameObject = GameObject.FindGameObjectWithTag(Tags.Player);
			position = playerGameObject.transform.position;
		}

		public void Update()
		{
			playerGameObject.transform.position = position;
			
			if (Input.GetKey(KeyCode.D))
			{
				position = new Vector2(position.x + 0.1f, position.y);
			}
			if (Input.GetKey(KeyCode.A))
			{
				position = new Vector2(position.x - 0.1f, position.y);
			}
		}
	}
}