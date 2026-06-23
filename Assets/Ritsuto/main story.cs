using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Image Image; //画像を入れるオブジェクト
    public Sprite title;//タイトル画像
    public GameObject selans;
    public Text Q;//質問
    public Text sel1;//選択肢
    public Text sel2;
    public Text sel3;
    public GameObject selans;//選択肢が何を選んでいるか
    private Image img;
    int selNo = 0;
    int page = 0;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = Image.GetComponent<Image>();
        Q.text = "";
        sel1.text = "";
        sel2.text = "";
        sel3.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (page == 1)
            {
                if (selNo != 1)
                {
                    page = 99;
                }

            }
        }
