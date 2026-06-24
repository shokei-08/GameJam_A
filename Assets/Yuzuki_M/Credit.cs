using UnityEngine;
using UnityEngine.UI;


public class Story : MonoBehaviour
{
    public Image image1;    //画像1
    //public Image image2;    //画像2
    public Text text1;　　　　//文章
    public GameObject panel;　//パネル

    public Sprite sprite1;    //画像1
    public Sprite sprite2;    //画像2

    private Image img;
    private int page = 0;　//ページ番号

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //image1からImageコンポーネントを取得
        img = image1.GetComponent<Image>();
        text1.text = ""; //
        panel.SetActive(false);　//パネルを非表示
    }

    // Update is called once per frame
    void Update()
    {
        //エンターキーを押したとき
        if (Input.GetKeyDown(KeyCode.Return))
        {
            page++; //1を足す(インクリメント)
            if (page == 4)
            {
                //最後のページまで来たら最初に戻す
                page = 0;
            }

            //image1.enabled = false;  //画像1を表示
            //image2.enabled = true; //画像2を非表示

            switch (page)
            {
                case 0: //0ページ目
                    img.sprite = sprite1;　//画像1に切り替え
                    break;
                case 1: //1ページ目
                    img.sprite = sprite2;
                    break;
                case 2: //2ページ目
                    img.sprite = sprite3;
                    break;

                case 3: //3ページ目
                    img.sprite = sprite4;
                    break;
            }
        }
    }
}
