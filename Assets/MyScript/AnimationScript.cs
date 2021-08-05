using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationScript : MonoBehaviour
{
    public ParticleSystem ps;
    GameObject obj;
    public Text text;

    private void Start()
    {
        obj = GameObject.Find("Fire");
        ps = obj.GetComponent<ParticleSystem>();
        obj.SetActive(false);
    }

    void ShowText1()
    {
        text.text = "だあー！！";
        obj.SetActive(true);
        ps.Play();
    }

    void ResetText()
    {
        text.text = "";
    }
}
