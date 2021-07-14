using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Animatorcont : MonoBehaviour
{
    //获取小兵的动画组件
    [SerializeField] private Animator soldierAnimator;
    void Update()
    {
        if (Input.GetKey("a"))
        {
            soldierAnimator.SetTrigger("attack");//攻击一次后进入休息状态
            soldierAnimator.SetBool("run",false);
        }
        if (Input.GetKey("r"))
        {
            soldierAnimator.SetBool("run",true);
            soldierAnimator.SetBool("idol",false);//奔跑
        }
        if (Input.GetKey("i"))
        {
            soldierAnimator.SetBool("idol",true);
            soldierAnimator.SetBool("run",false);//休息
        }
    }

    
}
