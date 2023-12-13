using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OutPutMoneyScreen : MonoBehaviour
{
    public InputField withdrawAmountInput;
    public Text errorMessageText;
    private void Start()
    {
        errorMessageText.gameObject.SetActive(false);
    }

    public void OutPutMoneyButtonClicked()
    {
        int withdrawAmount = int.Parse(withdrawAmountInput.text);

        if (IsWithdrawValid(withdrawAmount))
        {
            PerformWithdraw(withdrawAmount);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            ShowErrorMessage("잔액이 부족합니다.");
        }
    }

    private bool IsWithdrawValid(int amount)
    {
        // 출금 가능 여부 확인 로직
        return amount > 0 && amount <= GetCurrentBalance();
    }

    private void PerformWithdraw(int amount)
    {
        // 출금 처리 로직
        int currentBalance = GetCurrentBalance();
        currentBalance -= amount;
        SaveCurrentBalance(currentBalance);
    }
    private int GetCurrentBalance()
    {
 
        return PlayerPrefs.GetInt("CurrentBalance", 0);
    }

    private void SaveCurrentBalance(int balance)
    {

        PlayerPrefs.SetInt("CurrentBalance", balance);
    }

    private void ShowErrorMessage(string message)
    {
        errorMessageText.text = message;
        errorMessageText.gameObject.SetActive(true);
    }

    public void ReturnButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
