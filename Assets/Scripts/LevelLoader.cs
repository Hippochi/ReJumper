/*  LevelLoader - By Alex Dine
 *  101264627
 *  November 19th 2021
 *  a scene script that manges my scenes v1
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    float delayTime = 0.5f;

    private void Update()
    {
        //need to add in load for when player dies
    }

    public void LoadMenu(){ StartCoroutine(MenuDelay()); }
    public void LoadHowTo() { StartCoroutine(HowToDelay()); }
    public void LoadPlay() { StartCoroutine(PlayDelay()); }
    public void LoadGameOver() { StartCoroutine(GameOverDelay()); }

    private IEnumerator MenuDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("MenuScene");
    }

    private IEnumerator HowToDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("HowToScene");
    }

    private IEnumerator PlayDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("PlayScene");
    }

    private IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("GameOverScene");
    }
}
