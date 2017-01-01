
var systemBuilderApp = angular.module('SystemBuilderApp', ['userInterfaceBuilder']);


//systemBuilderApp.controller("UIController", function UIController($scope) {
//    this.phones = [
//    {
//        name: 'Nexus S',
//        snippet: 'Fast just got faster with Nexus S.'
//    }, {
//        name: 'Motorola XOOM™ with Wi-Fi',
//        snippet: 'The Next, Next Generation tablet.'
//    }, {
//        name: 'MOTOROLA XOOM™',
//        snippet: 'The Next, Next Generation tablet.'
//    }
//    ];
//});
//var dragedImage;

//function allowDrop(ev) {
//    ev.preventDefault();
//}

//function drag(ev, target) {
//    ev.dataTransfer.setData("text", ev.target.id);
//    dragedImage = target;
//}

//function drop(ev) {
//    dragedImage.style.position = "absolute";
//    dragedImage.style.left = ev.layerX-dragedImage.width/2 + "px";
//    dragedImage.style.top = ev.layerY - dragedImage.height/2 + "px";
//    ev.preventDefault();
//    var data = ev.dataTransfer.getData("text");
//    ev.target.appendChild(document.getElementById(data));
//}