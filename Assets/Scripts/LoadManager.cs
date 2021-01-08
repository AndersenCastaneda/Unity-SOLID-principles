using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.OnDead += RestartLevel;
        Player.OnGoal += RestartLevel;
    }

    private void OnDisable()
    {
        Player.OnDead -= RestartLevel;
        Player.OnGoal -= RestartLevel;
    }

    private void RestartLevel() => StartCoroutine(LoadScene("maze", 3f));

    private IEnumerator LoadScene(string scene, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(scene);
    }
}
