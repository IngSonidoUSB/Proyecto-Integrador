using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MENUPRINC : MonoBehaviour {
public void POLMIC(string level)
    {
        Application.LoadLevel("POLMIC");
    }

      public void FREQMIC(string level)
    {
        Application.LoadLevel("FREQMIC");
    }

    public void POLARBACK(string level)
    {
        Application.LoadLevel("MIC");
    }
    public void FREQBACK(string level)
    {
        Application.LoadLevel("MIC");
    }
}
