function login(email, password){
    var xmlObj = new XMLHttpRequest();
    console.log(email);
    console.log(password);
    var errorEmailId = "email-error"; // id of error show tag
    var errorPasswordId = "password-error"; // id of error show tag
    var EmailErrorObj =  document.getElementById(errorEmailId);
    var PasswordErrorObj =  document.getElementById(errorPasswordId);
    EmailErrorObj.innerHTML = "";
    PasswordErrorObj.innerHTML = "";
    console.log("kir");
    var errored = false;    // An error happened and request should not send to the server.
    var error_massage = "";     // The error massage that should show to the customer.
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if(!email){ // re-Password is empty.
        errored = true;
        EmailErrorObj.innerHTML = "ایمیل نباید خالی باشد.";
    }
    else if (re.test(email) === false){
        errored = true;
        EmailErrorObj.innerHTML = "ایمیل وارد شده معتبر نیست."
    }
    if(password.length < 8 || password.length > 22){      // Password is empty.
        errored = true;
        PasswordErrorObj.innerHTML = "پسورد باید بین 8 تا 22 کاراکتر باشد.";
    }

    if(errored){
        return false;
    }
    xmlObj.onreadystatechange = function () {
        if(xmlObj.readyState === 4 && xmlObj.status === 200){   // Response is ready
            var responseJson = JSON.parse(xmlObj.responseText);     // Parses server response to a JSON object
            if(responseJson.Status != 1){   // An Error happened in the server.
                document.getElementById(errorTagId).innerHTML = "اطلاعات وارد شده صحیح نیست.";
            }
            else{   // email and password are correct
                window.location = ""    // Redirect user Admin dashboard url
            }
        }
    };

    xmlObj.open("", true);  // Open connection to the server
    xmlObj.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');   // Set request header
    xmlObj.send("&email=" + email + "&password=" + password);  // Sends request

}

/*function signup(username, password, re_password){
    var errorTagId = "signup-error";    // id of error show tag
    var errored = false;    // An error happened and request should not send to the server.
    var error_massage = "";     // The error massage that should show to the customer.
    if(!password){      // Password is empty.
        errored = true;
        error_massage = "پسورد نباید خالی باشد.";
    }
    else if(!re_password){ // re-Password is empty.
        errored = true;
        error_massage = "تکرار پسورد باید پر شود";
    }
    else if(password !== re_password) { // Password is not equal to re-password
        errored = true;
        error_massage = "کلمات عبور یکسان نیستند.";
    }
    if(errored){
        document.getElementById(errorTagId).innerHTML = error_massage;
        return false;
    }
    var xmlObj = new XMLHttpRequest();
    xmlObj.onreadystatechange = function () {
        if(xmlObj.readyState === 4 && xmlObj.status === 200){   // Response is ready
            var responseJson = JSON.parse(xmlObj.responseText);     // Parses server response to a JSON object
            if(responseJson.Status != 1){   // An Error happened in the server.
                document.getElementById(errorTagId).innerHTML = "اطلاعات وارد شده صحیح نیست.";
            }
            else{   // Username and password are correct
                window.location = ""    // Redirect user Admin dashboard url
            }
        }
    };

    xmlObj.open();  // Open connection to the server
    xmlObj.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');   // Set request header
    xmlObj.send();  // Sends request

}*/


document.getElementById("login-submit").onclick = function () {
    var email = document.getElementsByName("email")[0].value;
    var password = document.getElementsByName("password")[0].value;
    login(email, password);
};