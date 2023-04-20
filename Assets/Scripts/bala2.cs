using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala2 : MonoBehaviour
{
   Rigidbody2D rb;
    
    public float velocityX = 5f;
    public float velocityY = -1f;
    
    public bool partirse = true;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 20);
    }

    
    void Update()
    {
        rb.velocity = new Vector2(velocityX, velocityY);
    }
}
