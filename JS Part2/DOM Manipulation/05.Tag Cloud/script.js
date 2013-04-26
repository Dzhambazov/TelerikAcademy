 function generateTags() {
	        var container = document.getElementById("container");
	        while (container.firstChild) {
	            container.removeChild(container.firstChild); //clear container - removing all container's children
	        }
	        var string = document.getElementById('text').value;
	        var arr = string.split(' ');//split string
			//stop if text field is empty
	        if (arr.length == 1) {
	            return 0;
	        }
	        var sortedElements = arr.sort();//sort elements
	     
	        var minFontSize = parseInt(document.getElementById('minSize').value);//getting  min font size
	        var maxFontSize = parseInt(document.getElementById('maxSize').value);//getting max font size

			//while sortedElements has elements
			//removing one by one using .shift()
	        while (sortedElements.length > 0) {
	            var element = sortedElements.shift();//getting first element of array
	            var similarElementsCount = 1;//similar elements counter
				
				//do while next element in array is similar to the element we get before(var element)
	            while (sortedElements[0] == element) {
	                similarElementsCount++//getting similar elements count;
	                sortedElements.shift();//remove element
	            }
				//calling function with 4 parameters
				//element - what element to print, similarElementsCount - need for font size formula
				//minFontSize and maxFontSize - need for font size formula
	            createSpan(element, similarElementsCount, minFontSize, maxFontSize);
	        }
}
		
//craeting span element
function createSpan(element, count, minFontSize, maxFontSize) {
	var container = document.getElementById("container");//getting container div
	var span = document.createElement("span");//craete new span
	span.innerText = element;// obvious
	span.style.fontSize = fontSize(count, minFontSize, maxFontSize); //getting font size using formula in fontSize function
	container.appendChild(span);//append span element to container
}

//calculates elements font size on base - their count
function fontSize(count, minFontSize, maxFontSize) {
	size = (minFontSize + (count * 4));//formula
	//prevents getting out of max size
	if (size > maxFontSize) {
		size = maxFontSize;
	}
	return size;
}