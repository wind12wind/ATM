using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainField: MonoBehaviour
{
    public Text nameText;
    public Text depositText;
    public Text balanceText;
    private int balance = 1000000; // �ʱ� �ܾ�
    private int deposit = 10000;   // �ʱ� ����
    private void Start()
    {
        UpdateUI();
    }

    public void InPutMoneyButtonClicked()
    {
        SceneManager.LoadScene("InPutScene");
    }

    public void OutPutMoneyButtonClicked()
    {
        SceneManager.LoadScene("OutPutScene");
    }

    private void UpdateUI()
    {
        nameText.text = " "; // ����� �̸��� ���⼭ �������ų� ����
        depositText.text = "����: $" + deposit.ToString();
        balanceText.text = "������: $" + balance.ToString();
    }

    public int Getdeposit()
    {
        return deposit;
    }
    public void Setdeposit(int newDeposit)
    {
        balance = newDeposit;
    }
    public int GetBalance()
    {
        return balance;
    }

    public void SetBalance(int newBalance)
    {
        balance = newBalance;
    }
}
