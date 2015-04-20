#pragma strict

function Start () {
	
}

function Update () {

}

function OnMouseDown () {
	var newTexture = Resources.Load('heli');
	GameObject.Find('BackgroundImage').GetComponent.<GUITexture>().texture = newTexture;
}