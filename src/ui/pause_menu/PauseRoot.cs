using Godot;
using System;

public class PauseRoot : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Button _button;
	private readonly NodePath _buttonPath = "PauseLayer/PauseRoot/CenterContainer/PanelContainer/VBoxContainer/Button";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_buttonPath != null){
			_button = GetNode<Button>(_buttonPath);
		}
		this.Visible = false;	
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	if(_button.Pressed){
		GetTree().Paused = false;
	}
	if(this.Visible == false){
		if(GetTree().Paused){
			this.Visible = true;
	  }
	}
	
	  
  }
}
