# 模拟小兵控制

## 整体结构

通过键盘控制小兵，键盘输入a，r，i 小兵分别会执行攻击，奔跑，休息的动画效果，攻击后小兵会进入休息状态

## 代码结构

在小兵的update函数中写判断是否有键入输入，如果有，通过代码赋值动态改变animatorController的内容。

```c#
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
```

