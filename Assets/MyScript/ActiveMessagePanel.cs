using UnityEngine;
using System.Collections;

public class ActiveMessagePanel : MonoBehaviour
{

	//　MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private Message messageScript;

	//　表示させるメッセージ
	private string message = "かかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかか"
							 + "ききききききききききききききききききききききききききききききききききききききききききききききききききききききき\n"
							 + "くくくくく\n"
							 + "けけけけけけけけけけけけ";

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			messageScript.SetMessagePanel(message);
		}
	}
}

