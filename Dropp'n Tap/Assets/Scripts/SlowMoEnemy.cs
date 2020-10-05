using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoEnemy : MonoBehaviour
{
    private Rigidbody2D rb;

    private CameraAnimation animm;

    Checker checker;

    private float gravityScale;
    public ParticleSystem effect;
    public ParticleSystem lavaEffect;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravityScale = Random.Range(0.2f, 0.6f);
        animm = FindObjectOfType<CameraAnimation>();
        checker = FindObjectOfType<Checker>();
    }


    void Update()
    {
        rb.gravityScale = gravityScale;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                   
                    Destroy(gameObject);
                    Instantiate(effect, transform.position, Quaternion.identity);
         
                 
                }
            }
        }

    }

    private void OnDestroy()
    {
        checker.Enemy4();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Lava")
        {
            if(checker.health > 0)
            {
                Instantiate(lavaEffect, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
                animm.anim.SetTrigger("Hit");
                Debug.Log("Lava Enemy 4");
                checker.health -= 1;
            }
            else
            {
                checker.Dead();
                Instantiate(lavaEffect, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
           
    }
}