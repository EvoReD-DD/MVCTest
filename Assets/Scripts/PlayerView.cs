using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _generate;


    public void ShowPlayer()
    {
        if (SavedData.Player != null)
        {
            Debug.Log("Destroy");
            Destroy(GameObject.FindWithTag("Player"));
        }
        Instantiate(SavedData.Player, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }

}
