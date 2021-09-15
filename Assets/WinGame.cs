using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public TextMeshProUGUI endText, resetText;
    private IEnumerator coroutine;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    private void OnDestroy()
    {
        count++;
        if (count == 12)
            RestartLevel();
    }

    void RestartLevel() //Restarts the level
    {
        coroutine = Win(4.0f);
        StartCoroutine(coroutine);
    }

    private IEnumerator Win(float waitTime)
    {
        bool Active = true;

        while (Active)
        {
            endText.SetText("You somehow managed");

            endText.gameObject.SetActive(true);
            resetText.gameObject.SetActive(true);

            for (int i = 5; i > 0; i--)
            {
                resetText.text = "Resetting in: " + (i - 1);
                yield return new WaitForSeconds(waitTime / 4);
            }

            SceneManager.LoadScene("SampleScene");
            Active = false;
        }
    }
}
