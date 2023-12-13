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
    

    private int balance = 1000000; // �ʱ� �ܾ�

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
        nameText.text = " "; // ����� �̸��� ���⼭ �������ų� ����
        depositText.text = "����: $" + balance.ToString();
        balanceText.text = "������: $" + balance.ToString();
    }
}