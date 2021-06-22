using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;


public class SceneSwitcher : MonoBehaviour
{
   [MenuItem("EditorScript/Load MainMenu Scene %#m")]
   static void OpenSceneFunction()
    {
        Debug.Log("Ye le khail");
        //UnityEditor.SceneManagement.OpenSceneMode("path of scene",openscene)
        EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity", OpenSceneMode.Single);
    }
}
