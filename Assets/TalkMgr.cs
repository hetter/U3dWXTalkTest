using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ﾁﾄﾌ・ﾜﾀ暲・
public class TalkMgr : MonoBehaviour
{
    public static TalkMgr instance;

    public GameObject SelfItem, OtherItem;
    public Transform TalkParent;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void AddTalkRecord(string msg, bool IsSelf) {
        GameObject go = Instantiate(IsSelf? SelfItem: OtherItem, TalkParent);
        TalkItem ti = go.GetComponent<TalkItem>();
        ti.SetText(msg);
    }
}
