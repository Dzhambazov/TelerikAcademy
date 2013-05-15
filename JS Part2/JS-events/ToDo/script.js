(function(){
				var list = [];
				var tempList = [];
				var counter = 0;
				document.getElementById('load').addEventListener('click', function(){
					var allItems = localStorage.getObject("todo");
					 

					if(counter == 0){
						console.log(counter);
						for (var i = 0; i < allItems.length; i++) {
							var input = allItems[i].title;
							add(input);
						};
						counter++;
					}
					list = tempList;
				}, false);

				function add(input){
					var li = document.createElement('li');
					li.addEventListener("click",clickLi, false);
					var span = document.createElement('span');
					span.innerText = input;

					var element = document.createElement('input');
					element.type = "radio";
					element.name = "todo";
					li.appendChild(element);
					li.appendChild(span);
					container.appendChild(li);
					var thisItem = {
						title:input
					};
					tempList.push(thisItem);
				}


				document.getElementById('save').addEventListener('click', function(){
					localStorage.setObject("todo", list);
				}, false)
				 

				 document.getElementById('clear').addEventListener('click',function(){
				 	localStorage.clear();
				 	var container = document.getElementById('list-container');
				 	while(container.firstChild){
				 		container.removeChild(container.firstChild);
				 	}
				 },false)

				var addButton = document.getElementById('addButton');
				var delButton = document.getElementById('delButton');
				var hideButton = document.getElementById('hideButton');
				var showButton = document.getElementById('showButton');
				var container = document.getElementById('list-container');

				 var test = document.getElementById('wtf');


				addButton.onclick = function(){
					var input = document.getElementById('input').value;
					add(input);
				}

				delButton.onclick = function(){
					var allItems = container.querySelectorAll('input');  
					var checkedElement;
					for (var i = 0; i < allItems.length; i++) {
						if (allItems[i].checked) {
							checkedElement = allItems[i];
							break;
						};
					};
					var divToRemove = checkedElement.parentNode;
					divToRemove.parentNode.removeChild(divToRemove);
				}

				hideButton.onclick = function(){
					var allItems = container.querySelectorAll('input');
					var checkedElement;
					for (var i = 0; i < allItems.length; i++) {
						if (allItems[i].checked) {
							checkedElement = allItems[i];
							break;
						};
					};
					checkedElement.checked = false;
					var divToHide = checkedElement.parentNode;
					divToHide.style.display = "none";
				}

				showButton.onclick = function(){
					var allItems = container.querySelectorAll('input');
					for (var i = 0; i < allItems.length; i++) {
						if (allItems[i].parentNode.style.display = "none") {
							allItems[i].parentNode.style.display = "block"
						};
					};
				}

				function clickLi(){
			 	var button = this.querySelector('input');
			 	button.checked = "checked";

			 	var parent = this.parentNode;
			 	var allElements = parent.querySelectorAll('li');
			 	for (var i = 0; i < allElements.length; i++) {
			 		allElements[i].style.background = "#404040";
			 	};

			 	this.style.background = "#808080";
			 }
				  
			}());