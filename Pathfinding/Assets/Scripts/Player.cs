using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody2D rb; 
    private Vector2 movement; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D no encontrado. Asegúrate de que el objeto tiene un componente Rigidbody2D.");
        }
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

}
