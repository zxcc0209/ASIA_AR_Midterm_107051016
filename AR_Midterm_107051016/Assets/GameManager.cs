using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("國王")]
    public Transform King;
    [Header("骨頭騎士")]
    public Transform bone;
    [Header("虛擬搖桿")]
    public FixedJoystick Joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("放大縮小"), Range(0, 5f)]
    public float bigsmall = 0.1f;
    [Header("國王動畫元件")]
    public Animator aniKing;
    [Header("骨頭騎士動畫元件")]
    public Animator anibone;

    public float test = 1;
    public float test2 = 1;

    //事件:(藍色)-初始設定
    private void Start()
    {
        print("開始事件設定");
    }
    private void Update()
    {
        print(Joystick.Vertical);       //float 浮點數   //. 取得裡面功能
        bone.Rotate(0, Joystick.Horizontal * turn, 0);
        bone.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * bigsmall;
        King.Rotate(0, Joystick.Horizontal * turn, 0);
        King.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * bigsmall;

        bone.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(bone.localScale.x, 0.5f, 40f);
        King.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(King.localScale.x, 0.5f, 40f);


        test = Mathf.Clamp(test, 0.1f, 10f);
        print(Mathf.Clamp(test2, 0.1f, 10f));
    }
    //方法   修飾詞 類型  名稱(){}
    

    
    //public void Attack(參數)
    //參數  類型 名稱
    public void PlayAnimation(string aniName) 
    {
        aniKing.SetTrigger(aniName);
        anibone.SetTrigger(aniName);
    
    } 
}
