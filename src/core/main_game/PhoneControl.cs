using Godot;
using System;

public class PhoneControl : Control
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private ItemList _guestList;
	private readonly NodePath _guestListPath = "GuestList";
	//private Button _phone;
	//private readonly NodePath _phonePath = "Phone";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_guestListPath != null){
			_guestList = GetNode<ItemList>(_guestListPath);
		}
		if(_guestList != null){
			GD.Print("node found");
		}
		
		/*if(_phonePath != null){
			_phone = GetNode<Button>(_phonePath);
		}*/
		_guestList.Visible = false;
		_guestList.AddItem("Jimmy, just a chill guy");
		_guestList.AddItem("UNINVITED: Jessica, purple cat");
		_guestList.AddItem("UNINVITED: Jimmy's evil twin, not so chill guy");
		_guestList.AddItem("Harold, he's always talking about dating");
		_guestList.AddItem("Paul, thinks he's the jonkler");
		_guestList.AddItem("Lilian, poison ivy");
		_guestList.AddItem("Emily, blue");
		_guestList.AddItem("The heathers, 3 of them");
		_guestList.AddItem("Chud, big face");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	private void _on_Phone_toggled(bool button_pressed)
	{
		if(button_pressed){
			_guestList.Visible = true;
		}else{
			_guestList.Visible = false;
		}
		
	}
}



