// (c) Meta Platforms, Inc. and affiliates. Confidential and proprietary.

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Load the LLM Sample scene
    public void LoadLlmSample()
    {
        SceneManager.LoadScene("LLM Sample");
    }

}
