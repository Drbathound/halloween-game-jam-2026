using Godot;
using System;

public class DialogPopup : Label
{

	
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private string _currentText;
	public string CurrentText{
		get => _currentText;
		set{
			_currentText = value;
		}
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {

	  //this.Text = _currentText;
  }
}
