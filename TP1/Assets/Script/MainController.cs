using UnityEngine;

namespace Script
{
	public class MainController : MonoBehaviour
	{
		private Player player;
	
		void Start ()
		{
			player = FindObjectOfType<Player>();
		}
	
		void Update () 
		{
			player.Update();
		}
	}
}
