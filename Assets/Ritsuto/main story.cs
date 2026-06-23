using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Image Image; //画像を入れるオブジェクト
    public Text Q;//質問
    public int SENTAKUSI = 2;
    public Text sel1;
    public Text sel2;
    public Text sel3;
    public Text sel4;
    public Text sel5;
    public Text sel6;
    private Vector3 sel1V3;
    private Vector3 sel2V3;
    private Vector3 sel3V3;
    private Vector3 sel4V3;
    private Vector3 sel5V3;
    private Vector3 sel6V3;
    private Vector3 MUSI = new Vector3(0, 700, 0);
    public GameObject selans;//選択肢が何を選んでいるか
    public static string kekka;
    private Image img;
    int selNo = 0;
    int page = 0;
    int message = 0;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        page = 0;
        message = 0;

        img = Image.GetComponent<Image>();
        SENTAKUSI = 0;
        Q.text = "ねぇ、アイとドキドキ恋愛診断ゲームしようよ！！";
        sel1.text = "はい";
        sel2.text = "いいえ";

    }

    // Update is called once per frame
    void Update()
    {
        switch (SENTAKUSI)
        {
            case 0:
                S0();
                break;
            case 2:
                S2();
                break;
            case 3:
                S3();
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

    private void S0()
    {
        Transform sentaku = selans.GetComponent<Transform>();
        Transform sel1t = sel1.GetComponent<Transform>();
        Transform sel2t = sel2.GetComponent<Transform>();
        Transform sel3t = sel3.GetComponent<Transform>();
        Transform sel4t = sel4.GetComponent<Transform>();
        Transform sel5t = sel5.GetComponent<Transform>();
        Transform sel6t = sel6.GetComponent<Transform>();

        sel1V3 = MUSI;
        sel2V3 = MUSI;
        sel3V3 = MUSI;
        sel4V3 = MUSI;
        sel5V3 = MUSI;
        sel6V3 = MUSI;

        sel1t.localPosition = sel1V3;
        sel2t.localPosition = sel2V3;
        sel3t.localPosition = sel3V3;
        sel4t.localPosition = sel4V3;
        sel5t.localPosition = sel5V3;
        sel6t.localPosition = sel6V3;

        sentaku.localPosition = MUSI;
    }

    private void S2()
    {
        Transform sentaku = selans.GetComponent<Transform>();
        Transform sel1t = sel1.GetComponent<Transform>();
        Transform sel2t = sel2.GetComponent<Transform>();
        Transform sel3t = sel3.GetComponent<Transform>();
        Transform sel4t = sel4.GetComponent<Transform>();
        Transform sel5t = sel5.GetComponent<Transform>();
        Transform sel6t = sel6.GetComponent<Transform>();

        sel1V3 = new Vector3(0, 217, 0);
        sel2V3 = new Vector3(0, 75, 0);
        sel3V3 = MUSI;
        sel4V3 = MUSI;
        sel5V3 = MUSI;
        sel6V3 = MUSI;

        sel1t.localPosition = sel1V3;
        sel2t.localPosition = sel2V3;
        sel3t.localPosition = sel3V3;
        sel4t.localPosition = sel4V3;
        sel5t.localPosition = sel5V3;
        sel6t.localPosition = sel6V3;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            page++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNo > 0)
            {
                selNo--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNo < SENTAKUSI - 1)
            {
                selNo++;
            }
        }
        switch (selNo)
        {
            case 0:
                sentaku.localPosition = sel1V3;
                break;
            case 1:
                sentaku.localPosition = sel2V3;
                break;
        }
    }

    private void S3()
    {
        Transform sentaku = selans.GetComponent<Transform>();
        Transform sel1t = sel1.GetComponent<Transform>();
        Transform sel2t = sel2.GetComponent<Transform>();
        Transform sel3t = sel3.GetComponent<Transform>();
        Transform sel4t = sel4.GetComponent<Transform>();
        Transform sel5t = sel5.GetComponent<Transform>();
        Transform sel6t = sel6.GetComponent<Transform>();

        sel1V3 = new Vector3(0, 217, 0);
        sel2V3 = new Vector3(0, 75, 0);
        sel3V3 = new Vector3(0, -71, 0);
        sel4V3 = MUSI;
        sel5V3 = MUSI;
        sel6V3 = MUSI;

        sel1t.localPosition = sel1V3;
        sel2t.localPosition = sel2V3;
        sel3t.localPosition = sel3V3;
        sel4t.localPosition = sel4V3;
        sel5t.localPosition = sel5V3;
        sel6t.localPosition = sel6V3;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            page++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNo > 0)
            {
                selNo--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNo < SENTAKUSI - 1)
            {
                selNo++;
            }
        }
        switch (selNo)
        {
            case 0:
                sentaku.localPosition = sel1V3;
                break;
            case 1:
                sentaku.localPosition = sel2V3;
                break;
            case 2:
                sentaku.localPosition = sel3V3;
                break;
        }
    }
}

