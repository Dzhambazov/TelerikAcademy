var li = document.querySelectorAll("li");//put all LI elements in list
//add event to each LI element
for (var i = 0; i < li.length; i++) {
	  li[i].addEventListener("click", ShowHide, false);
}

function ShowHide() {
	ul = this.getElementsByTagName('ul');
	//do nothing if there're no UL elements in the selected li
	if (ul[0] == null) {
		return 0;
	}
	//change css class
	if (this === event.target && ul[0].className != 'hidden') {
		ul[0].className = 'hidden';
	}
	else {
		ul[0].className = 'show';
	}
}
	    