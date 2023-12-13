using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainField: MonoBehaviour
{
    public Text nameText;
    public Text depositText;
    public Text balanceText;
    

    private int balance = 1000000; // 초기 잔액

    private void Start()
    {
        UpdateUI();
    }

    public void DepositButtonClicked()
    {
        SceneManager.LoadScene("InPutScene");
    }

    public void WithdrawButtonClicked()
    {
        SceneManager.LoadScene("OutPutScene");
    }

    private void UpdateUI()
    {
        nameText.text = " "; // 사용자 이름을 여기서 가져오거나 설정
        depositText.text = "예금: $" + balance.ToString();
        balanceText.text = "소지금: $" + balance.ToString();
    }
}