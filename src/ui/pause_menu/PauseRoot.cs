using Godot;
using System;

public class PauseRoot : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Button _button;
	private Button _button2;
	private readonly NodePath _buttonPath = "CenterContainer/PanelContainer/VBoxContainer/Button";
	private readonly NodePath _buttonPath2 = "CenterContainer/PanelContainer/VBoxContainer/Button2";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_buttonPath != null){
			_button = GetNode<Button>(_buttonPath);
		}
		if (_buttonPath2 != null){
			_button2 = GetNode<Button>(_buttonPath2);
		}
		this.Visible = false;	
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	if(_button.Pressed){
		GetTree().Paused = false;
		this.Visible = false;
	}
	if(this.Visible == false){
		if(GetTree().Paused){
			this.Visible = true;
	  }
	}
	
	// Quit button functionality may be better to move into the button
	if(_button2.Pressed){
		GetTree().Quit();
	}
	
  }
}
