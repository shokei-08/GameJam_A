using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public Sprite image;    //画像1
    public Sprite rogo;　　//タイトルロゴ

    public GameObject selAns;　　//選択カーソル

    public Text select1;　　//選択1
    public Text select2;  //選択2


    private Image img;
    int selNo = 0;　　　　//選択中の答え

    [Header("scene名")]
    public string Game;
    public string End;
    public string Credit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //エンターキーを押したとき
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (selNo == 0)
            {
                SceneManager.LoadScene(Game);
            }

            if (selNo == 1)
            {
                SceneManager.LoadScene(End);
            }

            if (selNo == 2)
            {
                SceneManager.LoadScene(Credit);
            }

        }

        //上キーを押したとき
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (selNo > 0) selNo--;  //一つ上がる
        }

        //下キーを押したとき
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (selNo < 2) selNo++;　//一つ下がる
        }

        //選択カーソルの移動
        Transform transform = selAns.GetComponent<Transform>();
        switch (selNo)
        {
            case 0:　//「はじめる」選択中
                transform.localPosition = new Vector3(0, -115, 0);
                break;
            case 1:　//「やめる」選択中
                transform.localPosition = new Vector3(0, -280, 0);
                break;
            case 2:　//「クレジット」選択中
                transform.localPosition = new Vector3(0, -440, 0);
                break;
        }


    }
}
