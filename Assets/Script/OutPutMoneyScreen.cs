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
            ShowErrorMessage("�ܾ��� �����մϴ�.");
        }
    }

    private bool IsWithdrawValid(int amount)
    {
        // ��� ���� ���� Ȯ�� ����
        return amount > 0 && amount <= GetCurrentBalance();
    }

    private void PerformWithdraw(int amount)
    {
        // ��� ó�� ����
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
