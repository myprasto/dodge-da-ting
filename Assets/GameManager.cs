using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float killCam = 15f;

	public void EndGame ()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {

        Time.timeScale = 1f / killCam;
        Time.fixedDeltaTime = Time.fixedDeltaTime / killCam;

        yield return new WaitForSeconds(1f / killCam);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
