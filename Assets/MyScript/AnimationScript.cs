using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationScript : MonoBehaviour
{

    public Text text;

    void ShowText1()
    {
        text.text = "だあー！！";
    }

    //void ShowText2()
    //{
    //    text.text = "ここはどこ？";
    //}

    //void ShowText3()
    //{
    //    text.text = "おーい！";
    //}

    void ResetText()
    {
        text.text = "";
    }
}
