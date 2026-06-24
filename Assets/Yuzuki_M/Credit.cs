using UnityEngine;
using UnityEngine.UI;


public class Cradit : MonoBehaviour
{
    public Image image1;    //画像1

    public Sprite sprite1;    //画像1
    public Sprite sprite2;    //画像2
    public Sprite sprite3;    //画像3

    private Image img;
    private int page = 0;　//ページ番号

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //image1からImageコンポーネントを取得
        img = image1.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //エンターキーを押したとき
        if (Input.GetKeyDown(KeyCode.Return))
        {
            page++; //1を足す(インクリメント)
            if (page == 2)
            {
                //最後のページまで来たら最初に戻す
                page = 0;
            }

            switch (page)
            {
                case 0: //0ページ目
                    img.sprite = sprite1;　//画像1に切り替え
                    break;
                case 1: //1ページ目
                    img.sprite = sprite2;
                    break;
            }
        }
    }
}
