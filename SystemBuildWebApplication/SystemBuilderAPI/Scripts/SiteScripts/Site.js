var curentDragTarget;
var testHolder;
function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev, target) {
    curentDragTarget = target;
    ev.dataTransfer.setData("text", ev.target.id);
    dragedImage = target;
}

function drop(ev) {
    curentDragTarget.style.left = (ev.layerX - curentDragTarget.width / 2)+"px";
    curentDragTarget.style.top = (ev.layerY - curentDragTarget.height / 2)+"px";
    //dragedImage.style.position = "absolute";
    //dragedImage.style.left = ev.layerX-dragedImage.width/2 + "px";
    //dragedImage.style.top = ev.layerY - dragedImage.height/2 + "px";
    ev.preventDefault();
    //var data = ev.dataTransfer.getData("text");
    //ev.target.appendChild(document.getElementById(data));
}