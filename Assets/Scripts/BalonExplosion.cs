using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonExplosion : MonoBehaviour
{
    public GameObject explosion;
    OyunKontrol oyunKontrol;
    private void OnMouseDown()
    {
        GameObject go = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.317f);
        FindObjectOfType<SesKontrol>().BalonSound();
        oyunKontrol.BalonEkle();
    }
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
