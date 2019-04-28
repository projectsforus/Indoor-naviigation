using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    Animator anim;
    int jumpHash = Animator.StringToHash("wave");
    int runStateHash = Animator.StringToHash("Base Layer.idle");


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("speed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
        {
            anim.SetTrigger(jumpHash);
        }
    }
}
