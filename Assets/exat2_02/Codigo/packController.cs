using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class packController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    private float speed = 8;
    public int p=0;
    public int m=0;

    public GameObject rightBullet;
    public GameObject rightBulletMedi;
    public GameObject rightBulletGrande;
    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
         rb2d.gravityScale = 25;
        
         quieto();
         var position = new Vector2(transform.position.x+2.5f,transform.position.y-0.3f);
         if(Input.GetKeyUp(KeyCode.X)){
             
            Instantiate(rightBullet,position,rightBullet.transform.rotation);
         }
         if(Input.GetKeyUp(KeyCode.M)){
             
            Instantiate(rightBulletMedi,position,rightBullet.transform.rotation);
         }
         if(Input.GetKeyUp(KeyCode.G)){
             
            Instantiate(rightBulletGrande,position,rightBullet.transform.rotation);
         }
         
         if(Input.GetKey(KeyCode.S)){
             carga();
         }
        if(Input.GetKey(KeyCode.Space))
            {  
                saltar();          
            saltarF();
            
            }
        if(Input.GetKey(KeyCode.D))
        {
                sr.flipX = false;
                correrDis();
                rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
                if(Input.GetKeyUp(KeyCode.X)){
                
                Instantiate(rightBullet,position,rightBullet.transform.rotation);
                }
                if(Input.GetKeyUp(KeyCode.M)){
                    
                    Instantiate(rightBulletMedi,position,rightBullet.transform.rotation);
                }
                if(Input.GetKeyUp(KeyCode.G)){
                    
                    Instantiate(rightBulletGrande,position,rightBullet.transform.rotation);
                }
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            correr();
            
            rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            { 
            saltar();           
            saltarF();
            
            }
           if(Input.GetKeyUp(KeyCode.X)){
             
            Instantiate(rightBullet,position,rightBullet.transform.rotation);
            }
            if(Input.GetKeyUp(KeyCode.M)){
                
                Instantiate(rightBulletMedi,position,rightBullet.transform.rotation);
            }
            if(Input.GetKeyUp(KeyCode.G)){
                
                Instantiate(rightBulletGrande,position,rightBullet.transform.rotation);
            }
            
             
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            correr();
            rb2d.velocity = new Vector2(-speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {
                saltar();
               saltarF();
             
           
            }
            
            
        } 
    }
    public void saltarF(){
        var upSpeed = 80f;
        rb2d.velocity = Vector2.up * upSpeed;
        saltar();
    }
    public void quieto(){
        animator.SetInteger("Estado", 0);        
    }
     public void correr(){
        animator.SetInteger("Estado", 1);        
    }
    
    public void correrDis(){
        animator.SetInteger("Estado", 2);        
    }
     public void saltar(){
        animator.SetInteger("Estado", 3);        
    }
    public void carga(){
        animator.SetInteger("Estado", 4);        
    }
    public void pequenia(){
        p++;        
    }
    public void mediana(){
        m++;        
    }
}