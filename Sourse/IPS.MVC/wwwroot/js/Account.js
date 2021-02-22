function sendVeri(obj) {
    if (obj.id != "sent") {
        $.ajax({
            url: 'sendvericode',
            data: { email: $('input[name=Email]').val() },
            type: 'post',
            dataType: 'json',
            success: function (data) {
                if (data.result) {
                    obj.disabled = true;
                    obj.val("请输入验证码");
                } else {
                    alert(data.message);
                }
            }
        });
    }
}