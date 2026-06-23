using UnityEngine;
using UnityEngine.UI;

public class SKManager : MonoBehaviour
{
    public string KEKKA = "A";

    public Text NameText;
    public Text NaiyouText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (KEKKA)
        {
            case "A":
                StateA();
                break;
            case "B":
                StateB();
                break;
            case "C":
                StateC();
                break;
            case "D":
                StateD();
                break;
            case "E":
                StateE();
                break;
            default:
                Debug.Log("認識できない");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void StateA()
    {
        NameText.text = "結果A";
        NaiyouText.text = "結果内容A";
    }

    private void StateB()
    {
        NameText.text = "結果B";
        NaiyouText.text = "結果内容B";
    }

    private void StateC()
    {
        NameText.text = "結果C";
        NaiyouText.text = "結果内容C";
    }

    private void StateD()
    {
        NameText.text = "結果D";
        NaiyouText.text = "結果内容D";
    }

    private void StateE()
    {
        NameText.text = "結果E";
        NaiyouText.text = "結果内容E";
    }
}
