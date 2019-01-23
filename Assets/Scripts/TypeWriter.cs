using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour {

    float delay = 0.1f;
    string fullText = "Aplikasi ini dikembangkan oleh :\n" +
        " 1. Muhammad Rizal rusdiansyah\n" +
        " 2. siti fatimah puspitaningrum\n" +
        " 3. shada intishar\n" +
        " 4. dwi arifianto\n" +
        " 5. wahyu arbianda";
    private string currText="";
    public Text uiText;

	// Use this for initialization
	void Start () {
        StartCoroutine(showText());
	}
	
	IEnumerator showText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currText = fullText.Substring(0, i);
            uiText.text = currText;
            yield return new WaitForSeconds(delay);
        }
    }
}
