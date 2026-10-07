using Godot;
using System;
using System.Drawing.Text;

public class LoseRoot : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	private Button _loseButton;

	private readonly NodePath _loseButtonPath = "LoseContainer/LosePanelContainer/VBoxContainer/LoseButton";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_loseButtonPath != null){
			_loseButton = GetNode<Button>(_loseButtonPath);
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		if(_loseButton.Pressed){
			GetTree().Quit();
		}
	}
}
