using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    Animator anim;
    Collider Col;

    InputManager inputManager;

    public bool AttackPressed;

    // Start is called before the first frame update
    void Start()
    {
        inputManager = InputManager.instance;
        anim = GetComponent<Animator>();
        Col = GameObject.Find("Sword").GetComponent<BoxCollider>();
        //Col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackPressed = inputManager.firePressed;
        if (Input.GetMouseButtonDown(0) || AttackPressed)
        {
            anim.SetBool("Attacking", true);
            //Debug.LogError("The button goes down");
        }
        else if(Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Attacking", false);
            //Debug.LogError("The button goes up");
        }

        if (Input.GetMouseButtonDown(0))
        {
            
            Col.enabled = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Col.enabled = false;
        }
    }
}
