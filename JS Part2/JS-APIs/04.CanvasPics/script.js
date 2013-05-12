(function(){

	var ctx = document.getElementsByTagName('canvas')[0].getContext('2d');
	
	ctx.fillStyle = "brown";
 	ctx.strokeStyle = "#000"

		ctx.lineWidth = 1;

		ctx.fillRect(100,200,300,300);
		ctx.strokeRect(100,200,300,300);

		ctx.fillRect(130,400,80,100);
		ctx.strokeRect(130,400,80,100);

   		ctx.beginPath();
    	ctx.strokeStyle = "black";
   		ctx.lineWidth = 2;
		ctx.moveTo(100,200);
		ctx.lineTo(250,50);
		ctx.lineTo(400,200);
		ctx.stroke();
		ctx.fill();
		ctx.closePath();

		ctx.moveTo(300,70);
		ctx.fillRect(300,70,20,50);

		ctx.fillStyle = "000";

		ctx.fillRect(120,240,50,30);
		ctx.strokeRect(120,240,50,30);
		ctx.fillRect(175,240,50,30);
		ctx.strokeRect(175,240,50,30);
		ctx.fillRect(120,275,50,30);
		ctx.strokeRect(120,275,50,30);
		ctx.fillRect(175,275,50,30);
		ctx.strokeRect(175,275,50,30);

		ctx.fillRect(270,240,50,30);
		ctx.strokeRect(270,240,50,30);
		ctx.fillRect(325,240,50,30);
		ctx.strokeRect(325,240,50,30);
		ctx.fillRect(270,275,50,30);
		ctx.strokeRect(270,275,50,30);
		ctx.fillRect(325,275,50,30);
		ctx.strokeRect(325,275,50,30);

		ctx.fillRect(270,360,50,30);
		ctx.strokeRect(270,360,50,30);
		ctx.fillRect(325,360,50,30);
		ctx.strokeRect(325,360,50,30);
		ctx.fillRect(270,395,50,30);
		ctx.strokeRect(270,395,50,30);
		ctx.fillRect(325,395,50,30);
		ctx.strokeRect(325,395,50,30);

		ctx.beginPath();
    	ctx.strokeStyle = "black";
   		ctx.lineWidth = 2;
		ctx.moveTo(170,500);
		ctx.lineTo(170,400);
		ctx.stroke();
		ctx.closePath();
		 
		ctx.moveTo(160,450);
  	    ctx.arc(160, 450, 5, 0, 2 * Math.PI, false);
   	    ctx.moveTo(180,450);
  	    ctx.arc(180, 450, 5, 0, 2 * Math.PI, false);
    ctx.stroke();
}());