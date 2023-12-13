using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InPutMoney : MonoBehaviour
{
    public GameObject depositScreen;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnDepositButtonClick);
    }

    // Update is called once per frame
    void OnDepositButtonClick()
    {
        depositScreen.SetActive(true);
    }
}
