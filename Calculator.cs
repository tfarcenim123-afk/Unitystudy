using UnityEngine;
using TMPro;
using System.Collections;

public class Calculator : MonoBehaviour
{
    //숫자 입력
    public TextMeshProUGUI display;
    public int firstNumber;
    public int secondNumber;
    public string modifier;
    public int result;

    void Start()
    {
        OnResetClick();
    }

    public void OnNumberClick(string input)
    {
        display.text += input;
    }

    public void OnModifierClick(string input)
    {
        //첫 번째 입력받은 숫자 저장
        firstNumber = int.Parse(display.text);

        //결과창 공백
        display.text = string.Empty;

        modifier = input;
    }

    public void OnResultClick()
    {
        //두 번째 입력받은 숫자 저장
        secondNumber = int.Parse(display.text);

        //연산자 판정
        switch (modifier)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                result = firstNumber / secondNumber;
                break;
        }

        //결과 출력
        display.text = $"{result}";
    }

    public void OnResetClick()
    {
        //초기화
        display.text = string.Empty;
        firstNumber = 0;
        secondNumber = 0;
        modifier = string.Empty;
        result = 0;
    }
}
