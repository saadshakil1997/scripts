using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogues : MonoBehaviour
{
    public GameObject[] dialogue;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
       for(int i=0; i<dialogue.Length; i++)
        {
            dialogue[i].SetActive(false);
        }
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
        ok();
    }
    public void ok()
    {
        text.SetActive(false);
        for (int i = 0; i < dialogue.Length; i++)
        {
            dialogue[i].SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
