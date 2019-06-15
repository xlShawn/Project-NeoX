public var fadeOutTexture : Texture2D;
public var fadeSpeed = 0.3;

var drawDepth = -1000;

private var alpha = 1.0; 
private var fadeDir = -1;



function OnGUI(){
    
    alpha += fadeDir * fadeSpeed * Time.deltaTime;  
    alpha = Mathf.Clamp01(alpha);   
    
    GUI.color.a = alpha;
    
    GUI.depth = drawDepth;
    
    GUI.DrawTexture(Rect(-10, -10, Screen.width+10, Screen.height+10), fadeOutTexture);
}

//Входим в темноту

function fadeIn(){
    fadeDir = 1;   
}

//Выходим из темноты

function fadeOut(){
    fadeDir = -1;    
}

function Start(){
    alpha=1;
}