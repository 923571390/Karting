using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLastScene()
    {
        Application.LoadLevel(ddd.stage + 3);
    }
    public void LoadThisScene()
    {
        Application.LoadLevel(ddd.stage + 3);
    }
}
