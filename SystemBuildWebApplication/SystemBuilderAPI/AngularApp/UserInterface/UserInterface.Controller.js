angular.module("userInterfaceBuilder").controller("UserInterfaceBuilderController", function UIController() {
    this.ImageDirectory = "/Images"
    this.drop = function(event)
    {
        var c = true;
    }

    this.drag = function(event, target)
    {
        var d = true;
    }

    this.allowDrop = function (event)
    {
        var b = true;
    }
    this.Images = [
        {
            width: 336,
            height: 69,
            x: 300,
            y:300,
            file: "img_logo.gif"
        }
    ]
    testHolder = this.Images;
    this.phones = [
        {
            name: 'Nexus S',
            snippet: 'Fast just got faster with Nexus S.'
        }, {
            name: 'Motorola XOOM™ with Wi-Fi',
            snippet: 'The Next, Next Generation tablet.'
        }, {
            name: 'MOTOROLA XOOM™',
            snippet: 'The Next, Next Generation tablet.'
        }
    ];
});