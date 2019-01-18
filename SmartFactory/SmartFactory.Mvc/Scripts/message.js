

function ShowMessageBox(flag, message) {
    if (flag) {
        $(".messageBox").removeClass("messageError").text(message).css("margin-left", -($(".messageBox").outerWidth() / 2)).animate({ top: 0 }, "fast").delay(1500).animate({ top: "-57px" }, "fast");
    }
    else {
        $(".messageBox").removeClass("messageError").text(message).css("margin-left", -($(".messageBox").outerWidth() / 2)).animate({ top: 0 }, "fast").delay(1500).animate({ top: "-57px" }, "fast");
    }

}




function LeftMenu(id,pid) {
    //左侧栏
    $.ajax({
        url: 'http://localhost:8066/Users/GetPermissiomUrl?id=' + localStorage.ID,
        async: false,
        type: 'get',
        //data: { id:  },
        success: function (data) {
            $(data).each(function (index, data) {
                if (data.Pid == 0) {
                    if (data.ID == pid) {
                        console.log(data.id)
                        $("#Permision_List").append("<dl><dt>" + data.PermissionName + "<i class=\"Hui-iconfont menu_dropdown-arrow\">&#xe6d5;</i></dt><dd style=\"display: block;\"><ul id=\"Permision" + data.ID + "\"></ul></dd></dl>");
                    } else {
                        $("#Permision_List").append("<dl><dt>" + data.PermissionName + "<i class=\"Hui-iconfont menu_dropdown-arrow\">&#xe6d5;</i></dt><dd><ul id=\"Permision" + data.ID + "\"></ul></dd></dl>");
                    }
                }
            })
            $(data).each(function (index, data) {
                if (data.Pid != 0) {
                    if (data.ID == id) {
                        $("#Permision" + data.Pid).append("<li class=\"current\"><a href=\"" + data.PermissionUrl + "\"  data-title=\"" + data.PermissionName + "\" href=\"javascript:void(0)\">" + data.PermissionName + "</a></li>");
                    } else {
                        $("#Permision" + data.Pid).append("<li><a href=\"" + data.PermissionUrl + "\"  data-title=\"" + data.PermissionName + "\" href=\"javascript:void(0)\">" + data.PermissionName + "</a></li>");
                    }
                }
            })
        }
    })
}