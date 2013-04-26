//change background color
function changeBackgroundColor(){
	var bgColor = document.getElementById('backgroundColor').value;//getting background color value
	var textarea = document.getElementById('text');//selectiong textarea
	textarea.style.backgroundColor = bgColor;//attaching background color
}

//change font color
function changeFontColor() {
	var fColor = document.getElementById('fontColor').value;//getting font color value
	var textarea = document.getElementById('text');//selection textarea
	textarea.style.color = fColor;//attaching font color
}
		