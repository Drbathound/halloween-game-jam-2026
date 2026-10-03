using Godot;
using System;
using System.Drawing.Text;
using System.Dynamic;

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
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
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
  }
}
