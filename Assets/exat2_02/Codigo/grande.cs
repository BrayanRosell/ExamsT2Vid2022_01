using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grande : MonoBehaviour
{
    public float velocityX=10f;
    private Rigidbody2D rigidbody;
    private packController playerController;
    // Start is called before the first frame update
    void Start()
    {
         rigidbody = GetComponent<Rigidbody2D>();
        playerController = FindObjectOfType<packController>(); //lo busca
        //para eliminar gameobject
        Destroy(gameObject,4);
    }

    // Update is called once per frame
    void Update()
    {
         //rigidbody.velocity = new vector2(velocityX,rigidbody.velocity.y);
        rigidbody.velocity = Vector2.right * velocityX;
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.layer ==6 ){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }
    }
}