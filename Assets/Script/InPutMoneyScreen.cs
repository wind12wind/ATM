using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InPutMoneyScreen : MonoBehaviour
{
    public InputField depositAmountInput;
    public Text currentBalanceText;

    private int currentBalance = 1000; // 초기 잔액

    private void Start()
    {
        UpdateBalanceUI();
    }

    public void OnDepositButtonClick()
    {
        // 입력된 입금액 가져오기
        int depositAmount = int.Parse(depositAmountInput.text);

        // 현재 잔액에 입금액 추가
        currentBalance += depositAmount;

        // UI 업데이트
        UpdateBalanceUI();

        // 입금 화면 비활성화
        gameObject.SetActive(false);
    }

    private void UpdateBalanceUI()
    {
        currentBalanceText.text = "현재 잔액: $" + currentBalance.ToString();
    }
}
