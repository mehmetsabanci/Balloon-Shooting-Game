using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonHareket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0,6.0f),ForceMode2D.Impulse);

    }
    void OnMouseDown()
    {
        Destroy(this.gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
