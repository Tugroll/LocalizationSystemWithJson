using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene("Episode1");
    }
}
