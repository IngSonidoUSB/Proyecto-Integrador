using UnityEngine;
using System.Collections;

public class CambiarEscena2 : MonoBehaviour {
	
	// Use this for initialization
	public void scene (string CambiarEscena)  {
		
		Application.LoadLevel (CambiarEscena);
		
	}
}

