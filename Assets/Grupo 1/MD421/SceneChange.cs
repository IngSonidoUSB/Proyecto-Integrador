using UnityEngine;
using System.Collections;

public class SceneChangea : MonoBehaviour {
	
	// Use this for initialization
	public void scene (string CambiarEscena)  {
		
		Application.LoadLevel (CambiarEscena);
		
	}
}

