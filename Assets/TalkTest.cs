using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkTest : MonoBehaviour
{
    public InputField ipt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickSend() {
        TalkMgr.instance.AddTalkRecord(ipt.text, true);
        Invoke("Reply", Random.Range(1, 4));
    }
    public void Reply() {
        string Repmsg ="";
        for(int i = 0;i < Random.Range(1, 8);i++) 
            Repmsg += "Dummy RecvMsg";
        TalkMgr.instance.AddTalkRecord(Repmsg, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
