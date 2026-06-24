using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string SceneName;
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
    private Vector3 MUSI = new Vector3(0, 700, 0);  // 選択肢を使わない場合の選択肢の座標
    public GameObject selans;//選択肢が何を選んでいるか
    public static string kekka = "?";
    int selNoR = 0;
    int selNoC = 0;
    int page = 0;
    int message = 0;
    int bunki = 0;  // どの分岐を選んだか(0は非選択肢用、1から使う)
    int TATIE = 0;

    public Image jansuke;
    public Image bad;
    public Image happy;

    public Image chara1;
    public Image chara2;
    public Image chara3;
    public Image chara4;
    public Image chara5;
    public Image chara6;
    public Image chara7;
    public Image chara8;
    public Image chara9;
    public Image chara10;
    public Image chara11;
    public Image chara12;
    public Image chara13;
    public Image chara14;
    public Image chara15;
    public Image chara16;
    public Image chara17;
    public Image chara18;
    public Image chara19;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        page = 0;
        message = 0;
        SENTAKUSI = 0;
        bunki = 0;
        chara7.enabled = true;

        Q.text = "ねぇ、アイとドキドキ恋愛診断ゲームしようよ！！";
        sel1.text = "はい";
        sel2.text = "いいえ";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PageUpdate();
            selNoR = 0;
            selNoC = 0;
        }

        switch (TATIE)
        {
            case 0:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 6:
                break;
        }

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
                S4();
                break;
            case 6:
                S6();
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

        sel1V3 = new Vector3(0, 145, 0);
        sel2V3 = new Vector3(0, 5, 0);
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNoR > 0)
            {
                selNoR--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNoR < 1)
            {
                selNoR++;
            }
        }

        switch (selNoR)
        {
            case 0:
                sentaku.localPosition = sel1V3;
                bunki = 1;
                break;
            case 1:
                sentaku.localPosition = sel2V3;
                bunki = 2;
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNoR > 0)
            {
                selNoR--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNoR < 2)
            {
                selNoR++;
            }
        }
        switch (selNoR)
        {
            case 0:
                sentaku.localPosition = sel1V3;
                bunki = 1;
                break;
            case 1:
                sentaku.localPosition = sel2V3;
                bunki = 2;
                break;
            case 2:
                sentaku.localPosition = sel3V3;
                bunki = 3;
                break;
        }
    }

    private void S4()
    {
        Transform sentaku = selans.GetComponent<Transform>();
        Transform sel1t = sel1.GetComponent<Transform>();
        Transform sel2t = sel2.GetComponent<Transform>();
        Transform sel3t = sel3.GetComponent<Transform>();
        Transform sel4t = sel4.GetComponent<Transform>();
        Transform sel5t = sel5.GetComponent<Transform>();
        Transform sel6t = sel6.GetComponent<Transform>();

        sel1V3 = new Vector3(-600, 145, 0);
        sel2V3 = new Vector3(-600, 5, 0);
        sel3V3 = new Vector3(0, 145, 0);
        sel4V3 = new Vector3(0, 5, 0);
        sel5V3 = MUSI;
        sel6V3 = MUSI;

        sel1t.localPosition = sel1V3;
        sel2t.localPosition = sel2V3;
        sel3t.localPosition = sel3V3;
        sel4t.localPosition = sel4V3;
        sel5t.localPosition = sel5V3;
        sel6t.localPosition = sel6V3;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNoR > 0)
            {
                selNoR--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNoR < 1)
            {
                selNoR++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (selNoC > 0)
            {
                selNoC--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (selNoC < 1)
            {
                selNoC++;
            }
        }

        switch (selNoC)
        {
            case 0:
                switch (selNoR)
                {
                    case 0:
                        sentaku.localPosition = sel1V3;
                        bunki = 1;
                        break;
                    case 1:
                        sentaku.localPosition = sel2V3;
                        bunki = 2;
                        break;
                }
                break;
            case 1:
                switch (selNoR)
                {
                    case 0:
                        sentaku.localPosition = sel3V3;
                        bunki = 3;
                        break;
                    case 1:
                        sentaku.localPosition = sel4V3;
                        bunki = 4;
                        break;
                }
                break;
        }
    }

    private void S6()
    {
        Transform sentaku = selans.GetComponent<Transform>();
        Transform sel1t = sel1.GetComponent<Transform>();
        Transform sel2t = sel2.GetComponent<Transform>();
        Transform sel3t = sel3.GetComponent<Transform>();
        Transform sel4t = sel4.GetComponent<Transform>();
        Transform sel5t = sel5.GetComponent<Transform>();
        Transform sel6t = sel6.GetComponent<Transform>();

        sel1V3 = new Vector3(-600, 217, 0);
        sel2V3 = new Vector3(-600, 75, 0);
        sel3V3 = new Vector3(-600, -71, 0);
        sel4V3 = new Vector3(0, 217, 0);
        sel5V3 = new Vector3(0, 75, 0);
        sel6V3 = new Vector3(0, -71, 0);

        sel1t.localPosition = sel1V3;
        sel2t.localPosition = sel2V3;
        sel3t.localPosition = sel3V3;
        sel4t.localPosition = sel4V3;
        sel5t.localPosition = sel5V3;
        sel6t.localPosition = sel6V3;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNoR > 0)
            {
                selNoR--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNoR < 2)
            {
                selNoR++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (selNoC > 0)
            {
                selNoC--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (selNoC < 1)
            {
                selNoC++;
            }
        }
        switch (selNoC)
        {
            case 0:
                switch (selNoR)
                {
                    case 0:
                        sentaku.localPosition = sel1V3;
                        bunki = 1;
                        break;
                    case 1:
                        sentaku.localPosition = sel2V3;
                        bunki = 2;
                        break;
                    case 2:
                        sentaku.localPosition = sel3V3;
                        bunki = 3;
                        break;
                }
                break;
            case 1:
                switch (selNoR)
                {
                    case 0:
                        sentaku.localPosition = sel4V3;
                        bunki = 4;
                        break;
                    case 1:
                        sentaku.localPosition = sel5V3;
                        bunki = 5;
                        break;
                    case 2:
                        sentaku.localPosition = sel6V3;
                        bunki = 6;
                        break;
                }
                break;
        }
    }

    private void PageUpdate()
    {
        if (page == 0)
        {
            if (message == 0)
            {
                message++;
                SENTAKUSI = 2;
                sel1.text = "はい";
                sel2.text = "いいえ";
            }
            else if (message == 1 && bunki == 1)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "やったー！アイと診断ゲームしてくれるんだ！";
            }
            else if (message == 1 && bunki == 2)
            {
                SENTAKUSI = 0;
                kekka = "A";
                SceneManager.LoadScene(SceneName);
            }
        }
        else if (page == 1)
        {
            if (message == 0)
            {
                message++;
                Q.text = "じゃあまずは１問目ね！";
            }
            else if (message == 1)
            {
                message++;
                Q.text += "\nおにいさんはアイのこと好き？";
            }
            else if (message == 2)
            {
                message++;
                SENTAKUSI = 3;
                sel1.text = "好き";
                sel2.text = "普通";
                sel3.text = "嫌い";
            }
            else if (message == 3 && bunki == 1)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "やった！アイとっても嬉しい！";
            }
            else if (message == 3 && bunki == 2)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "そっか～…じゃあ好きになってもらえるように頑張るね！";
            }
            else if (message == 3 && bunki == 3)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "う～ん…そ、そうだよね、まだ会ったばっかりだもんね";
            }
        }
        else if (page == 2)
        {
            if (message == 0)
            {
                message++;
                Q.text = "次は２問目ね";
            }
            else if (message == 1)
            {
                message++;
                Q.text += "\nおにいさんは人を好きになるとき見た目と中身どっちが大事？";
            }
            else if (message == 2)
            {
                message++;
                SENTAKUSI = 2;
                sel1.text = "見た目";
                sel2.text = "中身";
            }
            else if (message == 3 && bunki == 1)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "見た目はとっても大事だよね！";
            }
            else if (message == 3 && bunki == 2)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "中身を大事にするのとっても素敵だな～";
            }
        }
        else if (page == 3)
        {
            if (message == 0)
            {
                message++;
                Q.text = "３問目…";
            }
            else if (message == 1)
            {
                message++;
                Q.text += "\n最近嫌な夢見た？";
            }
            else if (message == 2)
            {
                message++;
                Q.text += "\n追われる夢とか…";
            }
            else if (message == 3)
            {
                message++;
                SENTAKUSI = 2;
                sel1.text = "はい";
                sel2.text = "いいえ";
            }
            else if (message == 4)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "・・・・・・";
            }
        }
        else if (page == 4)
        {
            if (message == 0)
            {
                message++;
                Q.text = "ふふふ！、診断ゲーム楽しいね";
            }
            else if (message == 1)
            {
                message++;
                Q.text += "\nおにいさんも楽しい？";
            }
            else if (message == 2)
            {
                message++;
                Q.text += "楽しいよね？";
            }
            else if (message == 3)
            {
                message++;
                Q.text += "\n永遠に続けたくなってきたんじゃない？";
            }
            else if (message == 4)
            {
                message++;
                SENTAKUSI = 2;
                sel1.text = "はい";
                sel2.text = "いいえ";
            }
            else if (message == 5 && bunki == 1)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "お兄さんが楽しんでくれてて嬉しいな！";
            }
            else if (message == 5 && bunki == 2)
            {
                SENTAKUSI = 0;
                Q.text = "";    // 演出を後からがっちゃんこ
                kekka = "B";
                SceneManager.LoadScene(SceneName);

            }
        }
        else if (page == 5)
        {
            if (message == 0)
            {
                message++;
                Q.text = "ねえ、トロッコ問題って知ってる？";
            }
            else if (message == 1)
            {
                message++;
                Q.text = "線路の上には、一台のトロッコが猛スピードで走っています。";
            }
            else if (message == 2)
            {
                message++;
                Q.text += "\nこのままでは、前方で作業している五人がはねられてしまいます。";
            }
            else if (message == 3)
            {
                message++;
                Q.text = "あなたの目の前には、線路を切り替えるレバーがあります。";
            }
            else if (message == 4)
            {
                message++;
                Q.text += "\nレバーを引けば、トロッコは別の線路へ進みます。";
            }
            else if (message == 5)
            {
                message++;
                Q.text = "——けれど、その線路の先にも、一人の人がいます。";
            }
            else if (message == 6)
            {
                message++;
                Q.text += "\nあなたがレバーを引けば、一人が犠牲になり、五人が助かります。";
            }
            else if (message == 7)
            {
                message++;
                Q.text += "\n何もしなければ、五人が犠牲になります。";
            }
            else if (message == 8)
            {
                message++;
                Q.text = "あなたはどうしますか?";
            }
            else if (message == 9)
            {
                message++;
                SENTAKUSI = 4;
                sel1.text = "一人を犠牲にする";
                sel2.text = "五人を見殺しにする";
                sel3.text = "ミンナシンジャエ";
                sel4.text = "■■■";
            }
            else if (message == 10)
            {
                page++;
                message = 0;
                SENTAKUSI = 0;
                bunki = 0;
                Q.text = "";
            }
        }
        else if (page == 6)
        {
            if (message == 0)
            {
                message++;
                Q.text = "これ、最後の質問だよ。";
            }
            else if (message == 1)
            {
                message++;
                Q.text += "大事な質問。";
            }
            else if (message == 2)
            {
                message++;
                Q.text += "\n私をどうやって殺しますか？(文字化け)";
            }
            else if (message == 3)
            {
                message++;
                SENTAKUSI = 6;
                sel1.text = "(文字化け)";
                sel2.text = "(文字化け)";
                sel3.text = "(文字化け)";
                sel4.text = "(文字化け)";
                sel5.text = "(文字化け)";
                sel6.text = "(文字化け)";
            }
            else if (message == 4 && bunki == 1)
            {
                message++;
                SENTAKUSI = 0;
                bad.enabled = true;
                kekka = "C";
            }
            else if (message == 4 && bunki == 2)
            {
                message++;
                SENTAKUSI = 0;
                bad.enabled = true;
                kekka = "C";
            }
            else if (message == 4 && bunki == 3)
            {
                message++;
                SENTAKUSI = 0;
                happy.enabled = true;
                kekka = "D";
            }
            else if (message == 4 && bunki == 4)
            {
                message++;
                SENTAKUSI = 0;
                bad.enabled = true;
                kekka = "C";
            }
            else if (message == 4 && bunki == 5)
            {
                message++;
                SENTAKUSI = 0;
                bad.enabled = true;
                kekka = "C";
            }
            else if (message == 4 && bunki == 6)
            {
                message++;
                SENTAKUSI = 0;
                bad.enabled = true;
                kekka = "C";
            }
            else if (message == 5)
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }
}

