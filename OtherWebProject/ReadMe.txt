
home.html => anasayfa custom login işlemlerinden sonra bu sayfaya düşüyoruz.
Hoş geldiniz yazısı ve signout butonu var, kullanıcı authenticate olunca bilgiler localstorage da tutuluyor.
kullanıcı signout olursa login sayfasına yönlendiriliyoruz.

login.html => burada sisteme giriş yapmak için parola yazdığımız yer
kullanıcıadı: test@test.com
parola: 123

about => kullanıcı hakkındaki bilgileri çektiğimiz sayfa
document.ready olurken console'a kullanıcı bilgilerini çektik,
burada kullanıcı veri çekerken yetkilendirme yaptık, eğer kullanıcı authenticationdan geçmemiş ise unauthorize sayfasına yönlendiriliyor.

product => burada ürünlerin listesinin api den çekiyoruz veya url den direk ajax isteği yapmadan api ye request yapabiliyoruz.

insertproduct => api deki productcontroller'a data post etmek için kullandığımız form

mycategories => kullanıcıya ait kategorilerin apiden çekildiği sayfa

search ise url bazlı filitreleme yapmak için ODATA kullanarak veri filtrelemesi yaptığımız sayfa.
