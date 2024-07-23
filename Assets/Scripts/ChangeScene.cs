using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Scene에서 특정 Scene으로 이동하는 Function
    public int sceneNum = 1;

    public void Change()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
