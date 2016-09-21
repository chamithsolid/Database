/// <reference path="../dts/jquery.d.ts" />
/// <reference path="../dts/kendo.all.d.ts" />
var Master;
(function (Master) {
    $(function () {
    });
    Master.init = {
        pageNavigator: function (pages) {
            if (pages === void 0) { pages = Pages.Student; }
        }
    };
    (function (Pages) {
        Pages[Pages["Student"] = 0] = "Student";
        Pages[Pages["Subject"] = 1] = "Subject";
        Pages[Pages["StudentSubject"] = 3] = "StudentSubject";
    })(Master.Pages || (Master.Pages = {}));
    var Pages = Master.Pages;
})(Master || (Master = {}));
