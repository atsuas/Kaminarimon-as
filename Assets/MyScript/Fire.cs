using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //ParticleSystem型で変数psを宣言します。
    ParticleSystem ps;
    //Inspectorに設定できるようにpublicを宣言して
    //GameObject型で変数candleを宣言します。
    public GameObject Female;
    //GameObject型で変数objを宣言します。
    GameObject obj;


    void Start()
    {
        //FindメソッドでExplotionのGameObjectにアクセスして
        //変数objで参照します。
        obj = GameObject.Find("Fire");
        //GetComponentでParticleSystemを取得して
        //変数psで参照します。
        ps = obj.GetComponent<ParticleSystem>();
        //変数objを非表示にしてParticleSystemの実行を止めます。
        obj.SetActive(false);
    }

    //GameObjectが接触した時の処理
    private void OnCollisionEnter(Collision collision)
    {
        //もしEboxに接触したら。
        if (collision.gameObject.name == "Female")
        {
            //非表示にしていたobjを表示します。
            obj.SetActive(true);
            //変数ps、ParticleSystemを実行します。
            ps.Play();
            ////2秒後にInspectorに設定してあるGameObjectを非表示にします。
            //Invoke("CandleDisappeard", 2f);
        }
    }
    ////GameObjectを非表示にする処理
    //void CandleDisappeard()
    //{
    //    //Inspector内のcandleに設定された
    //    //GameObjectを非表示にします。
    //    Female.SetActive(false);
    //}
}