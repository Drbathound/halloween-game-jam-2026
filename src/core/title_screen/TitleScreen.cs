using Godot;
using System;

public class TitleScreen : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	/* public override void _Ready()
	{
		
	} */
	private void _on_StartGameButton_pressed()
	{
	   GetTree().ChangeScene("res://src/core/main_game/MainGame.tscn");
	}
	private void _on_QuitButton_pressed()
	{
		GetTree().Quit();
	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}






