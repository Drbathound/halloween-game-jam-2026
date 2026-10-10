using Godot;
using System;

public class RestartControl : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private GameOverRoot _gameOverControl;
	private readonly NodePath _gameOverControlPath = "/root/MainGame/GameOverLayer/GameOverRoot";
	private Button _restartButton;
	private Button _quitButton;
	private CenterContainer _buttonContainer;
	private readonly NodePath _buttonContainerPath = "CenterContainer";
	private readonly NodePath _restartButtonPath = "CenterContainer/PanelContainer/VBoxContainer/restartbutton";
	private readonly NodePath _quitButtonPath2 = "CenterContainer/PanelContainer/VBoxContainer/quitbutton";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_restartButtonPath != null){
			_restartButton = GetNode<Button>(_restartButtonPath);
			//_restartButton.Visible = false;
		}
		if (_quitButtonPath2 != null){
			_quitButton = GetNode<Button>(_quitButtonPath2);
			//_quitButton.Visible = false;
		}
		if(_buttonContainer != null){
			_buttonContainer = GetNode<CenterContainer>(_buttonContainerPath);
			//_buttonContainer.Visible = false;
		}
		if(_gameOverControlPath != null){
			_gameOverControl = GetNode<GameOverRoot>(_gameOverControlPath);
			_gameOverControl.Connect(nameof(GameOverRoot.GameOver), this, nameof(OnGameOver));
			//_gameOverControl.Visible = false;
		}
		this.Visible = false;
	}
	private void OnGameOver(string input){
		_restartButton.Text = input;
		this.Visible = true;
	}
	private void _on_restartbutton_pressed()
	{
		GetTree().ReloadCurrentScene();
	} 
	private void _on_quitbutton_pressed()
	{
		GetTree().Quit();
	}
	
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
