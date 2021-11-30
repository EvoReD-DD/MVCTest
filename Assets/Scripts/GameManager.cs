using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerController _playerController;
    private PlayerModel _playerModel;
    private PlayerView _playerView;

    public void Start()
    {
        _playerModel = new PlayerModel();
        _playerView = new PlayerView();
        _playerController = new PlayerController(_playerView, _playerModel);

        if (SavedData.Player != null)
        {
            Instantiate(SavedData.Player, new Vector3(0, 0.5f, 0), Quaternion.identity);
        }
    }

    public void GeneratePlayer()
    {
        _playerController.PlayerChoose();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
