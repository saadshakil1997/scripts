using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Explode : MonoBehaviour
{
    public GameObject bomb;
    public GameObject[] died;
    // Start is called before the first frame update
    void Start()
    {
        bomb.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        bomb.SetActive(true);
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        died[0].SetActive(true);
        yield return new WaitForSeconds(5);
        died[0].SetActive(false);
        died[1].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
