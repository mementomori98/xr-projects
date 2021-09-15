using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseGame : MonoBehaviour
{
    public TextMeshProUGUI endText, resetText;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        endText.gameObject.SetActive(false);
        resetText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RestartLevel() //Restarts the level
    {
        coroutine = Loss(5.0f);
        StartCoroutine(coroutine);
    }

    private IEnumerator Loss(float waitTime)
    {
        bool Active = true;

        while (Active)
        {

            endText.gameObject.SetActive(true);
            resetText.gameObject.SetActive(true);

            for (int i = 5; i >= 0; i--)
            {
                resetText.text = "Resetting in: " + (i - 1);
                yield return new WaitForSeconds(waitTime / 5);
            }

            SceneManager.LoadScene("SampleScene");
            Active = false;
        }
    }
}
