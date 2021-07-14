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
            soldierAnimator.runtimeAnimatorController= Resources.Load<RuntimeAnimatorController>("animation/Attack");//攻击
            Invoke(nameof(AttackForRest),1f);//一秒后攻击后切换为休息状态
        }
        if (Input.GetKey("r"))
        {
            soldierAnimator.runtimeAnimatorController= Resources.Load<RuntimeAnimatorController>("animation/Run"); // 奔跑
        }
        if (Input.GetKey("i"))
        {
            soldierAnimator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("animation/Rest");//休息
        }
    }

    private void AttackForRest()
    {
        soldierAnimator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("animation/Rest");//休息
    }
```

