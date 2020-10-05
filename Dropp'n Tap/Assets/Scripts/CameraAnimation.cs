using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{

    public Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
}
