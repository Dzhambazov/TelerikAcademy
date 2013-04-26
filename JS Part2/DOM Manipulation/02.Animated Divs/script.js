//generate random color  example - #EEEEFF
		function getRandomColor() {
            var symbols = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F";
            var symbolsArr = symbols.split(',');
            var color = "#";
            for (var i = 0; i < 6; i++) {
                color += symbolsArr[Math.floor(Math.random()*15)];
            }
            return color;
        }
		
		//create div
		function createDiv() {
			var div = document.createElement('div');
			div.className = "coloredCircle"; //attach css class to the div
			div.style.backgroundColor = getRandomColor(); //random background color
			div.style.borderColor = getRandomColor(); //random border color
			document.body.appendChild(div);
		}
		
		//generate 5 divs
		for(var i = 0; i < 5; i++) {
			createDiv();
		}

		var allDivs = document.querySelectorAll('div');
		var angle = 0;
		
		//animation function getting radius as parameter
		function animation (radius) {
			for(i = 0; i < 5; i++) {
				var left = Math.cos(angle + 2 * Math.PI / allDivs.length * i)/radius * 10000 + 'px'; //getting left
				allDivs[i].style.left = left;
				var top = Math.sin(angle + 2 * Math.PI / allDivs.length* i)/radius * 10000 + 'px'; //getting top
				allDivs[i].style.top = top;
			}
			angle += 0.1;
			setTimeout(function(){animation(radius);}, 100);//calling function on every 100ms
		}
		animation(100); //radius as parameter = 100