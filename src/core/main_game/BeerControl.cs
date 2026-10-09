using Godot;
using System;

public class BeerControl : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	private TextureProgress _textureProgressNode;
	private readonly NodePath _textureProgressPath = "TextureProgress";
	private Button _button;
	private readonly NodePath _buttonPath = "Button";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_textureProgressPath != null){
			_textureProgressNode = GetNode<TextureProgress>(_textureProgressPath);
		}
		if(_buttonPath != null){
			_button = GetNode<Button>(_buttonPath);
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//currently allows the player to hold the button to keep adding per frame
	public override void _Process(float delta)
	{
		//we can probably switch this out now for the pressed() signal in the button
		//  to make it like the timer function below
		/* if(_button.Pressed){
			_textureProgressNode.Value += 5;
		} */
	}
	//the signal in the Timer 
	private void _on_Timer_timeout()
	{
		_textureProgressNode.Value -= 5;
		// Replace with function body.
	}
	private void _on_Button_pressed()
	{
		// Replace with function body.
		//_textureProgressNode.Value += 25;
		_textureProgressNode.Value += GD.RandRange(10,30);
	}

}


