using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InPutMoneyScreen : MonoBehaviour
{
    public InputField depositAmountInput;
    public Text errorMessageText;
    public MainField mainfield;

    private void Start()
    {
        errorMessageText.gameObject.SetActive(false);
    }

    public void DepositButtonClicked()
    {
        int depositAmount = int.Parse(depositAmountInput.text);

        if (IsDepositValid(depositAmount))
        {
            PerformDeposit(depositAmount);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            ShowErrorMessage("입금 금액이 올바르지 않습니다.");
        }
    }
    private bool IsDepositValid(int amount)
    {
        return amount > 0; // 입금 금액이 0 이상이어야 유효
    }

    private void PerformDeposit(int amount)
    {
        int currentBalance = mainfield.GetBalance();
        currentBalance += amount;
        mainfield.SetBalance(currentBalance);
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
