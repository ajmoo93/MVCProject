var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Animals;
(function (Animals) {
    var snake = (function (_super) {
        __extends(snake, _super);
        function snake(theName) {
            _super.call(this, theName);
        }
        return snake;
    })(animal);
    Animals.snake = snake;
})(Animals || (Animals = {}));
