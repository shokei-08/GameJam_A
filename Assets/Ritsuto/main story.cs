using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Image Image; //画像を入れるオブジェクト
    public Sprite title;//タイトル画像
    public Text Q;//質問
    public Text sel1;//選択肢
    public Text sel2;
    public Text sel3;
    public GameObject selans;//選択肢が何を選んでいるか
    public static string kekka;
    private Image img;
    int selNo = 0;
    int page = 0;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = Image.GetComponent<Image>();
        Q.text = "ねぇ、アイとドキドキ恋愛診断ゲームしようよ！！";
        sel1.text = "はい";
        sel2.text = "いいえ";
        sel3.text = "、、、";

    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.Return))
                    page++;
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (selNo > 0) selNo--;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (selNo < 2) selNo++;
                }

                Transform transform = selans.GetComponent<Transform>();
                switch (selNo)
                {
                    case 0:
                        transform.localPosition = new Vector3(0,217,0);
                        break;

                    case 1:
                        transform.localPosition = new Vector3(0,75, 0);
                        break;
                    case 2:
                        transform.localPosition = new Vector3(0, -71, 0);
                        break;
                }

            }
        }
    

