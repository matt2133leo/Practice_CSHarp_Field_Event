
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header ("移動速度"), Range(0f , 100f),Tooltip ("小雞的移動速度")]
    public float Speed = 10f;

    [Header("跳躍高度"), Range(0, 2000), Tooltip("小雞的跳躍高度")]
    public int Jump = 10;

    [Header("說話內容"), Tooltip("小雞說話內容")]
    public string Talk;

    [Header("小雞是否取得蛋"), Tooltip("小雞身上是否有蛋")]
    public bool Egg;

    private string gamestart = "開始找蛋囉";


    private void Start()
    {
        print(gamestart);
    }

    private void Update()
    {
        print(Talk); 
    }

}
