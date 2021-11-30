using UnityEngine;

public class PlayerModel
{
    private GameObject[] _playerPrefabs;
    private GameObject player;

    public PlayerModel()
    {
        _playerPrefabs = Resources.LoadAll<GameObject>("Prefabs/");
    }
    public void PlayerChoice()
    {
        player = _playerPrefabs[Random.Range(0, _playerPrefabs.Length)];
        SavedData.Player = player;
    }
}
