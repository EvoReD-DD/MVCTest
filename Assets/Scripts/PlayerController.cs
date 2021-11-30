
public class PlayerController
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;

   public PlayerController(PlayerView view, PlayerModel model)
    {
        _playerView = view;
        _playerModel = model;
    }

    public void PlayerChoose()
    {
        _playerModel.PlayerChoice();
        _playerView.ShowPlayer();
    }
}
