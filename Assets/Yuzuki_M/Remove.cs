using UnityEngine;
using UnityEngine.SceneManagement;

public class Remove : MonoBehaviour
{

    [Header("scene名")]
    public string Title;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GotoTitle()
    {
        SceneManager.LoadScene(Title);
    }

}
