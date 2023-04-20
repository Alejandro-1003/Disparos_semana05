using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bala;
    private Rigidbody2D rb;
    public bool morir = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if(Input.GetKeyUp(KeyCode.Z)) {
         
         var currentPosition = transform.position;
         var position = new Vector3(currentPosition.x -1, currentPosition.y, 10);
         var balaGO = Instantiate(bala, position, Quaternion.identity);
         var controller = balaGO.GetComponent<BalaController>();
         controller.velocityX = -5f;
       }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      morir = false;
      if(other.gameObject.CompareTag("Enemy"))
      {
        Debug.Log("Muerte");
        morir = true;
        //Destroy(this.gameObject);
      }
    }
}
