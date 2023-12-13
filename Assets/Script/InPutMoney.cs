using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InPutMoney : MonoBehaviour
{
    public GameObject InPutMoneyScreen;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(InPutMoneyButtonClick);
    }

    // Update is called once per frame
    public void InPutMoneyButtonClick()
    {
        InPutMoneyScreen.SetActive(true);
    }
}
