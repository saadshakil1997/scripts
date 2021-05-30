using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Typer_Text : MonoBehaviour
{
	// Start is called before the first frame update
	/*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
	Text txt;
	string story;

	void Awake()
	{
		txt = GetComponent<Text>();
		story = txt.text;
		txt.text = "";

		// TODO: add optional delay when to start
		StartCoroutine("PlayText");
	}

	IEnumerator PlayText()
	{
		foreach (char c in story)
		{
			txt.text += c;
			yield return new WaitForSeconds(0.083f);
		}
	}
}
