using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutPutMoney : MonoBehaviour
{
    public GameObject OutPutMoneyScreen;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OutPutMoneyButtonClick);
    }

    // Update is called once per frame
    public void OutPutMoneyButtonClick()
    {
        OutPutMoneyScreen.SetActive(true);
    }
}
