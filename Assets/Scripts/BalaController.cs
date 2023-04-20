using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    Rigidbody2D rb;
    
    public float velocityX = 0.1f;
    public float velocityY = 0f;
    public GameObject bala1;
    public GameObject bala2;
    public bool partirse = true;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 20);
    }

    
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        /*
         if (Input.GetKeyDown(KeyCode.X) && partirse == true)
        {
          
         var posicion1 =transform.position + new Vector3(-1.5f,-1,0); 
         var gb1 = Instantiate (balal, posicion1, Quaternion.identity); 
         var controlador1 = gb1.GetComponent<BalaControllar>();
         controlador1.darvelocidady(-2f); 
         controlador1.quitarPartirse();

         var posicion2 =transform.position + new Vector3(-1.5f,1,0); 
         var gb2 = Instantiate (balal, posicion2, Quaternion.identity); 
         var controlador2 = gb2.GetComponent<BalaControllar>();
         controlador2.darvelocidady(2f);
         controlador2.quitarPartirse();
         quitarPartirse();
        } 
        */
    }


    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Bala"))
        {
           Debug.Log("Muerte");
           Destroy(other.gameObject);
           Destroy(this.gameObject);
        }
        
    }
        
 }

