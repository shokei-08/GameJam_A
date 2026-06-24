using UnityEngine;
using UnityEngine.UI;

public class SKManager : MonoBehaviour
{
    public Text NameText;
    public Text NaiyouText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string KEKKA = NewMonoBehaviourScript.kekka;

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
        NameText.text = "もう少し心を開こうend";
        NaiyouText.text = "オマエはもう少し人と会話したほうがいいクマ！\r\n早とちりは感心しないクマよ。話し合いはコミュニケーションの基本、精進するクマ！\r\n";
    }

    private void StateB()
    {
        NameText.text = "気の利く人間になれend";
        NaiyouText.text = "あの流れでいいえを選ぶなんて信じられないクマ！\r\nオマエには人の心がないのかクマ？そんなやつはろくな死に方しないクマよ！";
    }

    private void StateC()
    {
        NameText.text = "殺害end";
        NaiyouText.text = "あ～あ、やっぱり殺しちゃったクマね！\r\nあれだけ大事だと念押しされたのに適当に選ぶからこうなるクマ！\r\nこれとは違った未来もあったかもしれないのに…ヒドいやつクマ！";
    }

    private void StateD()
    {
        NameText.text = "まじめだねend";
        NaiyouText.text = "オマエはくそまじめか運がいいかのどっちかクマ！\r\nでも、殺さない選択肢を見つけたのは素直に褒めるクマよ！\r\nその調子ならなんかいいことあるかもクマね！";
    }

    private void StateE()
    {
        NameText.text = "結果E";
        NaiyouText.text = "結果内容E";
    }
}
