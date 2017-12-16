(function ($) {

    if (!$) {
        return;
    }


    $("#GetCodeButton").click(function () {

        //获取输入的手机号码
        var phoNum = $("#UserName").val();
        alert(phoNum);
        curCount = count;

        //用正则表达式验证手机号是否合法
        //var re = /(^1[3|5|8][0-9]{9}$)/;
        //略
        // 产生随记验证码    
        for (var i = 0; i < codeLength; i++) {
            code += parseInt(Math.random() * 9).toString();
        }

        // 设置按钮显示效果，倒计时   
        $("#GetCodeButton").attr("disabled", "true");
        $("#GetCodeButton").val("请在" + curCount + "秒内输入验证码");
        InterValObj = window.setInterval(SetRemainTime, 1000); // 启动计时器，1秒执行一次    

        // 向后台发送处理数据    
        $.ajax({
            type: "POST", // 用POST方式传输    
            dataType: "text", // 数据格式:JSON    
            url: "/Register/GetCode", // 目标地址    
            data: { "Code": code, "phoNum": phoNum },
            error: function (msg) {
                alert(msg);
            },
            success: function (data) {
                //前台给出提示语
                if (data == "true") {
                    $("#telephonenameTip").html("<font color='#339933'>√ 短信验证码已发到您的手机,请查收(30分钟内有效)</font>");
                } else if (data == "false") {
                    $("#telephonenameTip").html("<font color='red'>× 短信验证码发送失败，请重新发送</font>");
                    return false;
                }
            }
        });

    });




    $(function () {

        var $registerForm = $('#RegisterForm');

        $.validator.addMethod("customUsername", function (value, element) {
            if (value === $registerForm.find('input[name="EmailAddress"]').val()) {
                return true;
            }

            //Username can not be an email address (except the email address entered)
            return !$.validator.methods.email.apply(this, arguments);
        }, abp.localization.localize("RegisterFormUserNameInvalidMessage", "CardCloud"));

        $registerForm.validate({
            rules: {
                UserName: {
                    required: true,
                    customUsername: true,
                }
                 
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });
    });

})();