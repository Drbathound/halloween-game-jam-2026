using Godot;
using System;
using System.Drawing.Text;
using System.Dynamic;
using System.Runtime.Serialization;

public class MainGame : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Node2D _levelNode;
	private Node2D _entityNode;
	private Node2D _effectNode;
	private readonly NodePath _levelRoot = "World/LevelRoot";
	private readonly NodePath _entityRoot = "World/EntityRoot";
	private readonly NodePath _effectRoot = "World/EffectRoot";

	private Control _hudNode;
	private Control _pauseNode;
	private Control _transitionNode;
	private readonly NodePath _hudRoot = "HudLayer/HudRoot";
	private readonly NodePath _pauseRoot = "PauseLayer/PauseRoot";
	private readonly NodePath _transitionRoot = "TransitionLayer/TransitionRoot";

	private Player myplayer = new Player();
	private Label _dialogboxLabel;
	private readonly NodePath _dialogPopup = "HudLayer/HudRoot/CenterContainer/PanelContainer/VBoxContainer/DialogPopup";
	private GameOverRoot _gameOverControl;
	private NodePath _gameOverControlPath = "GameOverLayer/GameOverRoot";
	/* private Control _loseRoot;
	private NodePath _loseRootPath = "GameOverLayer/LoseRoot";
	private Control _winRoot;
	private NodePath _winRootPath = "GameOverLayer/LoseRoot"; */
	/* private ColorRect _gameOverBox;
	private readonly NodePath _gameOverBoxPath = "HudLayer/HudRoot/GameOverControl/GameOverBox"; */
	//private var dialogic = Engine.GetSingleton("Dialogic");
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		/* var dialogic = (Node)GetNode("/root/Dialogic");
		var dialogNode = (CanvasLayer)dialogic.Call("start", "TestTimeline");
		AddChild(dialogNode); */
		/* var new_dialog = DialogicSharp.Start("TestTimeline");
		AddChild(new_dialog); */
		/* if(_loseRootPath != null){
			_loseRoot = GetNode<Control>(_loseRootPath);
			_loseRoot.Visible = false;
		}
		if(_winRootPath != null){
			_winRoot = GetNode<Control>(_winRootPath);
			_winRoot.Visible = false;
		} */
		if(_gameOverControlPath != null){
			_gameOverControl = GetNode<GameOverRoot>(_gameOverControlPath);
			//_gameOverControl.Visible = false;
		}
		/* if(_gameOverBoxPath != null){
			_gameOverBox = GetNode<ColorRect>(_gameOverBoxPath);
			_gameOverBox.Visible = false;
			_gameOverBox.MouseFilter = Control.MouseFilterEnum.Ignore;
		} */
		if(_levelRoot != null){
			_levelNode = GetNode<Node2D>(_levelRoot);
		}
		if(_entityRoot != null){
			_entityNode = GetNode<Node2D>(_entityRoot);
		}
		if(_effectRoot != null){
			_effectNode = GetNode<Node2D>(_effectRoot);
		}
		if(_hudRoot != null){
			_hudNode = GetNode<Control>(_hudRoot);
		}
		if(_pauseRoot != null){
			_pauseNode = GetNode<Control>(_pauseRoot);
		}
		if(_transitionRoot != null){
			_transitionNode = GetNode<Control>(_transitionRoot);
		}
		if(_dialogPopup != null){
			_dialogboxLabel = GetNode<Label>(_dialogPopup);
		}
		
		_dialogboxLabel.Text = "hello world";
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	  if(Input.IsActionJustPressed("ui_accept")){
		_dialogboxLabel.Text = "test";
	  }
	  if(Input.IsActionJustPressed("ui_cancel")){
		GetTree().Paused = true;
	  }
	  /* if(_gameOverControl.IsGameOver){
		QueueFree();
	  } */
  }
}
