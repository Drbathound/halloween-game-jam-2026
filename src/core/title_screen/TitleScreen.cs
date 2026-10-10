using Godot;
using System;

public class TitleScreen : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private ItemList _creditsList;
	private readonly NodePath _creditsListPath = "CreditsList";
	private Button _closeCreditsButton;
	private readonly NodePath _closeCreditsButtonPath = "CloseCreditsButton";
	// Called when the node enters the scene tree for the first time.
	 public override void _Ready()
	{
		if( _creditsListPath != null){
			 _creditsList = GetNode<ItemList>( _creditsListPath);
		}
		if(_closeCreditsButtonPath != null){
			_closeCreditsButton = GetNode<Button>(_closeCreditsButtonPath);
		}
		 _creditsList.Visible = false;
		_closeCreditsButton.Visible = false;
		_creditsList.AddItem("Art: RuneWave");
		_creditsList.AddItem("Programming: DrBathound and MadKingAlger");
		_creditsList.AddItem("Music: Gary Turcotte - Birthright");
		_creditsList.AddItem('\t' + " - Harping On It Heavy Mix");
		_creditsList.AddItem("Music: Joe Reynolds - Professor Lamp");
		_creditsList.AddItem('\t' + " - Alt Rock Song");
		_creditsList.AddItem("Music: Nene - Short Theme - Short Theme V2");
		//_creditsList.AddItem("Dialogue: DrBathound and RuneWave");

	} 
	private void _on_StartGameButton_pressed()
	{
	   GetTree().ChangeScene("res://src/core/main_game/MainGame.tscn");
	}
	private void _on_QuitButton_pressed()
	{
		GetTree().Quit();
	}
	private void _on_CreditButton_pressed()
	{
		 _creditsList.Visible = true;
		_closeCreditsButton.Visible = true;
	}
	private void _on_CloseCreditsButton_pressed()
	{
		 _creditsList.Visible = false;
		_closeCreditsButton.Visible = false;
	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}












