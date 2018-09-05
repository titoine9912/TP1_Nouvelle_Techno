using UnityEngine;

namespace Script
{
	public class MainController : MonoBehaviour
	{
		private GameObject player;
		private Vector2 position;
	
		void Start ()
		{
			player = GameObject.FindGameObjectWithTag(Tags.Player);
			position = player.transform.position;
		}
	
		void Update () 
		{
			player.transform.position = position;
			
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
