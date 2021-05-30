using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Level : MonoBehaviour
{
    public GameObject[] completed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Enemy_Dead") >= 5) {
            completed[0].SetActive(true);
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        completed[0].SetActive(false);
        completed[1].SetActive(true);
    }
}
