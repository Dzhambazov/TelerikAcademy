 function createSomeDivs() {
            var container = document.getElementById('wrapper');
            var count = document.getElementById('count').value;

            while (container.firstChild) {
                container.removeChild(container.firstChild); // remove all container children
            }
            for (var i = 0; i < count; i++) {
                var div = document.createElement("div");
                div.className = "colored";
                div.style.position = "absolute";
                div.style.width = getRandomBetweenNumbers(20, 100) + "px";
                div.style.height = getRandomBetweenNumbers(20, 100) + "px";
                div.style.top = getRandomBetweenNumbers(100, screen.height - 300) + "px";
                div.style.left = getRandomBetweenNumbers(100, screen.width - 300) + "px";
                div.style.background = getRandomColor();
                div.style.color = getRandomColor();
                div.style.borderRadius = getRandomBetweenNumbers(0, 100) + "px";
                div.style.borderColor = getRandomColor();
                div.style.borderStyle = "solid"
                div.style.borderWidth = getRandomBetweenNumbers(1, 20) + "px";
                var strongElement = document.createElement("strong");
                strongElement.innerHTML = "div";
                div.appendChild(strongElement);
                container.appendChild(div);
            }
        }

		//get random number between two numbers - min and max
        function getRandomBetweenNumbers(min, max) {
            var random = Math.floor(min + Math.random() * max);
            return random;
        }
		
		//generate random color
        function getRandomColor() {
            var symbols = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F";
            var symbolsArr = symbols.split(',');
            var color = "#";
            for (var i = 0; i < 6; i++) {
                color += symbolsArr[Math.floor(Math.random()*15)];
            }
            return color;
        }