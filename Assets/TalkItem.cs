using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkItem : MonoBehaviour
{
    public Text Msgtext;
    public RectTransform TextBGRect,MsgRect,ItemRect;
    public ContentSizeFitter TextCSF;
    public Vector2 SizeScal = new Vector2(20, 20);
    public float TextMaxWidth = 360;


    // Update is called once per frame
    void Update()
    {
        //ReCSF();
    }

    public void SetText(string msg) {
        Msgtext.text = msg;
        ReCSF();
    }

    private IEnumerator DelayMethod(float waitTime, Action action)
    {
        //yield return new WaitForEndOfFrame();
        yield return null;
        action();
    }

    void ReCSF()
    {
        TextCSF.enabled = false;
        if (Msgtext.preferredWidth >= TextMaxWidth)
        {
            MsgRect.sizeDelta = new Vector2(TextMaxWidth, 0);
            TextCSF.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
            TextCSF.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
        else
        {
            TextCSF.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            TextCSF.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
        TextCSF.enabled = true;

        StartCoroutine(DelayMethod(3.5f, () =>
        {
            ResetSize();
        }));

        //Invoke("ResetSize", 0.2f);
    }
    private void ResetSize()
    {
        TextBGRect.sizeDelta = MsgRect.sizeDelta + SizeScal;
        ItemRect.sizeDelta = new Vector2(ItemRect.sizeDelta.x, TextBGRect.sizeDelta.y);
        transform.localScale = Vector3.one;
    }
}
