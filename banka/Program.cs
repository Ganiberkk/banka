Console.WriteLine("GB Bank Hoşgeldiniz");
        Console.WriteLine("Hesabınız Varsa Giriş Yapın Yoksa Hesap Açın");
        Console.WriteLine("Hesabınz Varsa 'E' Yoksa 'H' Tuşuna Basın");
        string a = Console.ReadLine();
        //Kullanıcıları hazızaya atsın?//
        int i = 0;
        decimal TC = 0;
        decimal Tel = 0;
        string Sifre = "0";
        while (i < 1)
        {
            if (a == "E" || a == "e")
            {
                i++;
            }
            else if (a == "H" || a == "h")
            {
                Console.WriteLine("TC Kimlik Numarınızı Giriniz");

                TC = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Telefon Numaranızı Giriniz");
                Tel = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Şifre Oluşturun");
                Sifre = Console.ReadLine();
                Console.WriteLine("Hesabınız Oluşturulmuştur");
                i++;
            }
            else
            {
                Console.WriteLine("Yanlış Tuşa Bastınız Tekrar Deneyinz");
                a = Console.ReadLine();

            }
        }
        Console.WriteLine("Hoşgeldiniz");
        Console.WriteLine("TC Kimlik Numaranızı Giriniz");
        decimal Tc = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Şifrenizi Giriniz");
        string sifre = Console.ReadLine();
        if (Tc == TC && sifre == Sifre)
        {
            decimal hesap = 0.00m;
            decimal ek = 1000;
            Console.WriteLine($"Hesabınızdaki Para {hesap} TL");
            Console.WriteLine("Hoşgeldiniz Ne İşlem Yapmak İstersiniz");
            int tekakrar = 1;
            while (0 < tekakrar)
            {
                Console.WriteLine("Para Yatırma için (Y) ye Basın, Para Çekmek için (C) ye basın");
                string işlem = Console.ReadLine();
                if (işlem == "y" || işlem == "Y")
                {
                    Console.WriteLine("Ne Kadar Para Yatırmak İstiyorsunuz");
                    decimal yatan = Convert.ToDecimal(Console.ReadLine());
                    hesap = hesap + yatan;
                    Console.WriteLine($"Hesabınızdaki Para {hesap} TL");
                    Console.WriteLine("İşleminiz Bitti Mi Bitti ise e ye Basın Bitmedi ise h ye");
                    string iş = Console.ReadLine();
                    if (iş == "e" || iş == "E")
                    {
                        Console.WriteLine("Kartınızı Unutmayı Sağlıklı ve İyi Günler Dileriz");
                        tekakrar--;
                    }
                    else if (iş == "h" || iş == "H")
                    {

                    }
                    else
                    {
                        int tt = 1;
                        while (0 < tt)
                        {
                            Console.WriteLine("Yanlış Tuşa Bastınız Tekrar Deneyiniz");
                            Console.WriteLine("İşleminiz Bitti Mi Bitti ise e ye Basın Bitmedi ise h ye");
                            string t1 = Console.ReadLine();
                            if (t1 == "e" || iş == "E")
                            {
                                Console.WriteLine("Kartınızı Unutmayı Sağlıklı ve İyi Günler Dileriz");
                                tt--;
                                tekakrar--;
                            }
                            else if (t1 == "h" || t1 == "H")
                            {
                                tt--;
                            }
                            else
                            {

                            }

                        }
                    }


                }
                else if (işlem == "c" || işlem == "C")
                {
                    if (hesap <= 0)
                    {
                        Console.WriteLine($"Ek Para Limitiniz {ek} TL Dir");
                        Console.WriteLine("Ne Kadar Para Çekmek İstiyorsunuz");
                        decimal cek = Convert.ToDecimal(Console.ReadLine());
                        if (cek > ek)
                        {
                            Console.WriteLine("Hesabınızda o kadar para yok");
                        }
                        else
                        {
                            ek = ek + hesap - cek;
                            Console.WriteLine($"Çekilebilir Ek Para Limitiniz {ek} TL dir");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ne Kadar Para Çekmek İstiyorsunuz");
                        decimal cekilen = Convert.ToDecimal(Console.ReadLine());
                        if (cekilen > hesap)
                        {
                            hesap = hesap - cekilen;
                            ek = ek + hesap;
                            hesap = 0;
                            Console.WriteLine($"Hesabınızdaki Para {hesap} TL");
                            Console.WriteLine($"Ekpara kalan limitiniz {ek} TL");
                        }
                        else
                        {
                            hesap = hesap - cekilen;
                            Console.WriteLine($"Hesabınızdaki Para {hesap} TL");
                        }
                    }
                    Console.WriteLine("İşleminiz Bitti Mi Bitti ise e ye Basın Bitmedi ise h ye");
                    string iş = Console.ReadLine();
                    if (iş == "e" || iş == "E")
                    {
                        Console.WriteLine("Kartınızı Unutmayı Sağlıklı ve İyi Günler Dileriz");
                        tekakrar--;
                    }
                    else if (iş == "h" || iş == "H")
                    {

                    }
                    else
                    {
                        int tt = 1;
                        while (0 < tt)
                        {
                            Console.WriteLine("Yanlış Tuşa Bastınız Tekrar Deneyiniz");
                            Console.WriteLine("İşleminiz Bitti Mi Bitti ise e ye Basın Bitmedi ise h ye");
                            string t1 = Console.ReadLine();
                            if (t1 == "e" || iş == "E")
                            {
                                Console.WriteLine("Kartınızı Unutmayın Sağlıklı ve İyi Günler Dileriz");
                                tt--;
                                tekakrar--;
                            }
                            else if (t1 == "h" || t1 == "H")
                            {
                                tt--;
                            }
                            else
                            {

                            }

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                }
            }
        }
        else
        {
            Console.WriteLine("TC niz yada Şifrenizi Yanlış Giridiniz");
        }
    
