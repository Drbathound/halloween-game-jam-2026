using Godot;
using System;

public class BarVapeControl : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
    
    //test button, replace with both the beer and vape progress bar and buttons
    //  and set for different timeouts and addition intervals
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
	public override void _Process(float delta)
	{
        //we can probably switch this out now for the pressed() signal in the button
        //  to make it like the timer function below
		if(_button.Pressed){
			_textureProgressNode.Value += 25;
		}
	}
    //the signal in the Timer 
	private void _on_Timer_timeout()
	{
		_textureProgressNode.Value -= 1;
		// Replace with function body.
	}
	

}





