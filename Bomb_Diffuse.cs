using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bomb_Diffuse : MonoBehaviour
{
    public Image health;
    public GameObject[] dialogue;
    public TimerEight time;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        dialogue[11].SetActive(true);
            diffuse();
        
    }
    public void diffuse()
    {
        dialogue[0].SetActive(true);
        dialogue[8].SetActive(true);
        dialogue[9].SetActive(true);
        dialogue[10].SetActive(false);
        InvokeRepeating("fillamount", 0f, 1f);
        StartCoroutine(wait());
    }
    private void OnTriggerExit(Collider other)
    {
        //CancelInvoke();
    }
    public void fillamount()
    {
        health.fillAmount += 0.1f;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
        dialogue[1].SetActive(true);
        dialogue[0].SetActive(false);
        yield return new WaitForSeconds(5);
        dialogue[1].SetActive(false);
        dialogue[2].SetActive(false);
        dialogue[3].SetActive(false);
        
        time.enabled = false;
        yield return new WaitForSeconds(5);
        count += 1;
        PlayerPrefs.SetInt("Bomb", count);
        dialogue[5].SetActive(false);
        dialogue[7].SetActive(false);
        yield return new WaitForSeconds(5);
        dialogue[6].SetActive(false);
        dialogue[8].SetActive(false);
        dialogue[9].SetActive(false);
        dialogue[10].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (time.count<=0)
        {
            dialogue[4].SetActive(true);
        }
        if (health.fillAmount == 1)
        {
            
            
        }
    }
    
}
