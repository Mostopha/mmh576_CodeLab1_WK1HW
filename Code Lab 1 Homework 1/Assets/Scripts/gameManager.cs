using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class gameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public GameObject player1Text;
    public GameObject player2Text;


	// Use this for initialization
	void Start () {
        player2Text.SetActive(false);
        player1Text.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (player1 == null)
        {
            player2Text.SetActive(true);
            Invoke("Restart", 2);

        }
        else if(player2 == null)
        {
            player1Text.SetActive(true);
            Invoke("Restart", 2);
        }


	}

    void Restart()
    {

        Scene grief = SceneManager.GetActiveScene();
        SceneManager.LoadScene(grief.name);

    }
}
