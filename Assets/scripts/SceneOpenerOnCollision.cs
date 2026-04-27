using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneOpenerOnCollision : Screen_Opener
{
   public string NextLevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OpenScene(NextLevelName);
    }
}
