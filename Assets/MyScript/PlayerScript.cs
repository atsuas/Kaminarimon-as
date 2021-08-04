using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour
{
    public FixedJoystick inputMove; //左画面JoyStick
    public float moveSpeed = 5.0f; //移動する速度
    Animator ani;

    //private Ray ray;

    //public Camera mainCamera;

    float degStop;

    //public override void Visit(ItemAcceptor acceptor)
    //{
    //    acceptor.Accept(this);
    //    ani.SetTrigger("Pickup");
    //}

    //public override void Visit(DoorAcceptor acceptor)
    //{
    //    acceptor.Accept(this);
    //    Debug.Log("フィールドを移動する処理");
    //}

    //public override void Visit(ActorAcceptor acceptor)
    //{
    //    acceptor.Accept(this);
    //    Debug.Log("会話モードへ移行する処理");
    //}

    void Start()
    {
        //Animatorを取得
        ani = this.gameObject.GetComponent<Animator>();

        //ray = new Ray();
    }

    void Update()
    {
        Move();

        //if (Input.GetMouseButtonDown(0))
        //{
        //    ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        //    {
        //        GameObject game = hit.collider.gameObject;

        //        ItemAcceptor item = game.GetComponent<ItemAcceptor>();
        //        if (item != null) Visit(item);

        //        DoorAcceptor door = game.GetComponent<DoorAcceptor>();
        //        if (door != null) Visit(door);

        //        ActorAcceptor actor = game.GetComponent<ActorAcceptor>();
        //        if (actor != null) Visit(actor);
        //    }
        //}
    }

    void Move()
    {
        float dx = inputMove.Horizontal; //joystickの水平方向の動きの値、-1~1の値をとる
        float dy = inputMove.Vertical; //joystickの垂直方向の動きの値、-1~1の値をとる

        float rad = Mathf.Atan2(dx - 0, dy - 0); //原点(0,0)と点（dx,dy)の距離から角度をとってくれる便利な関数

        float deg = rad * Mathf.Rad2Deg; //radianからdegreenに変換する

        this.transform.rotation = Quaternion.Euler(0, deg, 0); //Playerの向きを先ほど取得した角度に当てはめて代入する。今回はy軸方向が回転軸になる。

        if (deg != 0) //joystickの原点と(dx,dy)の２点がなす角度が０ではないとき = joystickを動かしている時
        {
            ani.SetBool("Walk", true); //wait→walkへ
            this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime; //正面方向へプレイヤーを移動させ続ける

            degStop = deg; //停止前のプレイヤーの向きを保存
        }
        else //joystickの原点と(dx,dy)の２点がなす角度が０の時 = joystickが止まっている時
        {
            ani.SetBool("Walk", false); //walk→waitへ

            this.transform.rotation = Quaternion.Euler(0, degStop, 0); //停止時のプレイヤーの動きの向きを設定
        }
    }

    //ボタンを押したら攻撃する
    public void AttackButton()
    {
        ani.SetTrigger("Attack");
    }

    //ボタンを押したらアイテムを掴む
    public void PickupButton()
    {
        ani.SetTrigger("Pickup");
    }
}
