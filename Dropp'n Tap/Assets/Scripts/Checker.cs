using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    GoodEnemy enemy1;
    Enemy1 enemy2;
    Enemy0 enemy3;
    SlowMoEnemy enemy4;
    BadEnemy enemy5;

    public int health = 5;

    public GameObject deadPanel;

    CameraAnimation _anim;

    public int score = 0;
   

    private void Update()
    {
        Dead();
        
        enemy1 = FindObjectOfType<GoodEnemy>();
        enemy2 = FindObjectOfType<Enemy1>();
        enemy3 = FindObjectOfType<Enemy0>();
        enemy4 = FindObjectOfType<SlowMoEnemy>();
        enemy5 = FindObjectOfType<BadEnemy>();

        _anim = FindObjectOfType<CameraAnimation>();
      

        
    }



    public void Enemy1()
    {
        if (health > 0)
        {
            score += 100;
        }
    }

    public void Enemy2()
    {
        if(health > 0)
        {
            if (enemy1 != null)
            {
                Debug.Log("Wrong Enemy 2");
                health--;
                _anim.anim.SetTrigger("Hit");
            }
            else
            {
                score += 100;
            }

           
         
        }
       
    }

    public void Enemy3()
    {
        if (health > 0)
        {
            if (enemy1 != null || enemy2 != null)
            {
                Debug.Log("Wrong Enemy 3");
                health--;
                _anim.anim.SetTrigger("Hit");
            }
            else
            {
                score += 100;
            }
            
        }


    }

    public void Enemy4()
    {
        if (health > 0)
        {
            if (enemy1 != null || enemy2 != null || enemy3 != null)
            {
                Debug.Log("Wrong Enemy 4");
                health--;
                _anim.anim.SetTrigger("Hit");
            }
            else
            {
                score += 100;
            }

        }



    }
   
    public void Enemy5()
    {
        if(health > 0)
        {
            if (enemy1 != null || enemy2 != null || enemy3 != null || enemy4 != null)
            {
                Debug.Log("Wrong Enemy 5");
                health--;
                _anim.anim.SetTrigger("Hit");
            }
            else
            {
                score += 100;
            }

        }
       

    }

    public void Dead()
    {
        if(health == 0)
        {
            if (deadPanel != null)
            {
                deadPanel.SetActive(true);
              
            }

                
        }
        

    }

   
}
