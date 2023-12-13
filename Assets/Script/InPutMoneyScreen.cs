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
            ShowErrorMessage("�Ա� �ݾ��� �ùٸ��� �ʽ��ϴ�.");
        }
    }
    private bool IsDepositValid(int amount)
    {
        return amount > 0; // �Ա� �ݾ��� 0 �̻��̾�� ��ȿ
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
