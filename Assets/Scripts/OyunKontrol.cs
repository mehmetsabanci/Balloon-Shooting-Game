using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public Text zamanText,balonText,balonText1;
    public float zamanSayaci = 60;
    public GameObject patlama;
    public GameObject panel;
    int patlayanBalon = 0;
   

    
    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Puan: " + patlayanBalon;
        balonText1.text = ": " + patlayanBalon;
    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Puan: " + patlayanBalon;
        balonText1.text = ": " + patlayanBalon;

    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime; // saniyede 1 deðer düþürüyoruz.
            zamanText.text = "Time: " + (int)zamanSayaci;
        }
        else
        {
           
            
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
                for (int i = 0; i < go.Length; i++)
                {
                    GameObject patlatma = Instantiate(patlama, go[i].transform.position, go[i].transform.rotation) as GameObject;
                    Destroy(go[i]);
                    Destroy(patlatma, 0.3f);
                panel.SetActive(true);
                
            }
        }
    }
}
