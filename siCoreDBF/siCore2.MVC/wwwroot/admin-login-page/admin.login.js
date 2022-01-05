function girisKontrol(kullanici,sifre){
    var kullanici = document.getElementById("username").value;
    var sifre = document.getElementById("password").value;


    if (kullanici=="admin") {
        if (sifre=="123"){
           alert("Giriş Yapıldı");
            window.location.replace("https://localhost:44396/Futbol2122SezonTr1");
            return true;
        }

       
    }
    else if (kullanici=!"admin"){
        if (sifre=="123"){
            alert("Kullanıcı Adı Yalnış");
            return false;
        }
    }
    else if (kullanici=="admin"){
        if (sifre=!"123"){
            alert("Şifreniz Yalnış");
            return false;
        }
    }
    else {
        alert ("Şifre ve Kullanıcı adı yanlış");
        return false;
    }
}






