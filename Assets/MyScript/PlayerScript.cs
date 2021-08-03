using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScript : MonoBehaviour
{
    public FixedJoystick inputMove; //左画面JoyStick
    public float moveSpeed = 5.0f; //移動する速度
    Animator ani;

    float degStop;

    void Start()
    {
        //Animatorを取得
        ani = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Move();
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
