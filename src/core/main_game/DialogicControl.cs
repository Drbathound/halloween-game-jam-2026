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
		//var dialogic = (Node)GetNode("root/MainGame/World/DialogicControl/@@8/DialogNode");
		new_dialog.Connect("dialogic_signal", this, "dialog_listener");
		//ToSignal(dialogic, "dialogic_signal");
		//var dialogic = (Node)GetNode("root/MainGame/World/DialogicControl/@@8/DialogNode");
		//dialogic.Connect("jessicaEnd", this, nameof(OndialogicSignal));
		GD.Print("jessicaend should be connected");
		//new_dialog.Connect("dialogic_signal", this, nameof(OndialogicSignal));
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
	private void OndialogicSignal(){
		GD.Print("got to signal");
	}
	public void MyTestMethod(){
		GD.Print("mytestmethod called");
	}
	public void dialog_listener(string input){
		//GD.Print("picked up input");
		if(input!= "party_success"){
			_gameOverControl.OnGuestEnd();
		}else{
			_gameOverControl.SuccessfulParty();
		}
		
	}
}
