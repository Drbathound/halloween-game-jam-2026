using Godot;
using System;

public class DialogicControl : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private GameOverRoot _gameOverControl;
	private NodePath _gameOverControlPath = "/root/MainGame/GameOverLayer/GameOverRoot";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		/* var dialogic = (Node)GetNode("/root/Dialogic");
		//var dialogNode = (CanvasLayer)dialogic.Call("start", "TestTimeline");
		var dialogNode = (CanvasLayer)dialogic.Call("start", "TestTimeline");
		AddChild(dialogNode); */
		var new_dialog = DialogicSharp.Start("TestTimeline");
		AddChild(new_dialog);
		if(_gameOverControlPath != null){
			_gameOverControl = GetNode<GameOverRoot>(_gameOverControlPath);
			//_gameOverControl.Visible = false;
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		if(_gameOverControl.IsGameOver){
			QueueFree();
		}
	}
}
