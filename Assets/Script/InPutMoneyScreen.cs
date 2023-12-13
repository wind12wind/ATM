using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InPutMoneyScreen : MonoBehaviour
{
    public InputField depositAmountInput;
    public Text currentBalanceText;

    private int currentBalance = 1000; // �ʱ� �ܾ�

    private void Start()
    {
        UpdateBalanceUI();
    }

    public void OnDepositButtonClick()
    {
        // �Էµ� �Աݾ� ��������
        int depositAmount = int.Parse(depositAmountInput.text);

        // ���� �ܾ׿� �Աݾ� �߰�
        currentBalance += depositAmount;

        // UI ������Ʈ
        UpdateBalanceUI();

        // �Ա� ȭ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }

    private void UpdateBalanceUI()
    {
        currentBalanceText.text = "���� �ܾ�: $" + currentBalance.ToString();
    }
}
