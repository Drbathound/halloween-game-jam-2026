using Godot;
using System;
using System.Drawing.Text;
using System.Windows.Markup;

public class GameOverRoot : Control
{
	private enum LossType{
			noBeer,
		allBeer,
		noVape,
		allVape,
		guest
	}
	/* struct LossType{
		public const string noBeer = "noBeer";
		public const string allBeer = "allBeer";
		public const string noVape = "noVape";
		public const string allVape = "allVape";
		public const string guest = "guest";
	
	} */
	
	private bool _isGameOver = false;
	public bool IsGameOver{
		get => _isGameOver;
	}
	/* public bool GetIsGameOver(){
		return _isGameOver;
	} */
	//private bool _isGameLose = false;
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private Control _loseRoot;
	private NodePath _loseRootPath = "LoseRoot";
	private Control _winRoot;
	private NodePath _winRootPath = "WinRoot"; 
	private VapeControl _vapeControl;
	private NodePath _vapeControlPath = "%VapeControl";
	private BeerControl _beerControl;
	private NodePath _beerControlPath = "%BeerControl";
	private Node _dialogic;
	private NodePath _dialogicPath = "root/MainGame/World/DialogicControl/Dialogic";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(_loseRootPath != null){
			_loseRoot = GetNode<Control>(_loseRootPath);
			_loseRoot.Visible = false;
		}
		if(_winRootPath != null){
			_winRoot = GetNode<Control>(_winRootPath);
			_winRoot.Visible = false;
		} 
		if(_vapeControlPath != null){
			_vapeControl = GetNode<VapeControl>(_vapeControlPath);
			_vapeControl.Connect(nameof(VapeControl.VapeSpam), this, nameof(OnVapeSpamDetect));
		}
		if(_beerControlPath != null){
			_beerControl = GetNode<BeerControl>(_beerControlPath);
			_beerControl.Connect(nameof(BeerControl.BeerMax), this, nameof(OnBeerMaxDetect));
		}
		//_dialogic = GetNode<Node>(_dialogicPath);
		//_dialogic.Connect(nameof(Node.jessicaEnd), this, nameof(OnGuestEnd));
	}
	public void SuccessfulParty(){
		_isGameOver = true;
		_winRoot.Visible = true;
	}
	public void OnGuestEnd(){
		if(!_isGameOver){
			_isGameOver = true;
			_gameLost(LossType.guest);
		}
	}
	private void OnBeerMaxDetect(){
		if(!_isGameOver){
			//GD.Print("vape progress hit 0");
		_isGameOver = true;
		//GD.Print(LossType.noVape.ToString());
		//GD.Print("calling gamelost");
		_gameLost(LossType.allBeer);
		}
	}
	private void _on_TextureProgress_value_changed(float value)
	{
		if(value <= 0 && !_isGameOver){
			//GD.Print("beer progress hit 0");
			_isGameOver = true;
		_gameLost(LossType.noBeer);
		}
		
		
	}
	private void OnVapeSpamDetect(){
		if(!_isGameOver){
			//GD.Print("vape progress hit 0");
		_isGameOver = true;
		//GD.Print(LossType.noVape.ToString());
		//GD.Print("calling gamelost");
		_gameLost(LossType.allVape);
		}
	}
	private void _on_VapeProgress_value_changed(float value)
	{
	//GD.Print("vape progress callsed");
		if(value <= 0 && !_isGameOver){
			//GD.Print("vape progress hit 0");
		_isGameOver = true;
		//GD.Print(LossType.noVape.ToString());
		//GD.Print("calling gamelost");
		_gameLost(LossType.noVape);
		}
		//GD.Print("vape progress returned");
		
	}

	
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
	}
	private void _gameLost(LossType loseCond){
		_loseRoot.Visible = true;
		//GD.Print(loseCond.ToString());
		//GD.Print("switch statement");
		switch (loseCond){
			case LossType.noBeer:
			//GD.Print("beer condition");
				var no_beer_dialog = DialogicSharp.Start("noBeer");
				AddChild(no_beer_dialog);
			break;
			case LossType.allBeer:
			var all_beer_dialog = DialogicSharp.Start("allBeer");
			AddChild(all_beer_dialog);
			break;
			case LossType.noVape:
			//GD.Print("vape condition");
			var no_vape_dialog = DialogicSharp.Start("noVape");
			AddChild(no_vape_dialog);
			break;
			case LossType.allVape:
			var all_vape_dialog = DialogicSharp.Start("allVape");
			AddChild(all_vape_dialog);
			break;
			case LossType.guest:
			var guest_bad_dialog = DialogicSharp.Start("guestBadEnd");
			AddChild(guest_bad_dialog);
			break;
			default:
			var default_dialog = DialogicSharp.Start("defaultLoss");
			AddChild(default_dialog);
			break;
		}

	}
}









